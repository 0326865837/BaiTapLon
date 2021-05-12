
namespace BaiTapLon
{
    partial class FrmStudentManage
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.btntimclass = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btntimid = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.dgvStudentList = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btntimclass);
            this.groupBox1.Controls.Add(this.cboClass);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[Tìm theo lớp]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lớp";
            // 
            // cboClass
            // 
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Location = new System.Drawing.Point(42, 21);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(121, 21);
            this.cboClass.TabIndex = 2;
            // 
            // btntimclass
            // 
            this.btntimclass.Location = new System.Drawing.Point(285, 24);
            this.btntimclass.Name = "btntimclass";
            this.btntimclass.Size = new System.Drawing.Size(75, 23);
            this.btntimclass.TabIndex = 3;
            this.btntimclass.Text = "Tìm";
            this.btntimclass.UseVisualStyleBackColor = true;
            this.btntimclass.Click += new System.EventHandler(this.btntimclass_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btntimid);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtStudentId);
            this.groupBox2.Location = new System.Drawing.Point(23, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 72);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "[Tìm theo mã học sinh]";
            // 
            // btntimid
            // 
            this.btntimid.Location = new System.Drawing.Point(285, 24);
            this.btntimid.Name = "btntimid";
            this.btntimid.Size = new System.Drawing.Size(75, 23);
            this.btntimid.TabIndex = 3;
            this.btntimid.Text = "Tìm";
            this.btntimid.UseVisualStyleBackColor = true;
            this.btntimid.Click += new System.EventHandler(this.btntimid_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã học sinh:";
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(85, 26);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(100, 20);
            this.txtStudentId.TabIndex = 0;
            // 
            // dgvStudentList
            // 
            this.dgvStudentList.AllowUserToAddRows = false;
            this.dgvStudentList.AllowUserToDeleteRows = false;
            this.dgvStudentList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvStudentList.ColumnHeadersHeight = 30;
            this.dgvStudentList.Location = new System.Drawing.Point(23, 262);
            this.dgvStudentList.Name = "dgvStudentList";
            this.dgvStudentList.ReadOnly = true;
            this.dgvStudentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudentList.Size = new System.Drawing.Size(763, 263);
            this.dgvStudentList.TabIndex = 5;
            // 
            // FrmStudentManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.Controls.Add(this.dgvStudentList);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmStudentManage";
            this.Text = "FrmStudentManage";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btntimclass;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btntimid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.DataGridView dgvStudentList;
    }
}