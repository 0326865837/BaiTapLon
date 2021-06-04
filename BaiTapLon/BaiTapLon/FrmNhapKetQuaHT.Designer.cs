
namespace BaiTapLon
{
    partial class FrmNhapKetQuaHT
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
            this.txtmhs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbhanhkiem = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtlop = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txttenhs = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdiemtongket = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdiem2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdiem1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdiemtb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmamon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txthocky = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtmhs
            // 
            this.txtmhs.Enabled = false;
            this.txtmhs.Location = new System.Drawing.Point(122, 57);
            this.txtmhs.Name = "txtmhs";
            this.txtmhs.Size = new System.Drawing.Size(118, 20);
            this.txtmhs.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã học sinh:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(617, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 49);
            this.button1.TabIndex = 8;
            this.button1.Text = "Nhập điểm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txthocky);
            this.groupBox1.Controls.Add(this.cbhanhkiem);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.txtlop);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txttenhs);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtdiemtongket);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtdiem2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtdiem1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtdiemtb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtmamon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtmhs);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(34, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 503);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[Nhập điểm cho học sinh]";
            // 
            // cbhanhkiem
            // 
            this.cbhanhkiem.FormattingEnabled = true;
            this.cbhanhkiem.Items.AddRange(new object[] {
            "Giỏi",
            "Khá",
            "Trung bình",
            "Yếu",
            "Kém"});
            this.cbhanhkiem.Location = new System.Drawing.Point(395, 253);
            this.cbhanhkiem.Name = "cbhanhkiem";
            this.cbhanhkiem.Size = new System.Drawing.Size(121, 21);
            this.cbhanhkiem.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(617, 127);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 49);
            this.button3.TabIndex = 9;
            this.button3.Text = "Tự động đánh giá kết quả";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Hoc kỳ:";
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(617, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 49);
            this.button2.TabIndex = 10;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 303);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Ghi chú:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(122, 300);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(373, 185);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // txtlop
            // 
            this.txtlop.Enabled = false;
            this.txtlop.Location = new System.Drawing.Point(122, 207);
            this.txtlop.Name = "txtlop";
            this.txtlop.Size = new System.Drawing.Size(118, 20);
            this.txtlop.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Lớp:";
            // 
            // txttenhs
            // 
            this.txttenhs.Enabled = false;
            this.txttenhs.Location = new System.Drawing.Point(122, 108);
            this.txttenhs.Name = "txttenhs";
            this.txttenhs.Size = new System.Drawing.Size(118, 20);
            this.txttenhs.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Tên học sinh:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(296, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Hạnh kiểm:";
            // 
            // txtdiemtongket
            // 
            this.txtdiemtongket.Location = new System.Drawing.Point(395, 207);
            this.txtdiemtongket.Name = "txtdiemtongket";
            this.txtdiemtongket.Size = new System.Drawing.Size(121, 20);
            this.txtdiemtongket.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Điểm tổng kết:";
            // 
            // txtdiem2
            // 
            this.txtdiem2.Location = new System.Drawing.Point(395, 108);
            this.txtdiem2.Name = "txtdiem2";
            this.txtdiem2.Size = new System.Drawing.Size(121, 20);
            this.txtdiem2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Điểm lần 2:";
            // 
            // txtdiem1
            // 
            this.txtdiem1.Location = new System.Drawing.Point(395, 57);
            this.txtdiem1.Name = "txtdiem1";
            this.txtdiem1.Size = new System.Drawing.Size(121, 20);
            this.txtdiem1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Điểm lần 1:";
            // 
            // txtdiemtb
            // 
            this.txtdiemtb.Location = new System.Drawing.Point(395, 156);
            this.txtdiemtb.Name = "txtdiemtb";
            this.txtdiemtb.Size = new System.Drawing.Size(121, 20);
            this.txtdiemtb.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Điểm trung bình";
            // 
            // txtmamon
            // 
            this.txtmamon.Enabled = false;
            this.txtmamon.Location = new System.Drawing.Point(122, 156);
            this.txtmamon.Name = "txtmamon";
            this.txtmamon.Size = new System.Drawing.Size(118, 20);
            this.txtmamon.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã môn:";
            // 
            // txthocky
            // 
            this.txthocky.Location = new System.Drawing.Point(122, 256);
            this.txthocky.Name = "txthocky";
            this.txthocky.Size = new System.Drawing.Size(118, 20);
            this.txthocky.TabIndex = 25;
            // 
            // FrmNhapKetQuaHT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 545);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmNhapKetQuaHT";
            this.Text = "Nhập kết quả học tập";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtmhs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txtlop;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txttenhs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdiemtongket;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdiem2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdiem1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdiemtb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmamon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cbhanhkiem;
        private System.Windows.Forms.TextBox txthocky;
    }
}