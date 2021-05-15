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
    public partial class FrmEditScore : Form
    {
       
        SubjectService _subjectService = new SubjectService();
        ScoreService _scoreService = new ScoreService();

        string subId = "";
        string stuId = "";
        string hk = "";
        string mt = "";
        string m = "";
        public FrmEditScore(Score score)
        {
            InitializeComponent();
            cbSub.DataSource = _subjectService.getAllSubjects();
            cbSub.DisplayMember = "SubName";
            cbSub.ValueMember = "SubId";
            cbSub.SelectedValue = score.SubId;
            txtClass.Text = score.ClassName;
            txtStuName.Text = score.StudentName;
            txtStuId.Text = score.StudentId;

            txtktm.Text = score.ScoreMedium.ToString();
            txtkt1t.Text = score.ScoreOral.ToString();
            txtkthk.Text = score.ScoreSementer.ToString();

            stuId = txtStuId.Text;
        }

        private void cbSub_SelectedValueChanged(object sender, EventArgs e)
        {
             subId = cbSub.SelectedValue.ToString();
             hk = txtkthk.Text;
             mt = txtkt1t.Text;
             m = txtktm.Text;
        }
        private bool check_Score(string score)
        {
            float number = float.Parse(score);
            return true;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
        
            hk = txtkthk.Text;
            mt = txtkt1t.Text;
            m = txtktm.Text;
            if (hk.Length == 0 && mt.Length == 0 && m.Length == 0)
            {
                MessageBox.Show("Nhập điểm");
                return;
            }
            if (m.Length == 0)
            {
                m = "*";
            }
            if (mt.Length == 0)
            {
                mt = "*";
            }
            if (hk.Length == 0 )
            {
                hk = "*";
            }
            try
            {
                int result = _scoreService.editScore(m, mt, hk, stuId, subId);
                if (result > 0)
                {
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Erorr");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: "+ex);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

            subId = "";
            foreach (Control item in this.groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

        }
    }
}
