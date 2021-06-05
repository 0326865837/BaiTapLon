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
    public partial class FrmQuanLyMonHoc : Form
    {
        private MonHoc_BLL monhoc_BLL = new MonHoc_BLL();
        public FrmQuanLyMonHoc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tenmon = txtenmon.Text;
            if (tenmon.Length == 0)
            {
                MessageBox.Show("Cần nhập mã môn để tìm");
                return;
            }
            try
            {
                dataGridView1.DataSource = monhoc_BLL.GetMonWithName(tenmon);
            }
            catch
            {
                MessageBox.Show("Lỗi hệ thống");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string tengv = txttengv.Text;
            if (tengv.Length == 0)
            {
                MessageBox.Show("Cần nhập mã môn để tìm");
                return;
            }
            try
            {
                dataGridView1.DataSource = monhoc_BLL.GetMonWithGiaoVien(tengv);
            }
            catch
            {
                MessageBox.Show("Lỗi hệ thống");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mamon = txtmamon.Text;
            if (mamon.Length == 0)
            {
                MessageBox.Show("Cần nhập mã môn để tìm");
                return;
            }
            try
            {
                dataGridView1.DataSource = monhoc_BLL.GetMon(mamon);
            }
            catch
            {
                MessageBox.Show("Lỗi hệ thống");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmThemMonHoc frm = new FrmThemMonHoc();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = monhoc_BLL.GetAllMonHoc();
            }
            catch
            {
                MessageBox.Show("Lỗi hệ thống");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView1.Rows.Count == 0)
                return;
            string mamon = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            MonHoc monhoc = monhoc_BLL.GetMon(mamon)[0];
            FrmThongTinMonHoc frm = new FrmThongTinMonHoc(monhoc);
            frm.ShowDialog();
        }
    }
}
