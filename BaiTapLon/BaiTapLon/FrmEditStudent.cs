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
    public partial class FrmEditStudent : Form
    {
        private Student _student;
        private StudentClassService _studentClassService = new StudentClassService();
        private StudentService studentService = new StudentService();


        string filename;
        public FrmEditStudent(Student student, DataGridViewRow currentRow)
        {
            InitializeComponent();
            _student = student;

            this.cboClassName.DataSource = _studentClassService.getAllClass();
            this.cboClassName.DisplayMember = "ClassName";
            this.cboClassName.ValueMember = "ClassId";
            this.cboClassName.SelectedIndex = -1;

            cboClassName.Text = _student.ClassName;
            txtStudentId.Text = _student.StudentId.ToString();
            txtStudentName.Text = _student.StudentName;
            txtPhoneNumber.Text = _student.PhoneNumber;
            txtAddress.Text = _student.StudentAddress;
            rdoFemale.Checked = _student.Gender == "Nữ";
            rdoMale.Checked = _student.Gender == "Nam";
            dtpBirthday.Text = _student.Birthday.ToShortDateString();
            filename = _student.StuImage;
           
            this.pbStu.Image = Image.FromFile(filename);
            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            
            Student student = new Student()
            {
                StudentName = this.txtStudentName.Text,
                Gender = this.rdoMale.Checked ? "Nam" : "Nữ",
                Birthday = Convert.ToDateTime(this.dtpBirthday.Text),
                PhoneNumber = this.txtPhoneNumber.Text,
                StudentAddress = this.txtAddress.Text,
                ClassName = this.cboClassName.Text,
                ClassId = this.cboClassName.SelectedValue.ToString(),
                StuImage = filename,
                StudentId = txtStudentId.Text,
            };

            try
            {
              
                DialogResult dResult = MessageBox.Show("Tiếp tục", "Thoát", MessageBoxButtons.YesNo);
                if (dResult == DialogResult.Yes)
                {
                    int result = studentService.Update(student);
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
