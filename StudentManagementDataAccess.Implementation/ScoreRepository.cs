using Dapper;
using StudentManagement.Core.Models;
using StudentManagementData.Abstractions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementDataAccess.Implementation
{
    /// <summary>
    /// 分数数据仓库类，负责所有与分数表相关的数据库操作
    /// </summary>
    public class ScoreRepository : IScoreRepository
    {
        private readonly IDbConnectionFactory _connectionFactory;

        public ScoreRepository(IDbConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }



        public async Task<DataTable> GetAllScoresAsync()
        {
            using (IDbConnection connection = _connectionFactory.GetConnection())
            {
                string sql = @"SELECT s.sid, st.sname, s.cid, c.cname, s.score 
                              FROM sc s 
                              LEFT JOIN student st ON s.sid = st.sid 
                              LEFT JOIN course c ON s.cid = c.cid";
                try
                {
                    var dataTable = new DataTable();
                    using (var reader = await connection.ExecuteReaderAsync(sql))
                    {
                        dataTable.Load(reader);
                    }
                    return dataTable;
                }
                catch (Exception ex)
                {
                    throw new Exception("获取所有分数信息时发生错误", ex);
                }
            }
        }

        public async Task<DataTable> DynamicQueryAsync(int? studentId, string cname, int? minScore, int? maxScore)
        {
            var sqlBuilder = new StringBuilder(@"SELECT s.sid, st.sname, s.cid, c.cname, s.score 
                                                FROM sc s 
                                                LEFT JOIN student st ON s.sid = st.sid 
                                                LEFT JOIN course c ON s.cid = c.cid");
            var conditions = new List<string>();
            var parameters = new DynamicParameters();

            // 按学生ID查询
            if (studentId.HasValue && studentId.Value > 0)
            {
                conditions.Add("s.sid = @StudentId");
                parameters.Add("StudentId", studentId.Value);
            }

            // 按课程名查询
            if (!string.IsNullOrEmpty(cname))
            {
                conditions.Add("c.cname = @CourseName");
                parameters.Add("CourseName", cname);
            }

            // 按分数范围查询
            if (minScore.HasValue && minScore.Value >= 0)
            {
                conditions.Add("s.score >= @MinScore");
                parameters.Add("MinScore", minScore.Value);
            }

            if (maxScore.HasValue && maxScore.Value >= 0)
            {
                conditions.Add("s.score <= @MaxScore");
                parameters.Add("MaxScore", maxScore.Value);
            }

            if (conditions.Any())
            {
                sqlBuilder.Append(" WHERE ");
                sqlBuilder.Append(string.Join(" AND ", conditions));
            }

            using (IDbConnection connection = _connectionFactory.GetConnection())
            {
                try
                {
                    var dataTable = new DataTable();
                    using (var reader = await connection.ExecuteReaderAsync(sqlBuilder.ToString(), parameters))
                    {
                        dataTable.Load(reader);
                    }
                    return dataTable;
                }
                catch (Exception ex)
                {
                    throw new Exception("动态查询分数信息时发生错误", ex);
                }
            }
        }

        public async Task<bool> SaveChangesAsync(DataTable scoreTable)
        {
            DataTable changes = scoreTable.GetChanges();
            if (changes == null || changes.Rows.Count == 0)
            {
                return true;
            }

            using (IDbConnection connection = _connectionFactory.GetConnection())
            {
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        int totalRowsAffected = 0;

                        // 处理删除的行
                        var deletedRows = changes.AsEnumerable().Where(r => r.RowState == DataRowState.Deleted).ToList();
                        if (deletedRows.Any())
                        {
                            foreach (var row in deletedRows)
                            {
                                var studentId = row["sid", DataRowVersion.Original];
                                var courseId = row["cid", DataRowVersion.Original];
                                totalRowsAffected += await connection.ExecuteAsync(
                                    "DELETE FROM sc WHERE sid = @Sid AND cid = @Cid",
                                    new { Sid = studentId, Cid = courseId },
                                    transaction);
                            }
                        }

                        // 处理修改的行
                        var modifiedRows = changes.AsEnumerable().Where(r => r.RowState == DataRowState.Modified).ToList();
                        if (modifiedRows.Any())
                        {
                            totalRowsAffected += await connection.ExecuteAsync(
                                "UPDATE sc SET score = @Score WHERE sid = @Sid AND cid = @Cid",
                                modifiedRows.Select(r => new
                                {
                                    Sid = r.Field<int>("sid"),
                                    Cid = r.Field<int>("cid"),
                                    Score = r.Field<int>("score")
                                }),
                                transaction);
                        }

                        // 处理新增的行
                        var addedRows = changes.AsEnumerable().Where(r => r.RowState == DataRowState.Added).ToList();
                        if (addedRows.Any())
                        {
                            totalRowsAffected += await connection.ExecuteAsync(
                                "INSERT INTO sc (sid, cid, score) VALUES (@Sid, @Cid, @Score)",
                                addedRows.Select(r => new
                                {
                                    Sid = r.Field<int>("sid"),
                                    Cid = r.Field<int>("cid"),
                                    Score = r.Field<int>("score")
                                }),
                                transaction);
                        }

                        transaction.Commit();
                        scoreTable.AcceptChanges();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        scoreTable.RejectChanges();
                        throw new Exception("保存分数更改时发生错误，操作已回滚。", ex);
                    }
                }
            }
        }

        public async Task<bool> UpdateScoreAsync(Score score)
        {
            using (IDbConnection connection = _connectionFactory.GetConnection())
            {
                string sql = "UPDATE sc SET score = @ScoreValue WHERE sid = @Sid AND cid = @Cid";
                try
                {
                    var result = await connection.ExecuteAsync(sql, score);
                    return result > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("更新分数信息时发生错误", ex);
                }
            }
        }

        public async Task<bool> UpdateScoreAsync(List<Score> scores)
        {
            using (IDbConnection connection = _connectionFactory.GetConnection())
            {
                string sql = "UPDATE sc SET score = @ScoreValue WHERE sid = @Sid AND cid = @Cid";
                try
                {
                    var result = await connection.ExecuteAsync(sql, scores);
                    return result > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("批量更新分数信息时发生错误", ex);
                }
            }
        }

        public async Task<bool> DeleteScoreAsync(int studentId, int courseId)
        {
            using (var connection = _connectionFactory.GetConnection())
            {
                string sql = "DELETE FROM sc WHERE sid = @StudentId AND cid = @CourseId";
                try
                {
                    var result = await connection.ExecuteAsync(sql, new { StudentId = studentId, CourseId = courseId });
                    return result > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("删除分数信息时发生错误", ex);
                }
            }
        }

        public async Task<bool> DeleteScoreAsync(List<Score> scores)
        {
            using (IDbConnection connection = _connectionFactory.GetConnection())
            {
                string sql = "DELETE FROM sc WHERE sid = @Sid AND cid = @Cid";
                try
                {
                    var result = await connection.ExecuteAsync(sql, scores);
                    return result > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("批量删除分数信息时发生错误", ex);
                }
            }
        }

        public async Task<bool> InsertScoreAsync(Score score)
        {
            using (IDbConnection connection = _connectionFactory.GetConnection())
            {
                string sql = "INSERT INTO sc (sid, cid, score) VALUES (@Sid, @Cid, @ScoreValue)";
                try
                {
                    var result = await connection.ExecuteAsync(sql, score);
                    return result > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("插入分数信息时发生错误", ex);
                }
            }
        }

        public async Task<bool> InsertScoreAsync(List<Score> scores)
        {
            using (IDbConnection connection = _connectionFactory.GetConnection())
            {
                string sql = "INSERT INTO sc (sid, cid, score) VALUES (@Sid, @Cid, @ScoreValue)";
                try
                {
                    var result = await connection.ExecuteAsync(sql, scores);
                    return result > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("批量插入分数信息时发生错误", ex);
                }
            }
        }
    }
}