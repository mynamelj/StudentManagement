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
            this.StudentDataGridView = new System.Windows.Forms.DataGridView();
            this.StudentDeleteToolStripMenuItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除选中行DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CourseTabPage = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TeacherTabPage = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TeacherIdlabel = new System.Windows.Forms.Label();
            this.TeacherNamelabel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ScoreTablePage = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.ScoreTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SCStudentIdlabel = new System.Windows.Forms.Label();
            this.SCStudentIdTextBox = new System.Windows.Forms.TextBox();
            this.SCCourseIdlabel = new System.Windows.Forms.Label();
            this.SCCourseComboBox = new System.Windows.Forms.ComboBox();
            this.Scorelabel = new System.Windows.Forms.Label();
            this.MinScoreTextBox = new System.Windows.Forms.TextBox();
            this.MaxScoreTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.ScoreQueryBtn = new System.Windows.Forms.Button();
            this.ScoreSaveBtn = new System.Windows.Forms.Button();
            this.ScoreDataGridView = new System.Windows.Forms.DataGridView();
            this.ScoreDeleteToolStripMenuItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MainTabControl.SuspendLayout();
            this.StudentTabPage.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.StudentTableLayoutPanel.SuspendLayout();
            this.StudentBtnPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGridView)).BeginInit();
            this.StudentDeleteToolStripMenuItem.SuspendLayout();
            this.CourseTabPage.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.TeacherTabPage.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.ScoreTablePage.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.ScoreTableLayoutPanel.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreDataGridView)).BeginInit();
            this.ScoreDeleteToolStripMenuItem.SuspendLayout();
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
            // StudentDataGridView
            // 
            this.StudentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentDataGridView.ContextMenuStrip = this.StudentDeleteToolStripMenuItem;
            this.StudentDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.StudentDataGridView.Location = new System.Drawing.Point(3, 184);
            this.StudentDataGridView.Name = "StudentDataGridView";
            this.StudentDataGridView.RowTemplate.Height = 23;
            this.StudentDataGridView.Size = new System.Drawing.Size(761, 240);
            this.StudentDataGridView.TabIndex = 2;
            // 
            // StudentDeleteToolStripMenuItem
            // 
            this.StudentDeleteToolStripMenuItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除选中行DToolStripMenuItem});
            this.StudentDeleteToolStripMenuItem.Name = "RowContextMenuStrip";
            this.StudentDeleteToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.StudentDeleteToolStripMenuItem.Opening += new System.ComponentModel.CancelEventHandler(this.StudentDeleteToolStripMenuItem_Opening);
            this.StudentDeleteToolStripMenuItem.Click += new System.EventHandler(this.StudentDeleteToolStripMenuItem_Click);
            // 
            // 删除选中行DToolStripMenuItem
            // 
            this.删除选中行DToolStripMenuItem.Name = "删除选中行DToolStripMenuItem";
            this.删除选中行DToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.删除选中行DToolStripMenuItem.Text = "删除选中行(&D)";
            // 
            // CourseTabPage
            // 
            this.CourseTabPage.Controls.Add(this.flowLayoutPanel2);
            this.CourseTabPage.Location = new System.Drawing.Point(4, 22);
            this.CourseTabPage.Name = "CourseTabPage";
            this.CourseTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CourseTabPage.Size = new System.Drawing.Size(773, 433);
            this.CourseTabPage.TabIndex = 1;
            this.CourseTabPage.Text = "课程";
            this.CourseTabPage.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel2.Controls.Add(this.dataGridView1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(767, 427);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.98949F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.1682F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(761, 138);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(3, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(3, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "出生日期";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(3, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "性别";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 12F);
            this.textBox1.Location = new System.Drawing.Point(154, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 26);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("宋体", 12F);
            this.textBox2.Location = new System.Drawing.Point(154, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 26);
            this.textBox2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("宋体", 10F);
            this.dateTimePicker1.Location = new System.Drawing.Point(154, 71);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("宋体", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(154, 105);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.button1);
            this.flowLayoutPanel3.Controls.Add(this.button2);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 147);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(761, 31);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(84, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "保存修改";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.StudentDeleteToolStripMenuItem;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Location = new System.Drawing.Point(3, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(761, 240);
            this.dataGridView1.TabIndex = 2;
            // 
            // TeacherTabPage
            // 
            this.TeacherTabPage.Controls.Add(this.flowLayoutPanel4);
            this.TeacherTabPage.Location = new System.Drawing.Point(4, 22);
            this.TeacherTabPage.Name = "TeacherTabPage";
            this.TeacherTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.TeacherTabPage.Size = new System.Drawing.Size(773, 433);
            this.TeacherTabPage.TabIndex = 2;
            this.TeacherTabPage.Text = "教师";
            this.TeacherTabPage.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.tableLayoutPanel2);
            this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel4.Controls.Add(this.dataGridView2);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(767, 427);
            this.flowLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.98949F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.1682F));
            this.tableLayoutPanel2.Controls.Add(this.TeacherIdlabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.TeacherNamelabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox4, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(761, 138);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // TeacherIdlabel
            // 
            this.TeacherIdlabel.AutoSize = true;
            this.TeacherIdlabel.Font = new System.Drawing.Font("宋体", 12F);
            this.TeacherIdlabel.Location = new System.Drawing.Point(3, 0);
            this.TeacherIdlabel.Name = "TeacherIdlabel";
            this.TeacherIdlabel.Size = new System.Drawing.Size(23, 16);
            this.TeacherIdlabel.TabIndex = 0;
            this.TeacherIdlabel.Text = "ID";
            // 
            // TeacherNamelabel
            // 
            this.TeacherNamelabel.AutoSize = true;
            this.TeacherNamelabel.Font = new System.Drawing.Font("宋体", 12F);
            this.TeacherNamelabel.Location = new System.Drawing.Point(3, 34);
            this.TeacherNamelabel.Name = "TeacherNamelabel";
            this.TeacherNamelabel.Size = new System.Drawing.Size(71, 16);
            this.TeacherNamelabel.TabIndex = 1;
            this.TeacherNamelabel.Text = "教师姓名";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("宋体", 12F);
            this.textBox3.Location = new System.Drawing.Point(154, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 26);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("宋体", 12F);
            this.textBox4.Location = new System.Drawing.Point(154, 37);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(200, 26);
            this.textBox4.TabIndex = 5;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.button3);
            this.flowLayoutPanel5.Controls.Add(this.button4);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 147);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(761, 31);
            this.flowLayoutPanel5.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "查询";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(84, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "保存修改";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ContextMenuStrip = this.StudentDeleteToolStripMenuItem;
            this.dataGridView2.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView2.Location = new System.Drawing.Point(3, 184);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(761, 240);
            this.dataGridView2.TabIndex = 2;
            // 
            // ScoreTablePage
            // 
            this.ScoreTablePage.Controls.Add(this.flowLayoutPanel6);
            this.ScoreTablePage.Location = new System.Drawing.Point(4, 22);
            this.ScoreTablePage.Name = "ScoreTablePage";
            this.ScoreTablePage.Padding = new System.Windows.Forms.Padding(3);
            this.ScoreTablePage.Size = new System.Drawing.Size(773, 433);
            this.ScoreTablePage.TabIndex = 3;
            this.ScoreTablePage.Text = "分数";
            this.ScoreTablePage.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.ScoreTableLayoutPanel);
            this.flowLayoutPanel6.Controls.Add(this.flowLayoutPanel7);
            this.flowLayoutPanel6.Controls.Add(this.ScoreDataGridView);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(767, 427);
            this.flowLayoutPanel6.TabIndex = 1;
            // 
            // ScoreTableLayoutPanel
            // 
            this.ScoreTableLayoutPanel.ColumnCount = 3;
            this.ScoreTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.2431F));
            this.ScoreTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.59527F));
            this.ScoreTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.16163F));
            this.ScoreTableLayoutPanel.Controls.Add(this.SCStudentIdlabel, 0, 0);
            this.ScoreTableLayoutPanel.Controls.Add(this.SCStudentIdTextBox, 1, 0);
            this.ScoreTableLayoutPanel.Controls.Add(this.SCCourseIdlabel, 0, 1);
            this.ScoreTableLayoutPanel.Controls.Add(this.SCCourseComboBox, 1, 1);
            this.ScoreTableLayoutPanel.Controls.Add(this.Scorelabel, 0, 2);
            this.ScoreTableLayoutPanel.Controls.Add(this.MinScoreTextBox, 1, 2);
            this.ScoreTableLayoutPanel.Controls.Add(this.MaxScoreTextBox, 2, 2);
            this.ScoreTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.ScoreTableLayoutPanel.Name = "ScoreTableLayoutPanel";
            this.ScoreTableLayoutPanel.RowCount = 4;
            this.ScoreTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ScoreTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ScoreTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ScoreTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ScoreTableLayoutPanel.Size = new System.Drawing.Size(761, 138);
            this.ScoreTableLayoutPanel.TabIndex = 0;
            // 
            // SCStudentIdlabel
            // 
            this.SCStudentIdlabel.AutoSize = true;
            this.SCStudentIdlabel.Font = new System.Drawing.Font("宋体", 12F);
            this.SCStudentIdlabel.Location = new System.Drawing.Point(3, 0);
            this.SCStudentIdlabel.Name = "SCStudentIdlabel";
            this.SCStudentIdlabel.Size = new System.Drawing.Size(55, 16);
            this.SCStudentIdlabel.TabIndex = 1;
            this.SCStudentIdlabel.Text = "学生ID";
            // 
            // SCStudentIdTextBox
            // 
            this.SCStudentIdTextBox.Font = new System.Drawing.Font("宋体", 12F);
            this.SCStudentIdTextBox.Location = new System.Drawing.Point(118, 3);
            this.SCStudentIdTextBox.Name = "SCStudentIdTextBox";
            this.SCStudentIdTextBox.Size = new System.Drawing.Size(200, 26);
            this.SCStudentIdTextBox.TabIndex = 8;
            // 
            // SCCourseIdlabel
            // 
            this.SCCourseIdlabel.AutoSize = true;
            this.SCCourseIdlabel.Font = new System.Drawing.Font("宋体", 12F);
            this.SCCourseIdlabel.Location = new System.Drawing.Point(3, 34);
            this.SCCourseIdlabel.Name = "SCCourseIdlabel";
            this.SCCourseIdlabel.Size = new System.Drawing.Size(39, 16);
            this.SCCourseIdlabel.TabIndex = 2;
            this.SCCourseIdlabel.Text = "课程";
            // 
            // SCCourseComboBox
            // 
            this.SCCourseComboBox.Font = new System.Drawing.Font("宋体", 12F);
            this.SCCourseComboBox.FormattingEnabled = true;
            this.SCCourseComboBox.Location = new System.Drawing.Point(118, 37);
            this.SCCourseComboBox.Name = "SCCourseComboBox";
            this.SCCourseComboBox.Size = new System.Drawing.Size(200, 24);
            this.SCCourseComboBox.TabIndex = 9;
            // 
            // Scorelabel
            // 
            this.Scorelabel.AutoSize = true;
            this.Scorelabel.Font = new System.Drawing.Font("宋体", 12F);
            this.Scorelabel.Location = new System.Drawing.Point(3, 68);
            this.Scorelabel.Name = "Scorelabel";
            this.Scorelabel.Size = new System.Drawing.Size(39, 16);
            this.Scorelabel.TabIndex = 3;
            this.Scorelabel.Text = "分数";
            // 
            // MinScoreTextBox
            // 
            this.MinScoreTextBox.Font = new System.Drawing.Font("宋体", 12F);
            this.MinScoreTextBox.Location = new System.Drawing.Point(118, 71);
            this.MinScoreTextBox.Name = "MinScoreTextBox";
            this.MinScoreTextBox.Size = new System.Drawing.Size(200, 26);
            this.MinScoreTextBox.TabIndex = 10;
            // 
            // MaxScoreTextBox
            // 
            this.MaxScoreTextBox.Font = new System.Drawing.Font("宋体", 12F);
            this.MaxScoreTextBox.Location = new System.Drawing.Point(328, 71);
            this.MaxScoreTextBox.Name = "MaxScoreTextBox";
            this.MaxScoreTextBox.Size = new System.Drawing.Size(200, 26);
            this.MaxScoreTextBox.TabIndex = 11;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.ScoreQueryBtn);
            this.flowLayoutPanel7.Controls.Add(this.ScoreSaveBtn);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(3, 147);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(761, 31);
            this.flowLayoutPanel7.TabIndex = 1;
            // 
            // ScoreQueryBtn
            // 
            this.ScoreQueryBtn.Location = new System.Drawing.Point(3, 3);
            this.ScoreQueryBtn.Name = "ScoreQueryBtn";
            this.ScoreQueryBtn.Size = new System.Drawing.Size(75, 23);
            this.ScoreQueryBtn.TabIndex = 0;
            this.ScoreQueryBtn.Text = "查询";
            this.ScoreQueryBtn.UseVisualStyleBackColor = true;
            this.ScoreQueryBtn.Click += new System.EventHandler(this.ScoreQueryBtn_Click);
            // 
            // ScoreSaveBtn
            // 
            this.ScoreSaveBtn.Location = new System.Drawing.Point(84, 3);
            this.ScoreSaveBtn.Name = "ScoreSaveBtn";
            this.ScoreSaveBtn.Size = new System.Drawing.Size(75, 23);
            this.ScoreSaveBtn.TabIndex = 1;
            this.ScoreSaveBtn.Text = "保存修改";
            this.ScoreSaveBtn.UseVisualStyleBackColor = true;
            this.ScoreSaveBtn.Click += new System.EventHandler(this.ScoreSaveBtn_Click);
            // 
            // ScoreDataGridView
            // 
            this.ScoreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScoreDataGridView.ContextMenuStrip = this.ScoreDeleteToolStripMenuItem;
            this.ScoreDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.ScoreDataGridView.Location = new System.Drawing.Point(3, 184);
            this.ScoreDataGridView.Name = "ScoreDataGridView";
            this.ScoreDataGridView.RowTemplate.Height = 23;
            this.ScoreDataGridView.Size = new System.Drawing.Size(761, 240);
            this.ScoreDataGridView.TabIndex = 2;
            // 
            // ScoreDeleteToolStripMenuItem
            // 
            this.ScoreDeleteToolStripMenuItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.ScoreDeleteToolStripMenuItem.Name = "RowContextMenuStrip";
            this.ScoreDeleteToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.ScoreDeleteToolStripMenuItem.Opening += new System.ComponentModel.CancelEventHandler(this.ScoreDeleteToolStripMenuItem_Opening);
            this.ScoreDeleteToolStripMenuItem.Click += new System.EventHandler(this.ScoreDeleteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.toolStripMenuItem1.Text = "删除选中行(&D)";
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
            this.StudentDeleteToolStripMenuItem.ResumeLayout(false);
            this.CourseTabPage.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.TeacherTabPage.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ScoreTablePage.ResumeLayout(false);
            this.flowLayoutPanel6.ResumeLayout(false);
            this.ScoreTableLayoutPanel.ResumeLayout(false);
            this.ScoreTableLayoutPanel.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScoreDataGridView)).EndInit();
            this.ScoreDeleteToolStripMenuItem.ResumeLayout(false);
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
        private System.Windows.Forms.DateTimePicker StudentDateTimePickerEnd;
        private System.Windows.Forms.ContextMenuStrip StudentDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除选中行DToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label TeacherIdlabel;
        private System.Windows.Forms.Label TeacherNamelabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel ScoreTableLayoutPanel;
        private System.Windows.Forms.Label SCStudentIdlabel;
        private System.Windows.Forms.Label SCCourseIdlabel;
        private System.Windows.Forms.Label Scorelabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.Button ScoreQueryBtn;
        private System.Windows.Forms.Button ScoreSaveBtn;
        private System.Windows.Forms.DataGridView ScoreDataGridView;
        private System.Windows.Forms.TextBox SCStudentIdTextBox;
        private System.Windows.Forms.ComboBox SCCourseComboBox;
        private System.Windows.Forms.TextBox MinScoreTextBox;
        private System.Windows.Forms.TextBox MaxScoreTextBox;
        private System.Windows.Forms.ContextMenuStrip ScoreDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

