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
    public partial class FrmStudentManage : Form
    {
        private StudentClassService _studentClassService = new StudentClassService();
        private StudentService _studentService = new StudentService();


        public FrmStudentManage()
        {
            InitializeComponent();
            this.cboClass.DataSource = _studentClassService.getAllClass();
            this.cboClass.DisplayMember = "ClassName";
            this.cboClass.ValueMember = "ClassId";
            this.cboClass.SelectedIndex = -1;
            this.dgvStudentList.AutoGenerateColumns = false;
        }

        private void btntimclass_Click(object sender, EventArgs e)
        {
            if (cboClass.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn tên lớp");
                return;
            }
            try
            {
                List<Student> st = new List<Student>();
                st = _studentService.GetStudentsByClassName(cboClass.Text);
                dgvStudentList.DataSource = null;
                dgvStudentList.DataSource = st;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
        }

        private void btntimid_Click(object sender, EventArgs e)
        {
            string id = txtStudentId.Text;
            if (id.Length == 0)
            {
                MessageBox.Show("Nhập mã học sinh");
                return;
            }
            try
            {
                dgvStudentList.DataSource = null;
                this.dgvStudentList.DataSource = _studentService.GetStudentById(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi hệ thống !!!");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (this.dgvStudentList.Rows.Count == 0)
                return;
            DialogResult xoa = MessageBox.Show("Bạn có chắc muốn xóa học sinh này khỏi lớp ??","Xóa",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (xoa == DialogResult.OK)
            {
                try
                {
                    _studentService.delete(this.dgvStudentList.CurrentRow.Cells[0].Value.ToString());

                    List<Student> list = (List<Student>)dgvStudentList.DataSource;
                    list.RemoveAt(dgvStudentList.CurrentRow.Index);
                    dgvStudentList.DataSource = null;
                    dgvStudentList.DataSource = list;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("lỗi hệ thống !!!");
                }
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
            string id= this.dgvStudentList.CurrentRow.Cells[0].Value.ToString();
            Student student = _studentService.GetStudentsById(id);
            FrmEditStudent frmEditStudent = new FrmEditStudent(student, dgvStudentList.CurrentRow);
            frmEditStudent.Show();
        }

        private void dgvStudentList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentService studentService = new StudentService();
            string stuId = this.dgvStudentList.CurrentRow.Cells[0].Value.ToString();
            Console.WriteLine(stuId);
            Student student = null;

            student = studentService.GetStudentsById(stuId);
            FrmStudentInfo info = new FrmStudentInfo(student);

            info.Show();
        }
    }
}
