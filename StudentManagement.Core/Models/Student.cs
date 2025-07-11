using StudentManagement.Core.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Core.Models
{
    /// <summary>
    /// 代表学生信息的实体类，对应数据库中的 student 表
    /// </summary>
    public class Student 
    {
        private int _sid;
        private string _sname;
        private DateTime? _sage;
        private string _ssex;

        // 学生ID
         [ColumnInfo("ID", DisplayIndex = 0, Width = 150)]
        public int Sid
        {
            get { return _sid; }
            set { _sid = value; }
        }

        /// 学生姓名
       [ColumnInfo("姓名", DisplayIndex = 0, Width = 150)]
        public string Sname
        {
            get { return _sname; }
            set { _sname = value; }
        }

        /// 学生年龄
        [ColumnInfo("出生日期", DisplayIndex = 0, Width = 150)]
        public DateTime? Sage
        {
            get { return _sage; }
            set { _sage = value; }
        }

        /// 学生性别
       [ColumnInfo("性别", DisplayIndex = 0, Width = 150)]
        public string Ssex
        {
            get { return _ssex; }
            set { _ssex = value; }
        }

    }
}