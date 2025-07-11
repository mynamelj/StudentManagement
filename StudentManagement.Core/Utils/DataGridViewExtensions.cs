using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StudentManagement.Core.Utils
{
    public static class DataGridViewExtensions
    {
        // ... 保留之前的 ApplyStudentColumnStyles 方法 ...

        /// <summary>
        /// 【通用方法】根据模型类的特性自动配置 DataGridView
        /// </summary>
        /// <typeparam name="T">模型的类型 (例如: Student)</typeparam>
        /// <param name="dgv">要配置的 DataGridView 控件</param>
        public static void ApplyStylesFromModelAttributes<T>(this DataGridView dgv) where T : class
        {
            if (dgv.Columns.Count == 0) return;

            // 获取模型 T 的所有属性
            var properties = typeof(T).GetProperties();

            foreach (var prop in properties)
            {
                // 获取属性上的 ColumnInfoAttribute 特性
                var attr = prop.GetCustomAttribute<ColumnInfoAttribute>();
                if (attr == null) continue;

                // 检查DataGridView中是否存在与属性名匹配的列
                if (dgv.Columns[prop.Name] != null)
                {
                    var column = dgv.Columns[prop.Name];

                    // 应用特性中定义的样式
                    column.HeaderText = attr.HeaderText;
                    column.Visible = attr.Visible;

                    if (attr.DisplayIndex > -1)
                    {
                        column.DisplayIndex = attr.DisplayIndex;
                    }
                    if (attr.Width > 0)
                    {
                        column.Width = attr.Width;
                    }
                }
            }
        }
    }
}
