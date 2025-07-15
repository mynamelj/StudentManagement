using StudentManagement.Core.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Core.Models
{
    /// <summary>
    /// ���������Ϣ��ʵ���࣬��Ӧ���ݿ��е� sc ��
    /// </summary>
    public class Score
    {
        private int _sid;
        private int _cid;
        private int _score;

        /// <summary>
        /// ѧ��ID
        /// </summary>
        [ColumnInfo("ѧ��ID", DisplayIndex = 0, Width = 80)]
        public int Sid
        {
            get { return _sid; }
            set { _sid = value; }
        }

        /// <summary>
        /// �γ�ID
        /// </summary>
        [ColumnInfo("�γ�ID", DisplayIndex = 1, Width = 80)]
        public int Cid
        {
            get { return _cid; }
            set { _cid = value; }
        }

        /// <summary>
        /// ����
        /// </summary>
        [ColumnInfo("����", DisplayIndex = 2, Width = 80)]
        public int ScoreValue
        {
            get { return _score; }
            set { _score = value; }
        }
    }
}