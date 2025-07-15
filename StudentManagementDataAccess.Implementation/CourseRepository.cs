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
    public class CourseRepository : ICourseRepository
    {
        private readonly IDbConnectionFactory _connectionFactory;
        public CourseRepository(IDbConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory ?? throw new ArgumentNullException(nameof(connectionFactory));
        }
        public Task<DataTable> DynamicQueryAsync(int? courseId, string courseName)
        {
            throw new NotImplementedException();
        }

        public async Task<List<string>> GetAllCourseNameAsync()
        {
            using (var connection = _connectionFactory.GetConnection())
            {
                string sql = "SELECT DISTINCT Cname FROM Course";
                try
                {
                    var courseNames = (await connection.QueryAsync<string>(sql)).ToList();
                    return courseNames;
                }
                catch (Exception ex)
                {
                    // 处理异常
                    throw new Exception("获取课程名称失败", ex);
                }

            }
        }

        public Task<DataTable> GetAllCoursesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveChangesAsync(DataTable courseTable)
        {
            throw new NotImplementedException();
        }
    }
}
