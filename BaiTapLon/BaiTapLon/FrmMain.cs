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
        private StudentClassService lop_bll = new StudentClassService();
        public FrmMain()
        {
            InitializeComponent();
        }

        private void CloseFrm()
        {
            //½«Ç¶ÈëÔÚÃæ°åÖÐµÄ´°Ìå¹Ø±Õ
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
            objFrm.TopLevel = false;//½«×Ó´°ÌåÉèÎª·Ç¶¥²ã¶ÔÏó
            objFrm.FormBorderStyle = FormBorderStyle.None;
            objFrm.Parent = this.spContainer.Panel2;
            objFrm.Dock = DockStyle.Fill;
            objFrm.Show();
        }
        private void ChuNhiem_Load(object sender, EventArgs e)
        {
            //this.dataGridView1.DataSource = lop_bll.getAllClass();
            this.WindowState = FormWindowState.Maximized;

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
            FrmImportData frm = new FrmImportData();
            OpenForm(frm);
        }
    }
}
