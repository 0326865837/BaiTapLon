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
    public partial class FrmNhapKetQuaHT : Form
    {
        private KetQuaHT kqht = new KetQuaHT();
        private KetQuaHT_BLL ketQuaHT_BLL = new KetQuaHT_BLL();
        public FrmNhapKetQuaHT(KetQuaHT kq)
        {
            InitializeComponent();
            txtmhs.Text = kq.mahocsinh;
            txttenhs.Text = kq.tenhocsinh;
            txtmamon.Text = kq.mamonhoc;
            txtlop.Text = kq.malop;
            txtdiem1.Text = kq.diemthilan1;
            txtdiem2.Text = kq.diemthilan2;
            txtdiemtb.Text = kq.diemtb;
            txtdiemtongket.Text = kq.diemtongket;
            richTextBox1.Text = kq.mota;
            txthocky.Text = kq.hocky;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txthocky.TextLength == 0)
            {
                MessageBox.Show("Nhập học kì");
                return;
            }
            kqht = new KetQuaHT()
            {
                mahocsinh = txtmhs.Text,
                tenhocsinh = txttenhs.Text,
                mamonhoc = txtmamon.Text,
                malop = txtlop.Text,
                diemthilan1 = txtdiem1.Text,
                diemthilan2 = txtdiem2.Text,
                diemtb = txtdiemtb.Text,
                diemtongket = txtdiemtongket.Text,
                hanhkiem = cbhanhkiem.Text,
                hocky = txthocky.Text,
                mota = richTextBox1.Text
            };
            int result = ketQuaHT_BLL.Update(kqht);
            if (result > 0)
            {
                MessageBox.Show("Nhập điểm thành công");
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string diem1 = txtdiem1.Text;
            string diem2 = txtdiem2.Text;
            string diemtb = txtdiemtb.Text;
            if (diem1.Length == 0 || diem2.Length == 0||diemtb.Length==0)
            {
                MessageBox.Show("Cần nhập đầy đủ điểm để tổng kết nhanh");
                return;
            }
            float diemtongket =  (float.Parse(diem1) + float.Parse(diem2))/2;
            txtdiemtongket.Text = Convert.ToString(diemtongket);
        }
    }
}
