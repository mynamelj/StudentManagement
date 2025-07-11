using StudentManagement.Core.Models;
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
        private DataTable studentstable;
        // 通过构造函数注入 IStudentService
        public  Form1(IStudentService studentService)
        {
            InitializeComponent();
            this.studentService = studentService;
        }


        private async void StudentQueryBtn_Click(object sender, EventArgs e)
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

        private void StudentDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            MessageBox.Show("删除" );
        }

        private void StudentDataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {

        }

        private async void StudentAddBtn_Click(object sender, EventArgs e)
        {
            StudentAddBtn.Enabled = false;
            this.Validate();
            this.BindingContext[studentstable].EndCurrentEdit();
            DataTable newRowsTable = studentstable.GetChanges(DataRowState.Added);
            if (newRowsTable == null || newRowsTable.Rows.Count == 0)
            {
                MessageBox.Show("没有需要保存的新数据。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                StudentAddBtn.Enabled = true;
                return;
            }

            List<Student> newStudents = null; // 声明 newStudents 变量
            try
            {
                newStudents = newRowsTable.AsEnumerable().Select(row => // 添加index用于错误提示
                {
                    return new Student
                    {
                        Sid = row.Field<int>("sid"),
                        Sname = row.Field<string>("sname"),
                        Sage = row.Field<DateTime>("sage"),
                        Ssex = row.Field<string>("ssex")
                    };
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "数据验证失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                StudentAddBtn.Enabled = true;
                return; // 添加 return 以防止在验证失败时继续执行
            }

            try
            {
                var result = await studentService.InsertStudentAsync(newStudents);
                if (result)
                {
                    MessageBox.Show("新学生信息已成功添加。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    StudentQueryBtn_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("添加新学生信息失败，请稍后重试。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"添加新学生信息时发生错误: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        #region 事件

        #endregion

        private void DeleteToolStripMenuItem_Opening(object sender, CancelEventArgs e)
        {
            if (StudentDataGridView.SelectedRows.Count > 0)
            {
                // 如果有，启用“删除”菜单项
                DeleteToolStripMenuItem.Enabled = true;
                // (可选) 动态更新文本，显示选中了多少行
                DeleteToolStripMenuItem.Text = $"删除选中的 {StudentDataGridView.SelectedRows.Count} 行(&D)";
            }
            else
            {
                // 如果没有选中任何行，禁用“删除”菜单项
                DeleteToolStripMenuItem.Enabled = false;
                DeleteToolStripMenuItem.Text = "删除选中行(&D)";
            }
        }

        private  void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
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
            deletedStudents= selectedRows.Cast<DataGridViewRow>()
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
    }
}
