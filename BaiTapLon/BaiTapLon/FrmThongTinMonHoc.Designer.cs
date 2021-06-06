
namespace BaiTapLon
{
    partial class FrmThongTinMonHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThongTinMonHoc));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmota = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbhocky = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttenmon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbGv = new System.Windows.Forms.ComboBox();
            this.txtmamon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtmota);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbhocky);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txttenmon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbGv);
            this.groupBox1.Controls.Add(this.txtmamon);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(938, 273);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[Thông Tin Môn Học]";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(833, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 67);
            this.button2.TabIndex = 7;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(398, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mô tả:";
            // 
            // txtmota
            // 
            this.txtmota.Location = new System.Drawing.Point(453, 45);
            this.txtmota.Name = "txtmota";
            this.txtmota.Size = new System.Drawing.Size(328, 187);
            this.txtmota.TabIndex = 5;
            this.txtmota.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(833, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 67);
            this.button1.TabIndex = 6;
            this.button1.Text = "Chỉnh sửa:";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Học kỳ:";
            // 
            // cbhocky
            // 
            this.cbhocky.FormattingEnabled = true;
            this.cbhocky.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbhocky.Location = new System.Drawing.Point(167, 211);
            this.cbhocky.Name = "cbhocky";
            this.cbhocky.Size = new System.Drawing.Size(170, 21);
            this.cbhocky.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Giáo viên dạy:";
            // 
            // txttenmon
            // 
            this.txttenmon.Location = new System.Drawing.Point(167, 99);
            this.txttenmon.Name = "txttenmon";
            this.txttenmon.Size = new System.Drawing.Size(170, 20);
            this.txttenmon.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên môn:";
            // 
            // cbGv
            // 
            this.cbGv.FormattingEnabled = true;
            this.cbGv.Location = new System.Drawing.Point(167, 153);
            this.cbGv.Name = "cbGv";
            this.cbGv.Size = new System.Drawing.Size(170, 21);
            this.cbGv.TabIndex = 3;
            // 
            // txtmamon
            // 
            this.txtmamon.Enabled = false;
            this.txtmamon.Location = new System.Drawing.Point(167, 45);
            this.txtmamon.Name = "txtmamon";
            this.txtmamon.Size = new System.Drawing.Size(170, 20);
            this.txtmamon.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã môn:";
            // 
            // FrmThongTinMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 450);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmThongTinMonHoc";
            this.Text = "Thông tin môn học";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtmota;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbhocky;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttenmon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbGv;
        private System.Windows.Forms.TextBox txtmamon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}