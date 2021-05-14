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
    public partial class FrmScoreManage : Form
    {
        StudentClassService _studentClassService = new StudentClassService();
        SubjectService _subjectService = new SubjectService();
        ScoreService _scoreService = new ScoreService();
        public FrmScoreManage()
        {
            InitializeComponent();
            cboClass.DataSource = _studentClassService.getAllClass();
            cboClass.DisplayMember = "ClassName";
            cboClass.ValueMember = "ClassId";

            cboMon.DataSource = _subjectService.getAllSubjects();
            cboMon.DisplayMember = "SubName";
            cboMon.ValueMember = "SubId";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string className = cboClass.Text;
            if(className.Length == 0)
            {
                MessageBox.Show("Chọn lớp");
                return;
            }
            try
            {
                dgvScoreList.DataSource = null;
                dgvScoreList.DataSource = _scoreService.showScorceWithClass(cboClass.SelectedValue.ToString());
            }
            catch
            {
                MessageBox.Show("Lỗi hệ thống");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string subName = cboMon.Text;
            if(subName.Length == 0)
            {
                MessageBox.Show("Chọn môn học");
                return;
            }
            try
            {
                dgvScoreList.DataSource = null;
                dgvScoreList.DataSource = _scoreService.showScorceWithSubject(cboMon.SelectedValue.ToString());
            }
            catch
            {
                MessageBox.Show("Lỗi hệ thống");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
