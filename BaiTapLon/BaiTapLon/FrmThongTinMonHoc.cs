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
    public partial class FrmThongTinMonHoc : Form
    {
        GiaoVien_BLL gv_bll = new GiaoVien_BLL();
        MonHoc mh = new MonHoc();
        MonHoc_BLL monHoc_BLL = new MonHoc_BLL();
        public FrmThongTinMonHoc(MonHoc mh)
        {
            InitializeComponent();
            txtmamon.Text = mh.mamonhoc;
            txttenmon.Text = mh.tenmonhoc;
            txtmota.Text = mh.mota;
            cbhocky.SelectedItem = Convert.ToString(mh.hocky);

            cbGv.DataSource = gv_bll.GetAll();
            cbGv.DisplayMember = "tengiaovien";
            cbGv.ValueMember = "magiaovien";
            cbGv.SelectedValue = mh.magiaovien;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mamon = txtmamon.Text;
            string tenmon = txttenmon.Text;
            string hocki = cbhocky.Text;
            string magv = cbGv.SelectedValue.ToString();
            string tmota = txtmota.Text;
            if (txtmota.TextLength == 0) tmota = " ";
            if (mamon.Length == 0 || tenmon.Length == 0 || hocki.Length == 0 || magv.Length == 0)
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
                int result = monHoc_BLL.Update(mh);
                if (result > 0)
                {
                    MessageBox.Show("Cập nhật môn học thành công");
                 
                }
            }
            catch
            {
                MessageBox.Show("Lỗi thông tin nhập vào");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mamon = txtmamon.Text;
            try
            {
                DialogResult xoa;
                xoa = MessageBox.Show("Xóa môn học này ??", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (xoa == DialogResult.OK)
                {
                    monHoc_BLL.Delete(mamon);
                }
                
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
            this.Close();
        }
    }
}
