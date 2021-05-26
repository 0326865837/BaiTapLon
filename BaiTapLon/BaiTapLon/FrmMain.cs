using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace BaiTapLon
{
    public partial class FrmMain : Form
    {
        // private Lop_BLL lop = new BLL.Lop_BLL();
        private Lop_BLL lop_bll = new Lop_BLL();
        public FrmMain()
        {
            InitializeComponent();
        }

        private void CloseFrm()
        {

            foreach (var item in spContainer.Panel2.Controls)
            {
                if (item is Form)
                {
                    Form objFrm = (Form)item;
                    objFrm.Close();
                }
            }
        }

        private void OpenForm(Form objFrm)
        {
            CloseFrm();
            objFrm.TopLevel = false;
            objFrm.FormBorderStyle = FormBorderStyle.None;
            objFrm.Parent = this.spContainer.Panel2;
            objFrm.Dock = DockStyle.Fill;
            objFrm.Show();
        }
        private void ChuNhiem_Load(object sender, EventArgs e)
        {
          
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdd frm = new FrmAdd();
            OpenForm(frm);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmStudentManage frm = new FrmStudentManage();
            OpenForm(frm);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmScoreManage frm = new FrmScoreManage();
            OpenForm(frm);
        }

        private void btnModifiPw_Click(object sender, EventArgs e)
        {
            FrmModifiPw frm = new FrmModifiPw();
            OpenForm(frm);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            FrmTest frm = new FrmTest();
            OpenForm(frm);
        }
    }
}
