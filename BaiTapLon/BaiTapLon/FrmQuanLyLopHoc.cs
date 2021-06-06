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
    public partial class FrmQuanLyLopHoc : Form
    {
        Khoi_BLL khoi_BLL = new Khoi_BLL();
        Lop_BLL lop_BLL = new Lop_BLL();
        Lop lop = new Lop();
        List<Lop> lops = new List<Lop>();
        public FrmQuanLyLopHoc()
        {
            InitializeComponent();
            cbkhoi.DataSource = khoi_BLL.getAll();
            cbkhoi.DisplayMember = "tenkhoi";
            cbkhoi.ValueMember = "makhoi";

            cbothemkhoi.DataSource = khoi_BLL.getAll();
            cbothemkhoi.DisplayMember = "tenkhoi";
            cbothemkhoi.ValueMember = "makhoi";
        }
        private void Clear()
        {
            txttmalop.Clear();
            txtttenlop.Clear();
            txtmota.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string makhoi = cbkhoi.SelectedValue.ToString();
            dataGridView1.DataSource = lop_BLL.GetLopWithKhoi(makhoi);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tmalop = txttmalop.Text;
            string ttenlop = txtttenlop.Text;
            string tmota = txtmota.Text;
            string tmakhoi =cbothemkhoi.SelectedValue.ToString();
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
                string result = lop_BLL.Insert(lop);
                if (result.Length > 0)
                {
                    MessageBox.Show("Thêm thành công");
                    Clear();
                lops.Add(lop);
                }
            }
            catch
            {
                MessageBox.Show("Thêm không thành công");
            }
            dataGridView2.DataSource= lops;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView1.Rows.Count == 0)
                return;
            string malop = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Lop lop = lop_BLL.GetLop(malop)[0];
            FrmSuaLop frm = new FrmSuaLop(lop);
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string malop = textBox1.Text;
            if (malop.Length == 0)
            {
                MessageBox.Show("Nhập mã lớp đề tìm");
                return;
            }
            dataGridView1.DataSource = lop_BLL.GetLop(malop);
        }

        private void FrmQuanLyLopHoc_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = lop_BLL.getAllClass();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = lop_BLL.getAllClass();
        }
    }
}
