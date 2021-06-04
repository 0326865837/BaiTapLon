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
    public partial class FrmQuanLyKetQuaHocTap : Form
    {
        Lop_BLL lop_BLL = new Lop_BLL();
        MonHoc_BLL mon_BLL = new MonHoc_BLL();
        KetQuaHT_BLL ketquahoctap_bll = new KetQuaHT_BLL();
        public FrmQuanLyKetQuaHocTap()
        {
            InitializeComponent();
            cbLop.DataSource = lop_BLL.getAllClass();
            cbLop.DisplayMember = "tenlop";
            cbLop.ValueMember = "malop";

            cbmon.DataSource = mon_BLL.GetAllMonHoc();
            cbmon.DisplayMember = "tenmonhoc";
            cbmon.ValueMember = "mamonhoc";
        }
        private void select(string malop, string mamon)
        {
            try
            {
                dataGridView1.DataSource = ketquahoctap_bll.showKetquaWithLopVaMon(malop, mamon);
            }
            catch
            {
                MessageBox.Show("Không tìm thấy kết quả");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string mamon = cbmon.SelectedValue.ToString();
            string malop = cbLop.SelectedValue.ToString();
            if (mamon.Length == 0 || malop.Length == 0)
            {
                MessageBox.Show("Cần chọn môn và lớp");
                return;
            }
            select(malop, mamon);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView1.Rows.Count == 0)
                return;
            string mahs = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string mamon = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            KetQuaHT kqht = ketquahoctap_bll.showKetQuaHtWithHocSinh(mahs,mamon)[0];
            Console.WriteLine(mahs +"  "+ mamon);
            FrmNhapKetQuaHT frm = new FrmNhapKetQuaHT(kqht);
            frm.ShowDialog();
        }
    }
}
