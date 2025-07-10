using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();

            // 在这里注册服务和依赖
            // 使用 AddTransient，表示每次请求时都创建一个新的实例
          
            services.AddTransient<Form1>();
            ServiceProvider serviceProvider = services.BuildServiceProvider();
            var mainForm = serviceProvider.GetService<Form1>();
            // 3. 运行由容器创建的窗体实例
            //ApplicationConfiguration.Initialize();
            Application.Run(mainForm);
        }
    }
}
