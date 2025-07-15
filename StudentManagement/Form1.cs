using StudentManagement.Core.Models;
using StudentManagement.Core.Utils;
using StudentManagementData.Abstractions;
using StudentManagementServices.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class Form1 : Form
    {

        private readonly IStudentService studentService;
        private readonly IScoreService scoreService;
        private readonly ICourseService courseService;
        private DataTable studentstable;
        private DataTable scoretable;
        // 通过构造函数注入 IStudentService
        public  Form1(IStudentService studentService, 
                      IScoreService scoreService,
                      ICourseService courseService)
        {
            InitializeComponent();
            this.studentService = studentService;
            this.scoreService = scoreService;
            this.courseService = courseService;

            // 初始化日期控件的默认值 (1995-2010年间隔)
            InitializeDateControls();
            
            // 添加Load事件处理器
            this.Load += Form1_Load;
        }

        /// <summary>
        /// 窗体加载事件处理器
        /// </summary>
        private async  void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // 窗体加载时自动查询所有学生信息
                QueryAllStudents();
                //读取课程
                var courses = await courseService.GetAllCourseNameAsync();
                courses.Add(""); // 添加空选项
          
                SCCourseComboBox.Items.Clear();
                SCCourseComboBox.Items.AddRange(courses.ToArray());
                SCCourseComboBox.SelectedIndex = 0; // 默认选择空选项

            }
            catch (Exception ex)
            {
                MessageBox.Show($"加载课程信息时发生错误: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 初始化所有标签页中的日期控件默认值和其他控件
        /// </summary>
        private void InitializeDateControls()
        {
            // 学生标签页的日期控件
            StudentDateTimePickerStart.Value = new DateTime(1995, 1, 1);
            StudentDateTimePickerEnd.Value = new DateTime(2010, 12, 31);
            
            // 初始化性别下拉框
            StudentGenderComboBox.Items.Clear();
            StudentGenderComboBox.Items.Add("");  // 空选项，表示不筛选
            StudentGenderComboBox.Items.Add("男");
            StudentGenderComboBox.Items.Add("女");
            StudentGenderComboBox.SelectedIndex = 0; // 默认选择空选项
            //
            SCCourseComboBox.Items.Clear();


        }

        #region Student业务
        private async void StudentQueryBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // 创建查询条件的学生对象
                var queryStudent = new Student();

                // 设置ID查询条件（如果有输入）
                if (!string.IsNullOrWhiteSpace(StudentIdTextBox.Text) && int.TryParse(StudentIdTextBox.Text, out int studentId))
                {
                    queryStudent.Sid = studentId;
                }

                // 设置姓名查询条件（如果有输入）
                if (!string.IsNullOrWhiteSpace(StudentNameTextBox.Text))
                {
                    queryStudent.Sname = StudentNameTextBox.Text.Trim();
                }

                // 设置性别查询条件（如果有选择）
                if (StudentGenderComboBox.SelectedItem != null && !string.IsNullOrWhiteSpace(StudentGenderComboBox.SelectedItem.ToString()))
                {
                    queryStudent.Ssex = StudentGenderComboBox.SelectedItem.ToString();
                }

                // 获取日期范围
                DateTime startDate = StudentDateTimePickerStart.Value.Date;
                DateTime endDate = StudentDateTimePickerEnd.Value.Date;

                // 调用动态查询方法
                studentstable = await studentService.DynamicQueryAsync(queryStudent, startDate, endDate);

                // 将结果绑定到 DataGridView
                StudentDataGridView.DataSource = studentstable;

                // 显示查询结果数量
                MessageBox.Show($"查询完成，共找到 {studentstable.Rows.Count} 条记录。", "查询结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // 异常处理，例如显示错误消息
                MessageBox.Show($"查询学生信息时发生错误: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private async void StudentSaveBtn_Click(object sender, EventArgs e)
        {

            try
            {
                this.Validate();
                this.BindingContext[studentstable].EndCurrentEdit();
                // 获取所有更改的行
                DataTable changedRowsTable = studentstable.GetChanges();
                if (changedRowsTable == null || changedRowsTable.Rows.Count == 0)
                {
                    MessageBox.Show("没有需要保存的更改。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                // 将更改保存到数据库
                var result = await studentService.SaveChangesAsync(studentstable);
                if (result)
                {
                    MessageBox.Show("学生信息已成功保存。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("保存学生信息失败，请稍后重试。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"保存学生信息时发生错误: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void StudentDeleteToolStripMenuItem_Opening(object sender, CancelEventArgs e)
        {
            if (StudentDataGridView.SelectedRows.Count > 0)
            {
                // 如果有，启用“删除”菜单项
                StudentDeleteToolStripMenuItem.Enabled = true;
                // (可选) 动态更新文本，显示选中了多少行
                StudentDeleteToolStripMenuItem.Text = $"删除选中的 {StudentDataGridView.SelectedRows.Count} 行(&D)";
            }
            else
            {
                // 如果没有选中任何行，禁用“删除”菜单项
                StudentDeleteToolStripMenuItem.Enabled = false;
                StudentDeleteToolStripMenuItem.Text = "删除选中行(&D)";
            }
        }

        private void StudentDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Validate();
            this.BindingContext[studentstable].EndCurrentEdit();
            //提示窗口，是否确认删除选中的学生信息
            var confirmResult = MessageBox.Show("您确定要删除选中的学生信息吗？", "确认删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult != DialogResult.Yes)
            {
                return; // 如果用户选择了“否”，则退出方法
            }

            //获取选中的行
            var selectedRows = StudentDataGridView.SelectedRows;
            //先暂存选中的数据，将选中的行的数据从 DataTable 中删除，
            List<Student> deletedStudents = new List<Student>();
            deletedStudents = selectedRows.Cast<DataGridViewRow>()
                .Select(row => new Student
                {
                    Sid = Convert.ToInt32(row.Cells["sid"].Value),
                    Sname = row.Cells["sname"].Value.ToString(),
                    Sage = Convert.ToDateTime(row.Cells["sage"].Value),
                    Ssex = row.Cells["ssex"].Value.ToString()
                }).ToList();
            // datatable删除选中的行
            foreach (DataGridViewRow row in selectedRows)
            {
                if (!row.IsNewRow) // 确保不是新行
                {
                    StudentDataGridView.Rows.Remove(row);
                }
            }
        }

        private async void QueryAllStudents()
        {
            try
            {
                // 调用仓库方法获取所有学生信息
                studentstable = await studentService.GetAllStudentsAsync();
                // 将结果绑定到 DataGridView
                StudentDataGridView.DataSource = studentstable;
            }
            catch (Exception ex)
            {
                // 异常处理，例如显示错误消息
                MessageBox.Show($"查询学生信息时发生错误: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion









        #region 事件

        #endregion


        private void ClearQueryConditions()
        {
            StudentIdTextBox.Text = "";
            StudentNameTextBox.Text = "";
            StudentGenderComboBox.SelectedIndex = 0; // 选择空选项
            StudentDateTimePickerStart.Value = new DateTime(1995, 1, 1);
            StudentDateTimePickerEnd.Value = new DateTime(2010, 12, 31);
        }

        private async  void ScoreQueryBtn_Click(object sender, EventArgs e)
        {
            int id = int.TryParse(SCStudentIdTextBox.Text, out int sid) ? sid : 0;
            string cname = SCCourseComboBox.SelectedItem.ToString();
            int minScore = int.TryParse(MinScoreTextBox.Text, out int min) ? min : 0;
            int maxScore = int.TryParse(MaxScoreTextBox.Text, out int max) ? max : 100;
            try
            {
                // 调用 ScoreService 的动态查询方法
                scoretable = await scoreService.DynamicQueryAsync(id, cname, minScore, maxScore);
                // 将结果绑定到 DataGridView
                ScoreDataGridView.DataSource = scoretable;
                // 显示查询结果数量
                MessageBox.Show($"查询完成，共找到 {scoretable.Rows.Count} 条记录。", "查询结果", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"查询分数信息时发生错误: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ScoreDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.BindingContext[scoretable].EndCurrentEdit(); // Change to 'scoretable'
            //提示窗口，是否确认删除选中的分数信息
            var confirmResult = MessageBox.Show("您确定要删除选中的分数信息吗？", "确认删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult != DialogResult.Yes)
            {
                return; // 如果用户选择了“否”，则退出方法
            }
            //获取选中的行
            var selectedRows = ScoreDataGridView.SelectedRows;
            //先暂存选中的数据，将选中的行的数据从 DataTable 中删除，
            List<Score> deletedScores = new List<Score>();
            deletedScores = selectedRows.Cast<DataGridViewRow>()
                .Select(row => new Score
                {
                    Sid = Convert.ToInt32(row.Cells["sid"].Value),
                    Cid = Convert.ToInt32(row.Cells["cid"].Value),
                    ScoreValue = Convert.ToInt32(row.Cells["score"].Value)
                }).ToList();
            // datatable删除选中的行
            foreach (DataGridViewRow row in selectedRows)
            {
                if (!row.IsNewRow) // 确保不是新行
                {
                    ScoreDataGridView.Rows.Remove(row);
                }
            }

        }

        private void ScoreDeleteToolStripMenuItem_Opening(object sender, CancelEventArgs e)
        {
            {
                if (ScoreDataGridView.SelectedRows.Count > 0)
                {
                    // 如果有，启用“删除”菜单项
                    ScoreDeleteToolStripMenuItem.Enabled = true;
                    // (可选) 动态更新文本，显示选中了多少行
                    ScoreDeleteToolStripMenuItem.Text = $"删除选中的 {ScoreDataGridView.SelectedRows.Count} 行(&D)";
                }
                else
                {
                    // 如果没有选中任何行，禁用“删除”菜单项
                    ScoreDeleteToolStripMenuItem.Enabled = false;
                    ScoreDeleteToolStripMenuItem.Text = "删除选中行(&D)";
                }
            }

        }

        private  async void ScoreSaveBtn_Click(object sender, EventArgs e)
        {

            try
            {
                this.Validate();
                this.BindingContext[scoretable].EndCurrentEdit(); // Change to 'scoretable'
                // 获取所有更改的行
                DataTable changedRowsTable = scoretable.GetChanges();
                if (changedRowsTable == null || changedRowsTable.Rows.Count == 0)
                {
                    MessageBox.Show("没有需要保存的更改。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                // 将更改保存到数据库
                var result = await scoreService.SaveChangesAsync(scoretable);
                if (result)
                {
                    MessageBox.Show("分数信息已成功保存。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("保存分数信息失败，请稍后重试。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"保存分数信息时发生错误: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
