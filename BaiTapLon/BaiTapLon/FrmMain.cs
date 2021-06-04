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
            FrmThemHocSinh frm = new FrmThemHocSinh();
            OpenForm(frm);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmQuanLyHocSinh frm = new FrmQuanLyHocSinh();
            OpenForm(frm);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmQuanLyKetQuaHocTap frm = new FrmQuanLyKetQuaHocTap();
            OpenForm(frm);
        }

        private void btnModifiPw_Click(object sender, EventArgs e)
        {
            FrmQuanLyGiaoVien frm = new FrmQuanLyGiaoVien();
            OpenForm(frm);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            FrmQuanLyMonHoc frm = new FrmQuanLyMonHoc();
            OpenForm(frm);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FrmQuanLyLopHoc frm = new FrmQuanLyLopHoc();
            OpenForm(frm);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
