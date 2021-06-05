
namespace BaiTapLon
{
    partial class FrmQuanLyGiaoVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyGiaoVien));
            this.txttengv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmagv = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.magiaovien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tengiaovien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socmnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tobomon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnthemgv = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txttengv
            // 
            this.txttengv.Location = new System.Drawing.Point(108, 33);
            this.txttengv.Name = "txttengv";
            this.txttengv.Size = new System.Drawing.Size(137, 20);
            this.txttengv.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ tên:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 26);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã giáo viên";
            // 
            // txtmagv
            // 
            this.txtmagv.Location = new System.Drawing.Point(108, 37);
            this.txtmagv.Name = "txtmagv";
            this.txtmagv.Size = new System.Drawing.Size(137, 20);
            this.txtmagv.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(1045, 103);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(115, 66);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtmagv);
            this.groupBox1.Location = new System.Drawing.Point(37, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 81);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[Tìm theo mã giáo viên]";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.magiaovien,
            this.tengiaovien,
            this.socmnd,
            this.tobomon,
            this.gioitinh,
            this.sodienthoai,
            this.mota});
            this.dataGridView1.Location = new System.Drawing.Point(37, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1123, 462);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // magiaovien
            // 
            this.magiaovien.DataPropertyName = "magiaovien";
            this.magiaovien.HeaderText = "Mã giáo viên";
            this.magiaovien.Name = "magiaovien";
            this.magiaovien.Width = 150;
            // 
            // tengiaovien
            // 
            this.tengiaovien.DataPropertyName = "tengiaovien";
            this.tengiaovien.HeaderText = "Tên giáo viên";
            this.tengiaovien.Name = "tengiaovien";
            this.tengiaovien.Width = 200;
            // 
            // socmnd
            // 
            this.socmnd.DataPropertyName = "socmnd";
            this.socmnd.HeaderText = "Số CMND";
            this.socmnd.Name = "socmnd";
            this.socmnd.Width = 150;
            // 
            // tobomon
            // 
            this.tobomon.DataPropertyName = "tobomon";
            this.tobomon.HeaderText = "Tổ bộ môn";
            this.tobomon.Name = "tobomon";
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "gioitinh";
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.Name = "gioitinh";
            // 
            // sodienthoai
            // 
            this.sodienthoai.DataPropertyName = "sodienthoai";
            this.sodienthoai.HeaderText = "Số điện thoại";
            this.sodienthoai.Name = "sodienthoai";
            // 
            // mota
            // 
            this.mota.DataPropertyName = "mota";
            this.mota.HeaderText = "Mô tả";
            this.mota.Name = "mota";
            this.mota.Width = 300;
            // 
            // btnthemgv
            // 
            this.btnthemgv.Location = new System.Drawing.Point(662, 79);
            this.btnthemgv.Name = "btnthemgv";
            this.btnthemgv.Size = new System.Drawing.Size(115, 66);
            this.btnthemgv.TabIndex = 4;
            this.btnthemgv.Text = "Thêm Giáo Viên";
            this.btnthemgv.UseVisualStyleBackColor = true;
            this.btnthemgv.Click += new System.EventHandler(this.btnthemgv_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(32, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quản Lý Giáo Viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txttengv);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(37, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 81);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "[Tìm theo tên giáo viên]";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(303, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 26);
            this.button2.TabIndex = 3;
            this.button2.Text = "Tìm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(662, 162);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 66);
            this.button5.TabIndex = 10;
            this.button5.Text = "Hiển thị toàn bộ giáo viên";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(489, 162);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(115, 66);
            this.button6.TabIndex = 11;
            this.button6.Text = "Hiển thị tất cả giáo viên nam";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(489, 79);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(115, 66);
            this.button7.TabIndex = 12;
            this.button7.Text = "Hiển thị tất cả giáo viên nữ";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // FrmQuanLyGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 529);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnthemgv);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmQuanLyGiaoVien";
            this.Text = "Quản Lý Giáo Viên";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttengv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmagv;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn magiaovien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tengiaovien;
        private System.Windows.Forms.DataGridViewTextBoxColumn socmnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn tobomon;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn mota;
        private System.Windows.Forms.Button btnthemgv;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}