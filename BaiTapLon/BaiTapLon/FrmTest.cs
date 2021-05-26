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
    public partial class FrmTest : Form
    {
        KetQuaHT_BLL ket = new KetQuaHT_BLL();
        Lop_BLL lop = new Lop_BLL();
        GiaoVien_BLL gv = new GiaoVien_BLL();
        public FrmTest()
        {
            InitializeComponent();
        }

        private void FrmTest_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = gv.GetGiaoVienById("GV001");
        }
    }
}
