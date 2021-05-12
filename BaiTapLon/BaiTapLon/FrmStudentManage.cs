using BLL;
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
               
                dgvStudentList.DataSource = null;
                dgvStudentList.DataSource = _studentService.GetStudentsByClassName(cboClass.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
        }

        private void btntimid_Click(object sender, EventArgs e)
        {
            if (txtStudentId.Text.Length == 0)
            {
                MessageBox.Show("Nhập mã học sinh");
                return;
            }
            try
            {
                this.dgvStudentList.DataSource = _studentService.GetStudentById(this.txtStudentId.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
