
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using StudentManagementData.Abstractions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementDataAccess.Implementation
{
    public class DbConnectionFactory : IDbConnectionFactory
    {

        private readonly string _connectionString;

        // 构造函数注入 IConfiguration 以获取连接字符串
        public DbConnectionFactory(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public IDbConnection GetConnection()
        {
            var connection = new SqlConnection(_connectionString); 
            connection.Open(); // Dapper 通常期望连接是打开的
            return connection;
        }
    }
}
