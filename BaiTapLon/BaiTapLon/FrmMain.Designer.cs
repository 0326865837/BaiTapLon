
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
            this.btnScoreManage = new System.Windows.Forms.Button();
            this.btnModifiPw = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.spContainer = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.spContainer)).BeginInit();
            this.spContainer.Panel1.SuspendLayout();
            this.spContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(10, 121);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 52);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm Học Sinh";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStudentManage
            // 
            this.btnStudentManage.Location = new System.Drawing.Point(115, 121);
            this.btnStudentManage.Name = "btnStudentManage";
            this.btnStudentManage.Size = new System.Drawing.Size(99, 52);
            this.btnStudentManage.TabIndex = 3;
            this.btnStudentManage.Text = "Quản lý học sinh";
            this.btnStudentManage.UseVisualStyleBackColor = true;
            this.btnStudentManage.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnScoreManage
            // 
            this.btnScoreManage.Location = new System.Drawing.Point(115, 209);
            this.btnScoreManage.Name = "btnScoreManage";
            this.btnScoreManage.Size = new System.Drawing.Size(99, 52);
            this.btnScoreManage.TabIndex = 4;
            this.btnScoreManage.Text = "Quản lý điểm";
            this.btnScoreManage.UseVisualStyleBackColor = true;
            this.btnScoreManage.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnModifiPw
            // 
            this.btnModifiPw.Location = new System.Drawing.Point(10, 292);
            this.btnModifiPw.Name = "btnModifiPw";
            this.btnModifiPw.Size = new System.Drawing.Size(99, 52);
            this.btnModifiPw.TabIndex = 5;
            this.btnModifiPw.Text = "Đổi mật khẩu";
            this.btnModifiPw.UseVisualStyleBackColor = true;
            this.btnModifiPw.Click += new System.EventHandler(this.btnModifiPw_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 52);
            this.button1.TabIndex = 6;
            this.button1.Text = "Nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // spContainer
            // 
            this.spContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spContainer.Location = new System.Drawing.Point(0, 0);
            this.spContainer.Name = "spContainer";
            // 
            // spContainer.Panel1
            // 
            this.spContainer.Panel1.Controls.Add(this.btnAdd);
            this.spContainer.Panel1.Controls.Add(this.button1);
            this.spContainer.Panel1.Controls.Add(this.btnStudentManage);
            this.spContainer.Panel1.Controls.Add(this.btnModifiPw);
            this.spContainer.Panel1.Controls.Add(this.btnScoreManage);
            this.spContainer.Size = new System.Drawing.Size(1222, 564);
            this.spContainer.SplitterDistance = 223;
            this.spContainer.TabIndex = 7;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 564);
            this.Controls.Add(this.spContainer);
            this.Name = "FrmMain";
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.ChuNhiem_Load);
            this.spContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spContainer)).EndInit();
            this.spContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnStudentManage;
        private System.Windows.Forms.Button btnScoreManage;
        private System.Windows.Forms.Button btnModifiPw;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer spContainer;
    }
}