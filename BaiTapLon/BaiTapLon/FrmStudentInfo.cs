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
    public partial class FrmStudentInfo: Form
    {
        public FrmStudentInfo(Student _student)
        {
            InitializeComponent();
            lbStudentName.Text = _student.StudentName;
            lbStudentId.Text = _student.StudentId;
            lbGender.Text = _student.Gender.ToString();
            lbBirthDay.Text = _student.Birthday.ToString();
            lbClassName.Text = _student.ClassName;
            lbPhoneNumber.Text = _student.PhoneNumber;
            lbStudentAdress.Text = _student.StudentAddress;
            string filename = _student.StuImage;
            pictureBox1.Image =Image.FromFile(_student.StuImage);
            Console.WriteLine(filename);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
