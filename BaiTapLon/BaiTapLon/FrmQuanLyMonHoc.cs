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
        List<GiaoVien> gvs = new List<GiaoVien>();
        GiaoVien_BLL giaoVien_BLL = new GiaoVien_BLL();
        MonHoc_BLL monHoc_BLL = new MonHoc_BLL();
        List<MonHoc> mhs = new List<MonHoc>();
        MonHoc mh = new MonHoc();
        public FrmQuanLyMonHoc()
        {
            InitializeComponent();
            cbGv.DataSource = giaoVien_BLL.GetAll(); 
            cbGv.DisplayMember = "tengiaovien";
            cbGv.ValueMember = "magiaovien";
            cbhocky.SelectedItem = "1";
            dataGridView1.DataSource = monHoc_BLL.GetAllMonHoc();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mamon = txtmamon.Text;
            string tenmon = txttenmon.Text;
            string hocki =cbhocky.Text;
            string magv = cbGv.SelectedValue.ToString();
            string tmota=txtmota.Text;
            if (txtmota.TextLength == 0) tmota = " ";
            if (mamon.Length == 0 || tenmon.Length == 0 ||hocki.Length == 0 || magv.Length == 0)
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
                return;
            }
            try
            {
                mh = new MonHoc()
                {
                    mamonhoc = mamon,
                    tenmonhoc = tenmon,
                    hocky = Convert.ToInt32(hocki),
                    magiaovien = magv,
                    mota = tmota
                };
                string result = monHoc_BLL.Insert(mh);
                if (result.Length > 0)
                {
                    MessageBox.Show("Thêm môn học thành công");
                    dataGridView1.DataSource = monHoc_BLL.GetAllMonHoc();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi thông tin nhập vào");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            

            if (this.dataGridView1.Rows.Count == 0)
                return;
            string mamon = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            MonHoc monhoc = monHoc_BLL.GetMon(mamon)[0];
            FrmThongTinMonHoc frm = new FrmThongTinMonHoc(monhoc);
            frm.ShowDialog();
        }

        private void txttenmon_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
             txtmamon.Clear();
             txttenmon.Clear();
             txtmota.Clear();
        }
    }
}
