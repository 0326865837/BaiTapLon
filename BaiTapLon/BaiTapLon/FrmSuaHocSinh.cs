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
    public partial class FrmSuaHocSinh : Form
    {
        private Lop_BLL lop_BLL = new Lop_BLL();
        private HocSinh hocSinh = new HocSinh();
        private HocSinh_BLL hocSinh_bll = new HocSinh_BLL();
        public FrmSuaHocSinh(HocSinh hocsinh, DataGridViewRow currentRow)
        {
            InitializeComponent();
            cblop.DataSource = lop_BLL.getAllClass();
            cblop.DisplayMember = "tenlop";
            cblop.ValueMember = "malop";
            cblop.SelectedValue = hocsinh.malop;

            txtmahs.Text = hocsinh.mahocsinh;
            txtdiachi.Text = hocsinh.diachi;
            txttenhocsinh.Text = hocsinh.tenhocsinh;
            rtmota.Text = hocsinh.mota;
            if (hocsinh.gioitinh == "Nam") radioButton1.Checked = true; 
            else radioButton2.Checked = true;
            dtpngaynhaphoc.Value = hocsinh.ngaynhaphoc;
            dtpngaysinh.Value = hocsinh.ngaysinh;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string thoten = txttenhocsinh.Text;
            string tmahs = txtmahs.Text;
            string tdiachi = txtdiachi.Text;
            DateTime tngaysinh = dtpngaysinh.Value;
            DateTime tngaynhaphoc = dtpngaynhaphoc.Value;
            string tmota = rtmota.Text.Length > 0 ? rtmota.Text : " ";
            string tlop = cblop.SelectedValue.ToString();
            string tgioitinh = radioButton1.Checked ? "Nam" : "Nữ";
            if (thoten.Length == 0 || tmahs.Length == 0 || tdiachi.Length == 0) MessageBox.Show("Vui lòng nhập đầy đủ thông tin học sinh");
            else
            {
                try
                {
                    hocSinh = new HocSinh()
                    {
                        tenhocsinh = thoten,
                        mahocsinh = tmahs,
                        diachi = tdiachi,
                        ngaysinh = tngaysinh,
                        ngaynhaphoc = tngaynhaphoc,
                        gioitinh = tgioitinh,
                        mota = tmota,
                        malop = tlop
                    };
                    int result = hocSinh_bll.Update(hocSinh);
                    if (result != 0)
                    {
                        MessageBox.Show("Sửa thông tin hoc sinh thành công");
                    }
                }
                catch
                {
                    MessageBox.Show("Có lỗi");
                }
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
