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
    public partial class FrmQuanLyGiaoVien : Form
    {
        private GiaoVien_BLL giaoVien_BLL = new GiaoVien_BLL();
        private List<GiaoVien> giaoViens = new List<GiaoVien>();

        public void getGiaovien()
        {
            giaoViens = giaoVien_BLL.GetAll();
            dataGridView1.DataSource = giaoViens;
        }
        public FrmQuanLyGiaoVien()
        {
            InitializeComponent();
            getGiaovien();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string magv = txtmagv.Text;
            if (magv.Length == 0)
            {
                MessageBox.Show("Cần nhập mã giáo viên tìm");
                return;
            }

            if (magv.Length != 0)
            {
                try
                {
                    dataGridView1.DataSource = giaoVien_BLL.GetGiaoVienById(magv);
                }
                catch
                {
                    MessageBox.Show("Không tìm thấy");
                }

            }

        }/*
        
                
            }*/
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView1.Rows.Count == 0)
                return;
            string mahs = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            GiaoVien giaoVien = giaoVien_BLL.GetGiaoVienById(mahs)[0];

            FrmThongTinGiaoVien frm = new FrmThongTinGiaoVien(giaoVien, dataGridView1.CurrentRow);
            frm.ShowDialog();
        }

        private void btnthemgv_Click(object sender, EventArgs e)
        {
            FrmThemGiaoVien frm = new FrmThemGiaoVien();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tengv = txttengv.Text;
            if (tengv.Length != 0)
            {
                try
                {
                    dataGridView1.DataSource = giaoVien_BLL.GetGiaoViensByName(tengv);
                }
                catch
                {
                    MessageBox.Show("Không tìm thấy");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = giaoVien_BLL.GetAll();
            }
            catch
            {
                MessageBox.Show("Không tìm thấy");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            try
            {
                dataGridView1.DataSource = giaoVien_BLL.GetGiaoVienByGioitinh("Nam");
            }
            catch
            {
                MessageBox.Show("Không tìm thấy");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = giaoVien_BLL.GetGiaoVienByGioitinh("Nữ");
            }
            catch
            {
                MessageBox.Show("Không tìm thấy");
            }
        }
    }
}
