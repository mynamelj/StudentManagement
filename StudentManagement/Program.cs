using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StudentManagementData.Abstractions;
using StudentManagementDataAccess.Implementation;
using StudentManagementServices.Abstractions;
using StudentManagementServices.Implementation;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentManagement
{
    internal static class Program
    {
        // 静态属性，用于在其他地方（如MainWindow的构造函数）获取服务
        public static IServiceCollection Services { get; private set; }
        public static IConfiguration Configuration { get; private set; }

        /// <summary>
        /// 全局可访问的服务提供者
        /// </summary>
        public static IServiceProvider ServiceProvider { get; private set; }
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {


            // 在这里注册服务和依赖
            // 使用 AddTransient，表示每次请求时都创建一个新的实例
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) // 设置基础路径为应用程序运行目录
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true); // 加载 appsettings.json
            Configuration = builder.Build();
            Services = new ServiceCollection();
            Services.AddSingleton(Configuration);
            Services.AddSingleton<IDbConnectionFactory, DbConnectionFactory>();
            Services.AddTransient<IStudentRepository, StudentRepository>();
            Services.AddTransient<IScoreRepository, ScoreRepository>();
            Services.AddTransient<IScoreService, ScoreService>();
            Services.AddTransient<IStudentService, StudentService>();
            //注册课程
            Services.AddTransient<ICourseRepository, CourseRepository>();
            Services.AddTransient<ICourseService, CourseService>();
            Services.AddTransient<Form1>();
            ServiceProvider serviceProvider = Services.BuildServiceProvider();
            var mainForm = serviceProvider.GetService<Form1>();
            // 3. 运行由容器创建的窗体实例
            //ApplicationConfiguration.Initialize();
            Application.Run(mainForm);
        }
    }
}
