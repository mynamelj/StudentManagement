using Dapper; // 引入Dapper命名空间
using Microsoft.IdentityModel.Tokens;
using StudentManagement.Core.Models;
using StudentManagementData.Abstractions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace StudentManagementDataAccess.Implementation
{
    /// <summary>
    /// 学生数据仓库类，负责所有与学生表相关的数据库操作
    /// </summary>
    public class StudentRepository : IStudentRepository
    {
        private readonly IDbConnectionFactory _connectionFactory;
        public StudentRepository(IDbConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }
        public async Task<bool> DeleteAsync(int id)
        {
            using (var connection = _connectionFactory.GetConnection())
            {
                string sql = "DELETE FROM Student WHERE sid = @Id";
                try
                {
                    var result = await connection.ExecuteAsync(sql, new { Id = id });
                    return result > 0; // 返回受影响的行数是否大于0
                }
                catch (Exception ex)
                {
                    // 处理异常，例如记录日志
                    throw new Exception("删除学生信息时发生错误", ex);
                }
            }
        }

        public async Task<bool> DeleteAsync(List<Student> students)
        {
            using (IDbConnection connection = _connectionFactory.GetConnection())
            {
                string sql = "DELETE FROM Student WHERE sid = @Sid";
                try
                {
                    var result = await connection.ExecuteAsync(sql, students);
                    return result > 0; // 返回受影响的行数是否大于0
                }
                catch (Exception ex)
                {
                    // 处理异常，例如记录日志
                    throw new Exception("批量删除学生信息时发生错误", ex);
                }
            }
        }

        public async Task<DataTable> DynamicQuery(Student student, DateTime start_date, DateTime end_date)
        {
            var sqlBuilder = new StringBuilder("SELECT sid, sname, sage, ssex FROM Student");
            var conditions = new List<string>();
            var parameters = new DynamicParameters();
            
            // 如果提供了具体的学生ID，则只按ID查询，忽略其他条件
            if (student.Sid > 0)
            {
                conditions.Add("sid = @Sid");
                parameters.Add("Sid", student.Sid);
            }
            else
            {
                // 按姓名模糊查询
                if (!string.IsNullOrEmpty(student.Sname))
                {
                    conditions.Add("sname LIKE @Sname");
                    parameters.Add("Sname", $"%{student.Sname}%");
                }
                
                // 日期范围查询 - 使用默认值来判断是否设置了有效日期
                // DateTimePicker的默认最小值通常是1753/1/1，可以用来判断是否被设置
                DateTime minValidDate = new DateTime(1900, 1, 1); // 设定一个合理的最小有效日期
                
                bool hasStartDate = start_date > minValidDate;
                bool hasEndDate = end_date > minValidDate;
                
                if (hasStartDate && hasEndDate)
                {
                    // 有开始和结束日期
                    if (start_date.Date <= end_date.Date)
                    {
                        conditions.Add("sage BETWEEN @StartDate AND @EndDate");
                        parameters.Add("StartDate", start_date.Date);
                        parameters.Add("EndDate", end_date.Date.AddDays(1).AddSeconds(-1)); // 包含整天
                    }
                    else
                    {
                        throw new ArgumentException("开始日期不能大于结束日期");
                    }
                }

                // 按性别查询
                if (!string.IsNullOrEmpty(student.Ssex))
                {
                    conditions.Add("ssex = @Ssex");
                    parameters.Add("Ssex", student.Ssex);
                }
            }

            if (conditions.Any())
            {
                sqlBuilder.Append(" WHERE ");
                sqlBuilder.Append(string.Join(" AND ", conditions));
            }
            
            using(IDbConnection connection = _connectionFactory.GetConnection())
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
                    // 处理异常，例如记录日志
                    throw new Exception("动态查询学生信息时发生错误", ex);
                }
            }

        }

        public async Task<DataTable> GetAllAsync()
        {
            using (IDbConnection connection = _connectionFactory.GetConnection())
            {
                //查看connection的连接字符
                string sql = "SELECT sid,sname,sage,ssex FROM Student"; 
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
                    // 处理异常，例如记录日志
                    throw new Exception("获取所有学生信息时发生错误", ex);
                }

            }
        }

        public async Task<bool> InsertAsync(Student student)
        {
            using(IDbConnection connection = _connectionFactory.GetConnection())
            {
                string sql = "INSERT INTO Student (sid, sname, sage, ssex) VALUES (@Sid, @Sname, @Sage, @Ssex)";
                try
                {
                    var result = await connection.ExecuteAsync(sql, student);
                    return result > 0; // 返回受影响的行数是否大于0
                }
                catch (Exception ex)
                {
                    // 处理异常，例如记录日志
                    throw new Exception("插入学生信息时发生错误", ex);
                }
            }
        }
        public async Task<bool> InsertAsync(List<Student> students)
        {
            using (IDbConnection connection = _connectionFactory.GetConnection())
            {
                string sql = "INSERT INTO Student (sid, sname, sage, ssex) VALUES (@Sid, @Sname, @Sage, @Ssex)";
                try
                {
                    var result = await connection.ExecuteAsync(sql, students);
                    return result > 0; // 返回受影响的行数是否大于0
                }
                catch (Exception ex)
                {
                    // 处理异常，例如记录日志
                    throw new Exception("批量插入学生信息时发生错误", ex);
                }
            }
        }

        public async Task<bool> SaveChangesAsync(DataTable studentstable)
        {
            // 1. 一次性获取所有发生更改的行
            DataTable changes = studentstable.GetChanges();
            if (changes == null || changes.Rows.Count == 0)
            {
                // 如果没有任何更改，直接返回成功，无需进行数据库操作
                return true;
            }

            using (IDbConnection connection = _connectionFactory.GetConnection())
            {
                // 2. 开启一个事务来包裹所有的数据库操作
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        int totalRowsAffected = 0;

                        // --- 处理删除的行 ---
                        //  changes 这个 DataTable 中筛选，而不是原始的 studentstable
                        var deletedRows = changes.AsEnumerable().Where(r => r.RowState == DataRowState.Deleted).ToList();
                        if (deletedRows.Any())
                        {
                            // 获取删除行的原始ID，注意 DataRowVersion.Original
                            var idsToDelete = deletedRows.Select(r => r["sid", DataRowVersion.Original]).ToList();

                            //先同步删除到分数表
                            string deleteScoresSql = "DELETE FROM SC WHERE Sid IN @Ids";
                            var res= await connection.ExecuteAsync(deleteScoresSql, new { Ids = idsToDelete }, transaction);
                            totalRowsAffected += await connection.ExecuteAsync("DELETE FROM Student WHERE Sid IN @Ids", new { Ids = idsToDelete }, transaction);
                        }


                        // --- 处理修改的行 ---
                        var modifiedRows = changes.AsEnumerable().Where(r => r.RowState == DataRowState.Modified).ToList();
                        if (modifiedRows.Any())
                        {
                            totalRowsAffected += await connection.ExecuteAsync(
                                "UPDATE Student SET Sname = @Sname, Sage = @Sage, Ssex = @Ssex WHERE Sid = @Sid",
                                modifiedRows.Select(r => new Student 
                                {
                                    Sid = r.Field<int>("sid"),
                                    Sname = r.Field<string>("sname"),
                                    Sage = r.Field<DateTime>("sage"),
                                    Ssex = r.Field<string>("ssex")
                                }),
                                transaction
                            );
                        }

                        // --- 处理新增的行 ---
                        var addedRows = changes.AsEnumerable().Where(r => r.RowState == DataRowState.Added).ToList();
                        if (addedRows.Any())
                        {

                            totalRowsAffected += await connection.ExecuteAsync(
                                "INSERT INTO Student (Sid, Sname, Sage, Ssex) VALUES (@Sid, @Sname, @Sage, @Ssex)",
                                addedRows.Select(r => new Student
                                {
                                    Sid = r.Field<int>("sid"),
                                    Sname = r.Field<string>("sname"),
                                    Sage = r.Field<DateTime>("sage"),
                                    Ssex = r.Field<string>("ssex")
                                }),
                                transaction
                            );
                        }

                        // 3. 在所有操作都成功完成后，在 try 块的末尾提交事务
                        transaction.Commit();

                        // 4. 接受内存中 DataTable 的所有更改，使其状态与数据库同步
                        studentstable.AcceptChanges();

                        // 可以根据受影响的行数来决定返回值，或者只要不抛异常就返回true
                        return true;
                    }
                    catch (Exception ex)
                    {
                        // 5. 如果任何一步发生错误，回滚整个事务
                        transaction.Rollback();

                        // 6. 拒绝内存中的更改，使DataTable恢复到保存之前的状态
                        studentstable.RejectChanges();

                        // 记录日志并向上抛出异常，让调用方知道操作失败
                        throw new Exception("保存更改时发生错误，操作已回滚。", ex);
                    }
                } // using 会自动关闭事务
            } // using 会自动关闭连接
        }

        public async Task<bool> UpdateAsync(Student student)
        {
            using (IDbConnection connection = _connectionFactory.GetConnection())
            {
                string sql = "UPDATE Student SET sname = @Sname, sage = @Sage, ssex = @Ssex WHERE sid = @Sid";
                try
                {
                    var result = await connection.ExecuteAsync(sql, student);
                    return result > 0; // 返回受影响的行数是否大于0
                }
                catch (Exception ex)
                {
                    // 处理异常，例如记录日志
                    throw new Exception("更新学生信息时发生错误", ex);
                }
            }
        }

       public async Task<bool> UpdateAsync(List<Student> students)
        {
            using (IDbConnection connection = _connectionFactory.GetConnection())
            {
                string sql = "UPDATE Student SET sname = @Sname, sage = @Sage, ssex = @Ssex WHERE sid = @Sid";
                try
                {
                    var result = await connection.ExecuteAsync(sql, students);
                    return result > 0; // 返回受影响的行数是否大于0
                }
                catch (Exception ex)
                {
                    // 处理异常，例如记录日志
                    throw new Exception("批量更新学生信息时发生错误", ex);
                }
            }
        }
    }
}
