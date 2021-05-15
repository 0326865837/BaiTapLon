
namespace BaiTapLon
{
    partial class FrmScoreManage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvScoreList = new System.Windows.Forms.DataGridView();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScoreOral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScoreSementer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScoreMedium = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowScoreClass = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboMon = new System.Windows.Forms.ComboBox();
            this.btnShowScoreStuId = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoreList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvScoreList
            // 
            this.dgvScoreList.AllowUserToAddRows = false;
            this.dgvScoreList.AllowUserToDeleteRows = false;
            this.dgvScoreList.AllowUserToOrderColumns = true;
            this.dgvScoreList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvScoreList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentId,
            this.SubId,
            this.StudentName,
            this.ClassId,
            this.ClassName,
            this.SubName,
            this.ScoreOral,
            this.ScoreSementer,
            this.ScoreMedium});
            this.dgvScoreList.Location = new System.Drawing.Point(12, 256);
            this.dgvScoreList.Name = "dgvScoreList";
            this.dgvScoreList.ReadOnly = true;
            this.dgvScoreList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvScoreList.Size = new System.Drawing.Size(970, 182);
            this.dgvScoreList.TabIndex = 0;
            this.dgvScoreList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvScoreList_CellDoubleClick);
            // 
            // StudentId
            // 
            this.StudentId.DataPropertyName = "StudentId";
            this.StudentId.HeaderText = "Mã học sinh";
            this.StudentId.Name = "StudentId";
            this.StudentId.ReadOnly = true;
            // 
            // SubId
            // 
            this.SubId.DataPropertyName = "SubId";
            this.SubId.HeaderText = "Mã môn";
            this.SubId.Name = "SubId";
            this.SubId.ReadOnly = true;
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "StudentName";
            this.StudentName.HeaderText = "Họ tên";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            this.StudentName.Width = 130;
            // 
            // ClassId
            // 
            this.ClassId.DataPropertyName = "ClassId";
            this.ClassId.HeaderText = "Mã lớp";
            this.ClassId.Name = "ClassId";
            this.ClassId.ReadOnly = true;
            // 
            // ClassName
            // 
            this.ClassName.DataPropertyName = "ClassName";
            this.ClassName.HeaderText = "Tên lớp";
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            // 
            // SubName
            // 
            this.SubName.DataPropertyName = "SubName";
            this.SubName.HeaderText = "Tên môn";
            this.SubName.Name = "SubName";
            this.SubName.ReadOnly = true;
            // 
            // ScoreOral
            // 
            this.ScoreOral.DataPropertyName = "ScoreOral";
            this.ScoreOral.HeaderText = "Điểm miệng";
            this.ScoreOral.Name = "ScoreOral";
            this.ScoreOral.ReadOnly = true;
            // 
            // ScoreSementer
            // 
            this.ScoreSementer.DataPropertyName = "ScoreSementer";
            this.ScoreSementer.HeaderText = "Điểm học kì";
            this.ScoreSementer.Name = "ScoreSementer";
            this.ScoreSementer.ReadOnly = true;
            // 
            // ScoreMedium
            // 
            this.ScoreMedium.DataPropertyName = "ScoreMedium";
            this.ScoreMedium.HeaderText = "Điểm 1 tiết";
            this.ScoreMedium.Name = "ScoreMedium";
            this.ScoreMedium.ReadOnly = true;
            // 
            // cboClass
            // 
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Location = new System.Drawing.Point(294, 64);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(121, 21);
            this.cboClass.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lớp:";
            // 
            // btnShowScoreClass
            // 
            this.btnShowScoreClass.Location = new System.Drawing.Point(481, 62);
            this.btnShowScoreClass.Name = "btnShowScoreClass";
            this.btnShowScoreClass.Size = new System.Drawing.Size(130, 23);
            this.btnShowScoreClass.TabIndex = 3;
            this.btnShowScoreClass.Text = "Hiển thị theo lớp";
            this.btnShowScoreClass.UseVisualStyleBackColor = true;
            this.btnShowScoreClass.Click += new System.EventHandler(this.btnShowScoreClass_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(481, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Hiển thị theo môn";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnShowScoreSubject_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Môn:";
            // 
            // cboMon
            // 
            this.cboMon.FormattingEnabled = true;
            this.cboMon.Location = new System.Drawing.Point(294, 113);
            this.cboMon.Name = "cboMon";
            this.cboMon.Size = new System.Drawing.Size(121, 21);
            this.cboMon.TabIndex = 4;
            // 
            // btnShowScoreStuId
            // 
            this.btnShowScoreStuId.Location = new System.Drawing.Point(481, 163);
            this.btnShowScoreStuId.Name = "btnShowScoreStuId";
            this.btnShowScoreStuId.Size = new System.Drawing.Size(130, 23);
            this.btnShowScoreStuId.TabIndex = 9;
            this.btnShowScoreStuId.Text = "Hiển thị theo học sinh";
            this.btnShowScoreStuId.UseVisualStyleBackColor = true;
            this.btnShowScoreStuId.Click += new System.EventHandler(this.btnShowScoreStuId_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mã học sinh";
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(294, 165);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(121, 20);
            this.txtStudentId.TabIndex = 10;
            // 
            // FrmScoreManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 450);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.btnShowScoreStuId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboMon);
            this.Controls.Add(this.btnShowScoreClass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboClass);
            this.Controls.Add(this.dgvScoreList);
            this.Name = "FrmScoreManage";
            this.Text = "FrmScoreManage";
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoreList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvScoreList;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowScoreClass;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboMon;
        private System.Windows.Forms.Button btnShowScoreStuId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScoreOral;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScoreSementer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScoreMedium;
    }
}