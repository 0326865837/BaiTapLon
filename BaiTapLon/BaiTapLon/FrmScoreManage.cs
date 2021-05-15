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
            cboClass.SelectedIndex = -1;

            cboMon.DataSource = _subjectService.getAllSubjects();
            cboMon.DisplayMember = "SubName";
            cboMon.ValueMember = "SubId";
            cboMon.SelectedIndex = -1;
        }

      

        private void btnShowScoreClass_Click(object sender, EventArgs e)
        {
            string className = cboClass.Text;
            if (className.Length == 0)
            {
                MessageBox.Show("Chọn lớp");
                return;
            }
            try
            {
                dgvScoreList.DataSource = null;
                dgvScoreList.DataSource = _scoreService.showScorceWithClass(this.cboClass.SelectedValue.ToString());
            }
            catch
            {
                MessageBox.Show("Lỗi hệ thống");
            }
        }

        private void btnShowScoreSubject_Click(object sender, EventArgs e)
        {
            string subName = cboMon.Text;
            if (subName.Length == 0)
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

        private void btnShowScoreStuId_Click(object sender, EventArgs e)
        {
            string stuId = txtStudentId.Text;

            if (stuId.Length == 0)
            {
                MessageBox.Show("Nhập mã sinh viên");
                return;
            }
            try
            {
                dgvScoreList.DataSource = null;
                dgvScoreList.DataSource = _scoreService.showScoreWithStudent(stuId);
               
            }
            catch
            {
                MessageBox.Show("Lỗi hệ thống");
            }
        }

        private void dgvScoreList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            
            string stuId = this.dgvScoreList.Rows[r].Cells[0].Value.ToString();
            string subId = dgvScoreList.Rows[r].Cells[5].Value.ToString();
            Score score = new Score();

            score = _scoreService.getScore(subId,stuId);

            FrmEditScore info = new FrmEditScore(score);

            info.Show();
        }
    }
}
