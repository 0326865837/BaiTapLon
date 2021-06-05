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
    public partial class FrmQuanLyHocSinh : Form
    {
        Lop_BLL lop_BLL = new Lop_BLL();
        HocSinh_BLL hocSinh_BLL = new HocSinh_BLL();
        List<HocSinh> hocSinhs = new List<HocSinh>();
        public FrmQuanLyHocSinh()
        {
            InitializeComponent();
            cblop.DataSource = lop_BLL.getAllClass();
            cblop.DisplayMember = "tenlop";
            cblop.ValueMember = "malop";

            dgvStudentList.DataSource = hocSinh_BLL.GetAll();
        }

        private void btntimclass_Click(object sender, EventArgs e)
        {
            string tmalop = cblop.SelectedValue.ToString();
            hocSinhs = null;
            try
            {
                hocSinhs = hocSinh_BLL.GetStudentsByClass(tmalop);
                dgvStudentList.DataSource = hocSinhs;
            }
            catch
            {
                MessageBox.Show("Không có sinh viên trong lớp");
            }
        }

        private void btntimid_Click(object sender, EventArgs e)
        {
            string tid = txtmahs.Text;
            hocSinhs = null;
            if(tid.Length == 0)
            {
                MessageBox.Show("Nhập mã học sinh");
                return;
            }

            try
            {
                hocSinhs = hocSinh_BLL.GetStudentById(tid);
                dgvStudentList.DataSource = hocSinhs;
            }
            catch
            {
                MessageBox.Show("Không tìm thấy");
            }
            
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (this.dgvStudentList.Rows.Count == 0)
                return;

            try
            {
                DialogResult xoa;
                xoa = MessageBox.Show("Xóa học sinh này ??", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (xoa == DialogResult.OK)
                {
                    hocSinh_BLL.Delete(this.dgvStudentList.CurrentRow.Cells[0].Value.ToString());
                    List<HocSinh> list = (List<HocSinh>)dgvStudentList.DataSource;
                    list.RemoveAt(dgvStudentList.CurrentRow.Index);
                    dgvStudentList.DataSource = null;
                    dgvStudentList.DataSource = list;
                }
            }
            catch 
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.dgvStudentList.Rows.Count == 0)
                return;
            string mahs = dgvStudentList.CurrentRow.Cells[0].Value.ToString();
            HocSinh hocSinh = hocSinh_BLL.GetStudentById(mahs)[0];
            FrmSuaHocSinh frm = new FrmSuaHocSinh(hocSinh, dgvStudentList.CurrentRow);

            frm.ShowDialog();

        }

        private void btntimtheoten_Click(object sender, EventArgs e)
        {
            string thoten = txttenhocsinh.Text;
            if (thoten.Length == 0)
            {
                MessageBox.Show("Nhập họ tên");
                return;
            }
            try
            {
                hocSinhs = hocSinh_BLL.GetHocSinhByName(thoten);
                dgvStudentList.DataSource = hocSinhs;
            }
            catch
            {
                MessageBox.Show("Không tìm thấy");
            }
        }

        private void dgvStudentList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmThongTinHocSinh info = new FrmThongTinHocSinh();

            info.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmThemHocSinh frm = new FrmThemHocSinh();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                hocSinhs = null;
                hocSinhs = hocSinh_BLL.GetAll();
                dgvStudentList.DataSource = hocSinhs;
            }
            catch
            {
                MessageBox.Show("Không tìm thấy");
            }
        }
    }
}
