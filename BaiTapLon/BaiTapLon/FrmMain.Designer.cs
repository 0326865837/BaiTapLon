
namespace BaiTapLon
{
    partial class FrmMain
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnStudentManage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 203);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 52);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm Học Sinh";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStudentManage
            // 
            this.btnStudentManage.Location = new System.Drawing.Point(155, 203);
            this.btnStudentManage.Name = "btnStudentManage";
            this.btnStudentManage.Size = new System.Drawing.Size(99, 52);
            this.btnStudentManage.TabIndex = 3;
            this.btnStudentManage.Text = "Quản lý học sinh";
            this.btnStudentManage.UseVisualStyleBackColor = true;
            this.btnStudentManage.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 511);
            this.Controls.Add(this.btnStudentManage);
            this.Controls.Add(this.btnAdd);
            this.Name = "FrmMain";
            this.Text = "ChuNhiem";
            this.Load += new System.EventHandler(this.ChuNhiem_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnStudentManage;
    }
}