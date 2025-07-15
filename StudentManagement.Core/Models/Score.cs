using StudentManagement.Core.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Core.Models
{
    /// <summary>
    /// 代表分数信息的实体类，对应数据库中的 sc 表
    /// </summary>
    public class Score
    {
        private int _sid;
        private int _cid;
        private int _score;

        /// <summary>
        /// 学生ID
        /// </summary>
        [ColumnInfo("学生ID", DisplayIndex = 0, Width = 80)]
        public int Sid
        {
            get { return _sid; }
            set { _sid = value; }
        }

        /// <summary>
        /// 课程ID
        /// </summary>
        [ColumnInfo("课程ID", DisplayIndex = 1, Width = 80)]
        public int Cid
        {
            get { return _cid; }
            set { _cid = value; }
        }

        /// <summary>
        /// 分数
        /// </summary>
        [ColumnInfo("分数", DisplayIndex = 2, Width = 80)]
        public int ScoreValue
        {
            get { return _score; }
            set { _score = value; }
        }
    }
}