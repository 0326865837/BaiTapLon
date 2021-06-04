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
    public partial class FrmSuaLop : Form
    {
        Khoi_BLL khoi_BLL = new Khoi_BLL();
        Lop_BLL lop_BLL = new Lop_BLL();
        Lop lop = new Lop();
        List<Lop> lops = new List<Lop>();
        public FrmSuaLop(Lop lop)
        {
            InitializeComponent();
            cbothemkhoi.DataSource = khoi_BLL.getAll();
            cbothemkhoi.DisplayMember = "tenkhoi";
            cbothemkhoi.ValueMember = "makhoi";
            txtmota.Text = lop.mota;
            txttmalop.Text = lop.malop;
            txtttenlop.Text = lop.tenlop;
            cbothemkhoi.SelectedValue = lop.makhoi;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tmalop = txttmalop.Text;
            string ttenlop = txtttenlop.Text;
            string tmota = txtmota.Text;
            string tmakhoi = cbothemkhoi.SelectedValue.ToString();
            if (tmalop.Length == 0 || ttenlop.Length == 0)
            {
                MessageBox.Show("VUi lòng nhập đầy đủ thông tin");
                return;
            }
            try
            {
                lop = new Lop()
                {
                    malop = tmalop,
                    makhoi = tmakhoi,
                    tenlop = ttenlop,
                    mota = tmota
                };
                int result = lop_BLL.Update(lop);
                if (result > 0)
                {
                    MessageBox.Show("Sửa thành công");
                    lops.Add(lop);
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi, sửa không thành công");
            }
            dataGridView2.DataSource = lops;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
