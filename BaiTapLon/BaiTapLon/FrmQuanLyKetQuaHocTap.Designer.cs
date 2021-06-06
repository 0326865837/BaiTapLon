
namespace BaiTapLon
{
    partial class FrmQuanLyKetQuaHocTap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyKetQuaHocTap));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mahocsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenhocsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mamonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemthilan1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemthilan2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemtb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemtongket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocky = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hankiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbmon = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtmahocsinh = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txttenhocsinh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahocsinh,
            this.tenhocsinh,
            this.mamonhoc,
            this.malop,
            this.diemthilan1,
            this.diemthilan2,
            this.diemtb,
            this.diemtongket,
            this.hocky,
            this.hankiem,
            this.mota});
            this.dataGridView1.Location = new System.Drawing.Point(12, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1167, 453);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // mahocsinh
            // 
            this.mahocsinh.DataPropertyName = "mahocsinh";
            this.mahocsinh.HeaderText = "Mã học sinh";
            this.mahocsinh.Name = "mahocsinh";
            // 
            // tenhocsinh
            // 
            this.tenhocsinh.DataPropertyName = "tenhocsinh";
            this.tenhocsinh.HeaderText = "Tên học sinh";
            this.tenhocsinh.Name = "tenhocsinh";
            // 
            // mamonhoc
            // 
            this.mamonhoc.DataPropertyName = "mamonhoc";
            this.mamonhoc.HeaderText = "Mã môn";
            this.mamonhoc.Name = "mamonhoc";
            // 
            // malop
            // 
            this.malop.DataPropertyName = "malop";
            this.malop.HeaderText = "Mã lớp";
            this.malop.Name = "malop";
            // 
            // diemthilan1
            // 
            this.diemthilan1.DataPropertyName = "diemthilan1";
            this.diemthilan1.HeaderText = "Điểm lần 1";
            this.diemthilan1.Name = "diemthilan1";
            // 
            // diemthilan2
            // 
            this.diemthilan2.DataPropertyName = "diemthilan2";
            this.diemthilan2.HeaderText = "Điểm lần 2";
            this.diemthilan2.Name = "diemthilan2";
            // 
            // diemtb
            // 
            this.diemtb.DataPropertyName = "diemtb";
            this.diemtb.HeaderText = "Điểm trung bình";
            this.diemtb.Name = "diemtb";
            // 
            // diemtongket
            // 
            this.diemtongket.DataPropertyName = "diemtongket";
            this.diemtongket.HeaderText = "Điểm tổng kết";
            this.diemtongket.Name = "diemtongket";
            // 
            // hocky
            // 
            this.hocky.DataPropertyName = "hocky";
            this.hocky.HeaderText = "Học kỳ";
            this.hocky.Name = "hocky";
            // 
            // hankiem
            // 
            this.hankiem.DataPropertyName = "hankiem";
            this.hankiem.HeaderText = "Hạnh kiểm";
            this.hankiem.Name = "hankiem";
            // 
            // mota
            // 
            this.mota.DataPropertyName = "mota";
            this.mota.HeaderText = "Mô tả";
            this.mota.Name = "mota";
            this.mota.Width = 150;
            // 
            // cbLop
            // 
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(78, 50);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(209, 21);
            this.cbLop.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 59);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbmon);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cbLop);
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 144);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[Tìm theo lớp và môn]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Môn";
            // 
            // cbmon
            // 
            this.cbmon.FormattingEnabled = true;
            this.cbmon.Location = new System.Drawing.Point(78, 91);
            this.cbmon.Name = "cbmon";
            this.cbmon.Size = new System.Drawing.Size(209, 21);
            this.cbmon.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(35, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quản Lý Kết Quả Học Tập";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtmahocsinh);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(441, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 71);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "[Tìm theo mã học sinh]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mã học sinh:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(316, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "Tìm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtmahocsinh
            // 
            this.txtmahocsinh.Location = new System.Drawing.Point(108, 29);
            this.txtmahocsinh.Name = "txtmahocsinh";
            this.txtmahocsinh.Size = new System.Drawing.Size(171, 20);
            this.txtmahocsinh.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txttenhocsinh);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Location = new System.Drawing.Point(441, 140);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(397, 71);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "[Tìm theo tên học sinh]";
            // 
            // txttenhocsinh
            // 
            this.txttenhocsinh.Location = new System.Drawing.Point(108, 29);
            this.txttenhocsinh.Name = "txttenhocsinh";
            this.txttenhocsinh.Size = new System.Drawing.Size(171, 20);
            this.txttenhocsinh.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên học sinh";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(316, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 30);
            this.button3.TabIndex = 4;
            this.button3.Text = "Tìm";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(879, 63);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 144);
            this.button4.TabIndex = 7;
            this.button4.Text = "Hiển thị toàn bộ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(1066, 63);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(126, 144);
            this.button5.TabIndex = 10;
            this.button5.Text = "Thoát";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // FrmQuanLyKetQuaHocTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 696);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmQuanLyKetQuaHocTap";
            this.Text = "Quản lý kết quả học tập";
            this.Load += new System.EventHandler(this.FrmQuanLyKetQuaHocTap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbmon;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahocsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhocsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamonhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn malop;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemthilan1;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemthilan2;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemtb;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemtongket;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocky;
        private System.Windows.Forms.DataGridViewTextBoxColumn hankiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn mota;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtmahocsinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txttenhocsinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}