
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnStudentManage = new System.Windows.Forms.Button();
            this.btnScoreManage = new System.Windows.Forms.Button();
            this.btnModifiPw = new System.Windows.Forms.Button();
            this.spContainer = new System.Windows.Forms.SplitContainer();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spContainer)).BeginInit();
            this.spContainer.Panel1.SuspendLayout();
            this.spContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStudentManage
            // 
            this.btnStudentManage.Location = new System.Drawing.Point(26, 15);
            this.btnStudentManage.Name = "btnStudentManage";
            this.btnStudentManage.Size = new System.Drawing.Size(99, 91);
            this.btnStudentManage.TabIndex = 2;
            this.btnStudentManage.Text = "Quản lý học sinh";
            this.btnStudentManage.UseVisualStyleBackColor = true;
            this.btnStudentManage.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnScoreManage
            // 
            this.btnScoreManage.Location = new System.Drawing.Point(26, 112);
            this.btnScoreManage.Name = "btnScoreManage";
            this.btnScoreManage.Size = new System.Drawing.Size(99, 91);
            this.btnScoreManage.TabIndex = 3;
            this.btnScoreManage.Text = "Quản lý điểm";
            this.btnScoreManage.UseVisualStyleBackColor = true;
            this.btnScoreManage.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnModifiPw
            // 
            this.btnModifiPw.Location = new System.Drawing.Point(26, 209);
            this.btnModifiPw.Name = "btnModifiPw";
            this.btnModifiPw.Size = new System.Drawing.Size(99, 91);
            this.btnModifiPw.TabIndex = 4;
            this.btnModifiPw.Text = "Quản Lý Giáo Viên";
            this.btnModifiPw.UseVisualStyleBackColor = true;
            this.btnModifiPw.Click += new System.EventHandler(this.btnModifiPw_Click);
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
            this.spContainer.Panel1.Controls.Add(this.button4);
            this.spContainer.Panel1.Controls.Add(this.button3);
            this.spContainer.Panel1.Controls.Add(this.button2);
            this.spContainer.Panel1.Controls.Add(this.button1);
            this.spContainer.Panel1.Controls.Add(this.btnStudentManage);
            this.spContainer.Panel1.Controls.Add(this.btnModifiPw);
            this.spContainer.Panel1.Controls.Add(this.btnScoreManage);
            this.spContainer.Size = new System.Drawing.Size(1001, 691);
            this.spContainer.SplitterDistance = 156;
            this.spContainer.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(26, 597);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 84);
            this.button3.TabIndex = 7;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 91);
            this.button2.TabIndex = 6;
            this.button2.Text = "Quản Lý Lớp Học";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 91);
            this.button1.TabIndex = 5;
            this.button1.Text = "Quản Lý Môn Học";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(26, 500);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 91);
            this.button4.TabIndex = 8;
            this.button4.Text = "Đánh giá kết quả học tập";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 691);
            this.Controls.Add(this.spContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "Trang chủ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ChuNhiem_Load);
            this.spContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spContainer)).EndInit();
            this.spContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnStudentManage;
        private System.Windows.Forms.Button btnScoreManage;
        private System.Windows.Forms.Button btnModifiPw;
        private System.Windows.Forms.SplitContainer spContainer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}