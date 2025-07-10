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
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.StudentTabPage = new System.Windows.Forms.TabPage();
            this.CourseTabPage = new System.Windows.Forms.TabPage();
            this.TeacherTabPage = new System.Windows.Forms.TabPage();
            this.ScoreTablePage = new System.Windows.Forms.TabPage();
            this.MainTabControl.SuspendLayout();
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
            this.StudentTabPage.Location = new System.Drawing.Point(4, 22);
            this.StudentTabPage.Name = "StudentTabPage";
            this.StudentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.StudentTabPage.Size = new System.Drawing.Size(773, 433);
            this.StudentTabPage.TabIndex = 0;
            this.StudentTabPage.Text = "学生";
            this.StudentTabPage.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.MainTabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MainTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage StudentTabPage;
        private System.Windows.Forms.TabPage CourseTabPage;
        private System.Windows.Forms.TabPage TeacherTabPage;
        private System.Windows.Forms.TabPage ScoreTablePage;
    }
}

