namespace StudentManagement
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.StudentTabPage = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.StudentTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.StudentIdlabel = new System.Windows.Forms.Label();
            this.StudentNamelabel = new System.Windows.Forms.Label();
            this.StudentAgelabel = new System.Windows.Forms.Label();
            this.StudentGenderlabel = new System.Windows.Forms.Label();
            this.StudentIdTextBox = new System.Windows.Forms.TextBox();
            this.StudentNameTextBox = new System.Windows.Forms.TextBox();
            this.StudentDateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.StudentGenderComboBox = new System.Windows.Forms.ComboBox();
            this.StudentDateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.StudentBtnPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.StudentQueryBtn = new System.Windows.Forms.Button();
            this.StudentSaveBtn = new System.Windows.Forms.Button();
            this.StudentDeleteBtn = new System.Windows.Forms.Button();
            this.StudentAddBtn = new System.Windows.Forms.Button();
            this.StudentDataGridView = new System.Windows.Forms.DataGridView();
            this.CourseTabPage = new System.Windows.Forms.TabPage();
            this.TeacherTabPage = new System.Windows.Forms.TabPage();
            this.ScoreTablePage = new System.Windows.Forms.TabPage();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除选中行DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainTabControl.SuspendLayout();
            this.StudentTabPage.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.StudentTableLayoutPanel.SuspendLayout();
            this.StudentBtnPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGridView)).BeginInit();
            this.DeleteToolStripMenuItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.StudentTabPage);
            this.MainTabControl.Controls.Add(this.CourseTabPage);
            this.MainTabControl.Controls.Add(this.TeacherTabPage);
            this.MainTabControl.Controls.Add(this.ScoreTablePage);
            this.MainTabControl.ItemSize = new System.Drawing.Size(120, 18);
            this.MainTabControl.Location = new System.Drawing.Point(1, 1);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(781, 459);
            this.MainTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.MainTabControl.TabIndex = 0;
            // 
            // StudentTabPage
            // 
            this.StudentTabPage.Controls.Add(this.flowLayoutPanel1);
            this.StudentTabPage.Location = new System.Drawing.Point(4, 22);
            this.StudentTabPage.Name = "StudentTabPage";
            this.StudentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.StudentTabPage.Size = new System.Drawing.Size(773, 433);
            this.StudentTabPage.TabIndex = 0;
            this.StudentTabPage.Text = "学生";
            this.StudentTabPage.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.StudentTableLayoutPanel);
            this.flowLayoutPanel1.Controls.Add(this.StudentBtnPanel);
            this.flowLayoutPanel1.Controls.Add(this.StudentDataGridView);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(767, 427);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // StudentTableLayoutPanel
            // 
            this.StudentTableLayoutPanel.ColumnCount = 3;
            this.StudentTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.StudentTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.98949F));
            this.StudentTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.1682F));
            this.StudentTableLayoutPanel.Controls.Add(this.StudentIdlabel, 0, 0);
            this.StudentTableLayoutPanel.Controls.Add(this.StudentNamelabel, 0, 1);
            this.StudentTableLayoutPanel.Controls.Add(this.StudentAgelabel, 0, 2);
            this.StudentTableLayoutPanel.Controls.Add(this.StudentGenderlabel, 0, 3);
            this.StudentTableLayoutPanel.Controls.Add(this.StudentIdTextBox, 1, 0);
            this.StudentTableLayoutPanel.Controls.Add(this.StudentNameTextBox, 1, 1);
            this.StudentTableLayoutPanel.Controls.Add(this.StudentDateTimePickerStart, 1, 2);
            this.StudentTableLayoutPanel.Controls.Add(this.StudentGenderComboBox, 1, 3);
            this.StudentTableLayoutPanel.Controls.Add(this.StudentDateTimePickerEnd, 2, 2);
            this.StudentTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.StudentTableLayoutPanel.Name = "StudentTableLayoutPanel";
            this.StudentTableLayoutPanel.RowCount = 4;
            this.StudentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.StudentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.StudentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.StudentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.StudentTableLayoutPanel.Size = new System.Drawing.Size(761, 138);
            this.StudentTableLayoutPanel.TabIndex = 0;
            // 
            // StudentIdlabel
            // 
            this.StudentIdlabel.AutoSize = true;
            this.StudentIdlabel.Font = new System.Drawing.Font("宋体", 12F);
            this.StudentIdlabel.Location = new System.Drawing.Point(3, 0);
            this.StudentIdlabel.Name = "StudentIdlabel";
            this.StudentIdlabel.Size = new System.Drawing.Size(23, 16);
            this.StudentIdlabel.TabIndex = 0;
            this.StudentIdlabel.Text = "ID";
            // 
            // StudentNamelabel
            // 
            this.StudentNamelabel.AutoSize = true;
            this.StudentNamelabel.Font = new System.Drawing.Font("宋体", 12F);
            this.StudentNamelabel.Location = new System.Drawing.Point(3, 34);
            this.StudentNamelabel.Name = "StudentNamelabel";
            this.StudentNamelabel.Size = new System.Drawing.Size(39, 16);
            this.StudentNamelabel.TabIndex = 1;
            this.StudentNamelabel.Text = "姓名";
            // 
            // StudentAgelabel
            // 
            this.StudentAgelabel.AutoSize = true;
            this.StudentAgelabel.Font = new System.Drawing.Font("宋体", 12F);
            this.StudentAgelabel.Location = new System.Drawing.Point(3, 68);
            this.StudentAgelabel.Name = "StudentAgelabel";
            this.StudentAgelabel.Size = new System.Drawing.Size(71, 16);
            this.StudentAgelabel.TabIndex = 2;
            this.StudentAgelabel.Text = "出生日期";
            // 
            // StudentGenderlabel
            // 
            this.StudentGenderlabel.AutoSize = true;
            this.StudentGenderlabel.Font = new System.Drawing.Font("宋体", 12F);
            this.StudentGenderlabel.Location = new System.Drawing.Point(3, 102);
            this.StudentGenderlabel.Name = "StudentGenderlabel";
            this.StudentGenderlabel.Size = new System.Drawing.Size(39, 16);
            this.StudentGenderlabel.TabIndex = 3;
            this.StudentGenderlabel.Text = "性别";
            // 
            // StudentIdTextBox
            // 
            this.StudentIdTextBox.Font = new System.Drawing.Font("宋体", 12F);
            this.StudentIdTextBox.Location = new System.Drawing.Point(154, 3);
            this.StudentIdTextBox.Name = "StudentIdTextBox";
            this.StudentIdTextBox.Size = new System.Drawing.Size(200, 26);
            this.StudentIdTextBox.TabIndex = 4;
            // 
            // StudentNameTextBox
            // 
            this.StudentNameTextBox.Font = new System.Drawing.Font("宋体", 12F);
            this.StudentNameTextBox.Location = new System.Drawing.Point(154, 37);
            this.StudentNameTextBox.Name = "StudentNameTextBox";
            this.StudentNameTextBox.Size = new System.Drawing.Size(200, 26);
            this.StudentNameTextBox.TabIndex = 5;
            // 
            // StudentDateTimePickerStart
            // 
            this.StudentDateTimePickerStart.Font = new System.Drawing.Font("宋体", 10F);
            this.StudentDateTimePickerStart.Location = new System.Drawing.Point(154, 71);
            this.StudentDateTimePickerStart.Name = "StudentDateTimePickerStart";
            this.StudentDateTimePickerStart.Size = new System.Drawing.Size(200, 23);
            this.StudentDateTimePickerStart.TabIndex = 6;
            // 
            // StudentGenderComboBox
            // 
            this.StudentGenderComboBox.Font = new System.Drawing.Font("宋体", 12F);
            this.StudentGenderComboBox.FormattingEnabled = true;
            this.StudentGenderComboBox.Location = new System.Drawing.Point(154, 105);
            this.StudentGenderComboBox.Name = "StudentGenderComboBox";
            this.StudentGenderComboBox.Size = new System.Drawing.Size(200, 24);
            this.StudentGenderComboBox.TabIndex = 7;
            // 
            // StudentDateTimePickerEnd
            // 
            this.StudentDateTimePickerEnd.Font = new System.Drawing.Font("宋体", 10F);
            this.StudentDateTimePickerEnd.Location = new System.Drawing.Point(366, 71);
            this.StudentDateTimePickerEnd.Name = "StudentDateTimePickerEnd";
            this.StudentDateTimePickerEnd.Size = new System.Drawing.Size(210, 23);
            this.StudentDateTimePickerEnd.TabIndex = 8;
            // 
            // StudentBtnPanel
            // 
            this.StudentBtnPanel.Controls.Add(this.StudentQueryBtn);
            this.StudentBtnPanel.Controls.Add(this.StudentSaveBtn);
            this.StudentBtnPanel.Controls.Add(this.StudentDeleteBtn);
            this.StudentBtnPanel.Controls.Add(this.StudentAddBtn);
            this.StudentBtnPanel.Location = new System.Drawing.Point(3, 147);
            this.StudentBtnPanel.Name = "StudentBtnPanel";
            this.StudentBtnPanel.Size = new System.Drawing.Size(761, 31);
            this.StudentBtnPanel.TabIndex = 1;
            // 
            // StudentQueryBtn
            // 
            this.StudentQueryBtn.Location = new System.Drawing.Point(3, 3);
            this.StudentQueryBtn.Name = "StudentQueryBtn";
            this.StudentQueryBtn.Size = new System.Drawing.Size(75, 23);
            this.StudentQueryBtn.TabIndex = 0;
            this.StudentQueryBtn.Text = "查询";
            this.StudentQueryBtn.UseVisualStyleBackColor = true;
            this.StudentQueryBtn.Click += new System.EventHandler(this.StudentQueryBtn_Click);
            // 
            // StudentSaveBtn
            // 
            this.StudentSaveBtn.Location = new System.Drawing.Point(84, 3);
            this.StudentSaveBtn.Name = "StudentSaveBtn";
            this.StudentSaveBtn.Size = new System.Drawing.Size(75, 23);
            this.StudentSaveBtn.TabIndex = 1;
            this.StudentSaveBtn.Text = "保存修改";
            this.StudentSaveBtn.UseVisualStyleBackColor = true;
            this.StudentSaveBtn.Click += new System.EventHandler(this.StudentSaveBtn_Click);
            // 
            // StudentDeleteBtn
            // 
            this.StudentDeleteBtn.Location = new System.Drawing.Point(165, 3);
            this.StudentDeleteBtn.Name = "StudentDeleteBtn";
            this.StudentDeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.StudentDeleteBtn.TabIndex = 2;
            this.StudentDeleteBtn.Text = "删除选中";
            this.StudentDeleteBtn.UseVisualStyleBackColor = true;
            // 
            // StudentAddBtn
            // 
            this.StudentAddBtn.Location = new System.Drawing.Point(246, 3);
            this.StudentAddBtn.Name = "StudentAddBtn";
            this.StudentAddBtn.Size = new System.Drawing.Size(75, 23);
            this.StudentAddBtn.TabIndex = 3;
            this.StudentAddBtn.Text = "保存新增";
            this.StudentAddBtn.UseVisualStyleBackColor = true;
            this.StudentAddBtn.Click += new System.EventHandler(this.StudentAddBtn_Click);
            // 
            // StudentDataGridView
            // 
            this.StudentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentDataGridView.ContextMenuStrip = this.DeleteToolStripMenuItem;
            this.StudentDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.StudentDataGridView.Location = new System.Drawing.Point(3, 184);
            this.StudentDataGridView.Name = "StudentDataGridView";
            this.StudentDataGridView.RowTemplate.Height = 23;
            this.StudentDataGridView.Size = new System.Drawing.Size(761, 240);
            this.StudentDataGridView.TabIndex = 2;
            // 
            // CourseTabPage
            // 
            this.CourseTabPage.Location = new System.Drawing.Point(4, 22);
            this.CourseTabPage.Name = "CourseTabPage";
            this.CourseTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CourseTabPage.Size = new System.Drawing.Size(773, 433);
            this.CourseTabPage.TabIndex = 1;
            this.CourseTabPage.Text = "课程";
            this.CourseTabPage.UseVisualStyleBackColor = true;
            // 
            // TeacherTabPage
            // 
            this.TeacherTabPage.Location = new System.Drawing.Point(4, 22);
            this.TeacherTabPage.Name = "TeacherTabPage";
            this.TeacherTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.TeacherTabPage.Size = new System.Drawing.Size(773, 433);
            this.TeacherTabPage.TabIndex = 2;
            this.TeacherTabPage.Text = "教师";
            this.TeacherTabPage.UseVisualStyleBackColor = true;
            // 
            // ScoreTablePage
            // 
            this.ScoreTablePage.Location = new System.Drawing.Point(4, 22);
            this.ScoreTablePage.Name = "ScoreTablePage";
            this.ScoreTablePage.Padding = new System.Windows.Forms.Padding(3);
            this.ScoreTablePage.Size = new System.Drawing.Size(773, 433);
            this.ScoreTablePage.TabIndex = 3;
            this.ScoreTablePage.Text = "分数";
            this.ScoreTablePage.UseVisualStyleBackColor = true;
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除选中行DToolStripMenuItem});
            this.DeleteToolStripMenuItem.Name = "RowContextMenuStrip";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(181, 48);
            this.DeleteToolStripMenuItem.Opening += new System.ComponentModel.CancelEventHandler(this.DeleteToolStripMenuItem_Opening);
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // 删除选中行DToolStripMenuItem
            // 
            this.删除选中行DToolStripMenuItem.Name = "删除选中行DToolStripMenuItem";
            this.删除选中行DToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.删除选中行DToolStripMenuItem.Text = "删除选中行(&D)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.MainTabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MainTabControl.ResumeLayout(false);
            this.StudentTabPage.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.StudentTableLayoutPanel.ResumeLayout(false);
            this.StudentTableLayoutPanel.PerformLayout();
            this.StudentBtnPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGridView)).EndInit();
            this.DeleteToolStripMenuItem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage StudentTabPage;
        private System.Windows.Forms.TabPage CourseTabPage;
        private System.Windows.Forms.TabPage TeacherTabPage;
        private System.Windows.Forms.TabPage ScoreTablePage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel StudentTableLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel StudentBtnPanel;
        private System.Windows.Forms.DataGridView StudentDataGridView;
        private System.Windows.Forms.Label StudentIdlabel;
        private System.Windows.Forms.Label StudentNamelabel;
        private System.Windows.Forms.Label StudentAgelabel;
        private System.Windows.Forms.Label StudentGenderlabel;
        private System.Windows.Forms.TextBox StudentIdTextBox;
        private System.Windows.Forms.TextBox StudentNameTextBox;
        private System.Windows.Forms.DateTimePicker StudentDateTimePickerStart;
        private System.Windows.Forms.ComboBox StudentGenderComboBox;
        private System.Windows.Forms.Button StudentQueryBtn;
        private System.Windows.Forms.Button StudentSaveBtn;
        private System.Windows.Forms.Button StudentDeleteBtn;
        private System.Windows.Forms.Button StudentAddBtn;
        private System.Windows.Forms.DateTimePicker StudentDateTimePickerEnd;
        private System.Windows.Forms.ContextMenuStrip DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除选中行DToolStripMenuItem;
    }
}

