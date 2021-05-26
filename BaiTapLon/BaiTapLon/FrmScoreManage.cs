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
    public partial class FrmScoreManage : Form
    {
        
        public FrmScoreManage()
        {
            InitializeComponent();
            
        }
        private void btnShowScoreClass_Click(object sender, EventArgs e)
        {
           
        }

        private void btnShowScoreSubject_Click(object sender, EventArgs e)
        {
           
        }

        private void btnShowScoreStuId_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvScoreList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            FrmEditScore info = new FrmEditScore();

            info.Show();
        }
    }
}
