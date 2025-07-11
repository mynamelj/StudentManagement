using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Core.Utils
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class ColumnInfoAttribute : Attribute
    {
        /// <summary>
        /// 在 DataGridView 中显示的列头文本
        /// </summary>
        public string HeaderText { get; set; }

        /// <summary>
        /// 列的显示顺序
        /// </summary>
        public int DisplayIndex { get; set; } = -1;

        /// <summary>
        /// 列是否可见
        /// </summary>
        public bool Visible { get; set; } = true;

        /// <summary>
        /// 列的宽度
        /// </summary>
        public int Width { get; set; } = 0; // 0 表示自动

        public ColumnInfoAttribute(string headerText)
        {
            HeaderText = headerText;
        }
    }
}
