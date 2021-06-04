
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbmon = new System.Windows.Forms.ComboBox();
            this.mahocsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenhocsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mamonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemtb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemthilan1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemthilan2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemtongket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocky = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hankiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.diemtb,
            this.diemthilan1,
            this.diemthilan2,
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
            // cbLop
            // 
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(144, 50);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(209, 21);
            this.cbLop.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(479, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 144);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[Quản lý kết quả học tập]";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lớp";
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
            this.cbmon.Location = new System.Drawing.Point(144, 91);
            this.cbmon.Name = "cbmon";
            this.cbmon.Size = new System.Drawing.Size(209, 21);
            this.cbmon.TabIndex = 6;
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
            // diemtb
            // 
            this.diemtb.DataPropertyName = "diemtb";
            this.diemtb.HeaderText = "Điểm trung bình";
            this.diemtb.Name = "diemtb";
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
            // FrmQuanLyKetQuaHocTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 696);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmQuanLyKetQuaHocTap";
            this.Text = "FrmQuanLyKetQuaHocTap";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn diemtb;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemthilan1;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemthilan2;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemtongket;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocky;
        private System.Windows.Forms.DataGridViewTextBoxColumn hankiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn mota;
    }
}