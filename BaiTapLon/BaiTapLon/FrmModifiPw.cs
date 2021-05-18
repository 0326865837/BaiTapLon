using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon
{
    public partial class FrmModifiPw : Form
    {
        TeacherService teacherSevices = new TeacherService();
        public FrmModifiPw()
        {
           // teacher = teacherSevices;
            InitializeComponent();
            txtName.Text = Program.CurrentGV.tengv;
            txtUsername.Text = Program.CurrentGV.taikhoan;

            txtUsername.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pw = txtPw.Text;
            string us = txtUsername.Text;
            string name = txtName.Text;



             if(pw.Length == 0)
            {
                MessageBox.Show("Nhập mật khẩu");
                return;
            }
            else
            {
                try
                {
                    int result = teacherSevices.UpdateAccout(us, pw, name);
                    if (result > 0)
                    {
                        MessageBox.Show("Sửa thành công");
                        Program.CurrentGV.matkhau = pw;
                    }
                    else
                    {
                        MessageBox.Show("Erorr");
                    }
                }
                catch
                {
                    MessageBox.Show("Lỗi hệ thống");
                }
            }
        }
    }
}
