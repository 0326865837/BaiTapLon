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
    public partial class FrmDanhGiaKetQua : Form
    {
        KetQuaHT_BLL kq = new KetQuaHT_BLL(); 
        public FrmDanhGiaKetQua()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gioi = kq.getHocSinhGioi().Count();
            int kha = kq.getHocSinhKha().Count();
            int tb = kq.getHocSinhTB().Count();
            int yeu = kq.getHocSinhYeu().Count();
            textBox1.Text = gioi.ToString();
            textBox2.Text = kha.ToString();
            textBox3.Text = tb.ToString();
            textBox4.Text = yeu.ToString();
            dataGridView1.DataSource = kq.getHocSinhGioi();
            dataGridView2.DataSource = kq.getHocSinhKha();
            dataGridView3.DataSource = kq.getHocSinhTB();
            dataGridView4.DataSource = kq.getHocSinhYeu();
        }
    }
}
