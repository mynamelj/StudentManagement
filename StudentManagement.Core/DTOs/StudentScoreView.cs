using StudentManagement.Core.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Core.DTOs
{
    /// <summary>
    /// 学生成绩视图DTO，用于显示学生成绩相关信息
    /// </summary>
    public class StudentScoreView
    {
        /// <summary>
        /// 学生ID
        /// </summary>
        [ColumnInfo("学生ID", DisplayIndex = 0, Width = 80)]
        public int Sid { get; set; }

        /// <summary>
        /// 学生姓名
        /// </summary>
        [ColumnInfo("学生姓名", DisplayIndex = 1, Width = 120)]
        public string Sname { get; set; }

        /// <summary>
        /// 成绩
        /// </summary>
        [ColumnInfo("成绩", DisplayIndex = 2, Width = 80)]
        public int Score { get; set; }

        /// <summary>
        /// 课程ID
        /// </summary>
        [ColumnInfo("课程ID", DisplayIndex = 3, Width = 80)]
        public int Cid { get; set; }

        /// <summary>
        /// 课程名称
        /// </summary>
        [ColumnInfo("课程名称", DisplayIndex = 4, Width = 150)]
        public string Cname { get; set; }
    }
}
