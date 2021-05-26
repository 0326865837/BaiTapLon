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
    public partial class FrmStudentManage : Form
    {

        public FrmStudentManage()
        {
            InitializeComponent();
           
        }

        private void btntimclass_Click(object sender, EventArgs e)
        {
           
        }

        private void btntimid_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            
        }

        private void dgvStudentList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmStudentInfo info = new FrmStudentInfo();

            info.Show();
        }
    }
}
