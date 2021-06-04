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
    public partial class FrmThemGiaoVien : Form
    {
        GiaoVien giaoVien = new GiaoVien();
        GiaoVien_BLL giaoVien_BLL = new GiaoVien_BLL();
        public FrmThemGiaoVien()
        {
            InitializeComponent();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string tmgv = txtmagv.Text;
            string thoten = txthoten.Text;
            string tmota = txtmota.Text;
            string ttobomon = cbtobomon.Text;
            string tgt;
            string tcmnd = txtcmnd.Text;
            string tsdt = txtsdt.Text;

            if (tmgv.Length == 0 || thoten.Length == 0 || ttobomon.Length == 0 || tcmnd.Length == 0 || tsdt.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            if (rdnam.Checked == true) tgt = "Nam";
            else tgt = "Nữ";
            if (tmota.Length == 0) tmota = " ";

            try
            {
                giaoVien = new GiaoVien()
                {
                    magiaovien = tmgv,
                    gioitinh = tgt,
                    mota = tmota,
                    tobomon = ttobomon,
                    socmnd = tcmnd,
                    sodienthoai = tsdt,
                    tengiaovien = thoten
                };
                string result = giaoVien_BLL.Insert(giaoVien);
                if(result.Length > 0)
                 MessageBox.Show("Thêm giáo viên thành công");
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
    }
}
