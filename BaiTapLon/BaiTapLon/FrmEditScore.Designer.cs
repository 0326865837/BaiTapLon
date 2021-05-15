
namespace BaiTapLon
{
    partial class FrmEditScore
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
            this.txtktm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtkt1t = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtkthk = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStuId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSub = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtktm
            // 
            this.txtktm.Location = new System.Drawing.Point(42, 242);
            this.txtktm.Name = "txtktm";
            this.txtktm.Size = new System.Drawing.Size(78, 20);
            this.txtktm.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kiểm tra miệng";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(508, 35);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 62);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Nhập";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kiểm tra 1 tiết";
            // 
            // txtkt1t
            // 
            this.txtkt1t.Location = new System.Drawing.Point(164, 242);
            this.txtkt1t.Name = "txtkt1t";
            this.txtkt1t.Size = new System.Drawing.Size(73, 20);
            this.txtkt1t.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kiểm tra học kì";
            // 
            // txtkthk
            // 
            this.txtkthk.Location = new System.Drawing.Point(278, 242);
            this.txtkthk.Name = "txtkthk";
            this.txtkthk.Size = new System.Drawing.Size(79, 20);
            this.txtkthk.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Họ tên:";
            // 
            // txtStuName
            // 
            this.txtStuName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtStuName.Enabled = false;
            this.txtStuName.Location = new System.Drawing.Point(109, 32);
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(121, 20);
            this.txtStuName.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mã học sinh:";
            // 
            // txtStuId
            // 
            this.txtStuId.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtStuId.Enabled = false;
            this.txtStuId.Location = new System.Drawing.Point(109, 74);
            this.txtStuId.Name = "txtStuId";
            this.txtStuId.Size = new System.Drawing.Size(121, 20);
            this.txtStuId.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Môn:";
            // 
            // cbSub
            // 
            this.cbSub.FormattingEnabled = true;
            this.cbSub.Location = new System.Drawing.Point(109, 155);
            this.cbSub.Name = "cbSub";
            this.cbSub.Size = new System.Drawing.Size(121, 21);
            this.cbSub.TabIndex = 13;
            this.cbSub.SelectedValueChanged += new System.EventHandler(this.cbSub_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Lớp:";
            // 
            // txtClass
            // 
            this.txtClass.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtClass.Enabled = false;
            this.txtClass.Location = new System.Drawing.Point(109, 115);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(121, 20);
            this.txtClass.TabIndex = 15;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(508, 200);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 62);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtStuId);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.txtStuName);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtkthk);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtClass);
            this.groupBox1.Controls.Add(this.txtkt1t);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtktm);
            this.groupBox1.Controls.Add(this.cbSub);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 302);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[Nhập điểm]";
            // 
            // FrmEditScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 356);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmEditScore";
            this.Text = "FrmEditScore";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtktm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtkt1t;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtkthk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStuId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSub;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}