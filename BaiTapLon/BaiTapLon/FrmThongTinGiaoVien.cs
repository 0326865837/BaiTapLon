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
    public partial class FrmThongTinGiaoVien : Form
    {
        GiaoVien_BLL giaoVien_BLL = new GiaoVien_BLL();
        GiaoVien giaoVien = new GiaoVien();
        public FrmThongTinGiaoVien(DTO.GiaoVien gv, DataGridViewRow currentRow)
        {
            InitializeComponent();
            txtcmnd.Text = gv.socmnd;
            txthoten.Text = gv.tengiaovien;
            txtmagv.Text = gv.magiaovien;
            if (gv.gioitinh == "Nam") rdnam.Checked = true; else radioButton2.Checked = true;
            cbtobomon.Text = gv.tobomon;
            txtmota.Text = gv.mota;
            txtsdt.Text = gv.sodienthoai;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tmgv = txtmagv.Text;
            string thoten = txthoten.Text;
            string tmota = txtmota.Text;
            string ttobomon = cbtobomon.Text;
            string tgt;
            string tcmnd = txtcmnd.Text;
            string tsdt = txtsdt.Text;

            if (tmgv.Length == 0 || thoten.Length == 0 || ttobomon.Length == 0 || tcmnd.Length == 0||tsdt.Length==0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            if (rdnam.Checked == true) tgt = "Nam";
            else tgt = "Nữ";
            if (tmota.Length == 0) tmota = " ";

            try
            {
                giaoVien = new GiaoVien() {
                    magiaovien = tmgv,
                    gioitinh = tgt,
                    mota = tmota,
                    tobomon = ttobomon,
                    socmnd = tcmnd,
                    sodienthoai = tsdt,
                    tengiaovien = thoten
                };
                int result = giaoVien_BLL.Update(giaoVien);
                if (result > 0) MessageBox.Show("Cập nhật thông tin thành công");
            }
            catch
            {
                MessageBox.Show("Lỗi hệ thống, mong bạn thông cảm");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string mgv = txtmagv.Text;
            try
            {
                DialogResult xoa;
                xoa = MessageBox.Show("Xóa giáo viên này ??", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (xoa == DialogResult.OK)
                {
                    giaoVien_BLL.Delete(mgv);
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
