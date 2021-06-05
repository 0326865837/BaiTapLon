
namespace BaiTapLon
{
    partial class FrmQuanLyHocSinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyHocSinh));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btntimclass = new System.Windows.Forms.Button();
            this.cblop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btntimid = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmahs = new System.Windows.Forms.TextBox();
            this.dgvStudentList = new System.Windows.Forms.DataGridView();
            this.mahocsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenhocsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaynhaphoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btntimtheoten = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txttenhocsinh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentList)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btntimclass);
            this.groupBox1.Controls.Add(this.cblop);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(60, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[Tìm theo lớp]";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(470, 26);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.ForeColor = System.Drawing.Color.Red;
            this.btnDel.Location = new System.Drawing.Point(344, 26);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(96, 23);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "Xóa học sinh";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btntimclass
            // 
            this.btntimclass.Location = new System.Drawing.Point(247, 24);
            this.btntimclass.Name = "btntimclass";
            this.btntimclass.Size = new System.Drawing.Size(75, 23);
            this.btntimclass.TabIndex = 3;
            this.btntimclass.Text = "Tìm";
            this.btntimclass.UseVisualStyleBackColor = true;
            this.btntimclass.Click += new System.EventHandler(this.btntimclass_Click);
            // 
            // cblop
            // 
            this.cblop.FormattingEnabled = true;
            this.cblop.Location = new System.Drawing.Point(88, 26);
            this.cblop.Name = "cblop";
            this.cblop.Size = new System.Drawing.Size(121, 21);
            this.cblop.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lớp:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1082, 80);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 43);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btntimid);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtmahs);
            this.groupBox2.Location = new System.Drawing.Point(60, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 72);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "[Tìm theo mã học sinh]";
            // 
            // btntimid
            // 
            this.btntimid.Location = new System.Drawing.Point(247, 36);
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
            this.label2.Location = new System.Drawing.Point(11, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã học sinh:";
            // 
            // txtmahs
            // 
            this.txtmahs.Location = new System.Drawing.Point(88, 36);
            this.txtmahs.Name = "txtmahs";
            this.txtmahs.Size = new System.Drawing.Size(121, 20);
            this.txtmahs.TabIndex = 0;
            // 
            // dgvStudentList
            // 
            this.dgvStudentList.AllowUserToAddRows = false;
            this.dgvStudentList.AllowUserToDeleteRows = false;
            this.dgvStudentList.AllowUserToOrderColumns = true;
            this.dgvStudentList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvStudentList.ColumnHeadersHeight = 30;
            this.dgvStudentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahocsinh,
            this.tenhocsinh,
            this.malop,
            this.gioitinh,
            this.ngaysinh,
            this.ngaynhaphoc,
            this.diachi,
            this.mota});
            this.dgvStudentList.Location = new System.Drawing.Point(60, 228);
            this.dgvStudentList.Name = "dgvStudentList";
            this.dgvStudentList.ReadOnly = true;
            this.dgvStudentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudentList.Size = new System.Drawing.Size(1097, 460);
            this.dgvStudentList.TabIndex = 5;
            this.dgvStudentList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudentList_CellDoubleClick);
            // 
            // mahocsinh
            // 
            this.mahocsinh.DataPropertyName = "mahocsinh";
            this.mahocsinh.HeaderText = "Mã học sinh";
            this.mahocsinh.Name = "mahocsinh";
            this.mahocsinh.ReadOnly = true;
            // 
            // tenhocsinh
            // 
            this.tenhocsinh.DataPropertyName = "tenhocsinh";
            this.tenhocsinh.HeaderText = "Họ Tên";
            this.tenhocsinh.Name = "tenhocsinh";
            this.tenhocsinh.ReadOnly = true;
            this.tenhocsinh.Width = 140;
            // 
            // malop
            // 
            this.malop.DataPropertyName = "malop";
            this.malop.HeaderText = "Lớp";
            this.malop.Name = "malop";
            this.malop.ReadOnly = true;
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "gioitinh";
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.ReadOnly = true;
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.ReadOnly = true;
            this.ngaysinh.Width = 150;
            // 
            // ngaynhaphoc
            // 
            this.ngaynhaphoc.DataPropertyName = "ngaynhaphoc";
            this.ngaynhaphoc.HeaderText = "Ngày nhập học";
            this.ngaynhaphoc.Name = "ngaynhaphoc";
            this.ngaynhaphoc.ReadOnly = true;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.Name = "diachi";
            this.diachi.ReadOnly = true;
            this.diachi.Width = 200;
            // 
            // mota
            // 
            this.mota.DataPropertyName = "mota";
            this.mota.HeaderText = "Mô tả";
            this.mota.Name = "mota";
            this.mota.ReadOnly = true;
            this.mota.Width = 250;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btntimtheoten);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txttenhocsinh);
            this.groupBox3.Location = new System.Drawing.Point(456, 137);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(355, 72);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "[Tìm theo tên học sinh]";
            // 
            // btntimtheoten
            // 
            this.btntimtheoten.Location = new System.Drawing.Point(247, 36);
            this.btntimtheoten.Name = "btntimtheoten";
            this.btntimtheoten.Size = new System.Drawing.Size(75, 23);
            this.btntimtheoten.TabIndex = 3;
            this.btntimtheoten.Text = "Tìm";
            this.btntimtheoten.UseVisualStyleBackColor = true;
            this.btntimtheoten.Click += new System.EventHandler(this.btntimtheoten_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ và tên:";
            // 
            // txttenhocsinh
            // 
            this.txttenhocsinh.Location = new System.Drawing.Point(88, 36);
            this.txttenhocsinh.Name = "txttenhocsinh";
            this.txttenhocsinh.Size = new System.Drawing.Size(121, 20);
            this.txttenhocsinh.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(55, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quản lý hoc sinh";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(837, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 43);
            this.button1.TabIndex = 7;
            this.button1.Text = "Thêm học sinh mới";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(713, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 43);
            this.button2.TabIndex = 8;
            this.button2.Text = "Hiển thị toàn bộ học sinh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmQuanLyHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 700);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvStudentList);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmQuanLyHocSinh";
            this.Text = "Quản lý học sinh";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentList)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btntimclass;
        private System.Windows.Forms.ComboBox cblop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btntimid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmahs;
        private System.Windows.Forms.DataGridView dgvStudentList;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btntimtheoten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttenhocsinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahocsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhocsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn malop;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaynhaphoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn mota;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}