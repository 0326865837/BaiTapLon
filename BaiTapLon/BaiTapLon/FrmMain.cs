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



        private void ChuNhiem_Load(object sender, EventArgs e)
        {
            //this.dataGridView1.DataSource = lop_bll.getAllClass();
           
        }

      


        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdd frm = new FrmAdd();
            frm.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmStudentManage frm = new FrmStudentManage();
            frm.Show();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
