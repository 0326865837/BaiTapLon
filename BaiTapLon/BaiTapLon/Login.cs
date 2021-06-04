using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtmk.PasswordChar = '*';
        }
    

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string mk = txtmk.Text;
            string tk = txttk.Text;
            if(mk.Length == 0)
            {
                MessageBox.Show("Nhập mật khẩu");
                return;
            }else if (tk.Length == 0)
            {
                MessageBox.Show("Nhập tài khoản");
                return;
            }
            else
            {
                Admin ad = new Admin() {
                    username = tk,
                    password=mk
                };
                try
                {
                    Program.account = new Admin_BLL().Login(ad);
                    if(Program.account != null)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Tên người dùng hoặc mật khẩu không chính xác");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi");
                }
              
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
