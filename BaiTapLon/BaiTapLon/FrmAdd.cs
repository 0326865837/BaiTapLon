using BaiTapLon.Common;
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
    public partial class FrmAdd : Form
    {
        private StudentClassService _studentClassService = new StudentClassService();
        private StudentService _studentService = new StudentService();
        private List<Student> _students = new List<Student>();


        public FrmAdd()
        {
            InitializeComponent();
            this.cblop.DataSource = _studentClassService.getAllClass();
            this.cblop.DisplayMember = "ClassName";
            this.cblop.ValueMember = "ClassId";
            if (this.cblop.Items.Count == 0)
            {
                this.cblop.SelectedItem = -1;
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string hoten = txtten.Text;
            string diachi = txtdiachi.Text;
            string mahs = txtmahs.Text;
            
            if (hoten.Length == 0)
            {
                MessageBox.Show("Họ tên không được trống");
                return;
            }
            else if (diachi.Length == 0)
            {
                MessageBox.Show("Địa chỉ không được trống");
                return;
            }
            else if (mahs.Length == 0) {
                MessageBox.Show("Mã học sinh không được trống");
                return;
            }
            else
            {    
                string filename = System.IO.Path.GetFileName(openFileDialog1.FileName);

                string newName="";
                if (filename.Length !=0)
                {
                    var random = new Random();
                    string rd = random.Next().ToString();

                    string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                    string olname = path + "\\Image\\" + filename;
                    newName = path + "\\Image\\" + rd + filename;
                    System.IO.File.Copy(openFileDialog1.FileName, olname);
                    System.IO.File.Move(olname, newName);
                }


                Student student = new Student()
                {
                    StudentName = this.txtten.Text.Trim(),
                    Gender = checknam.Checked ? "Nam" : "Nữ",
                    Birthday = Convert.ToDateTime(this.dtpBirthday.Text),
                    ClassId = this.cblop.SelectedValue.ToString(),
                    ClassName = this.cblop.Text,
                    StudentAddress = this.txtdiachi.Text.Trim(),
                    PhoneNumber = this.txtsdt.Text.Trim(),
                    StudentId = this.txtmahs.Text.Trim(),
                    StuImage = filename.Length != 0 ? newName :""
                };
                
                int result = _studentService.Insert(student);

                if (result > 1)
                {
                    _students.Add(student);
                    this.dgvStudentList.DataSource = null;
                    this.dgvStudentList.DataSource = _students;

                    DialogResult dResult = MessageBox.Show("Tiếp tục", "Thoát", MessageBoxButtons.YesNo);
                    if (dResult == DialogResult.Yes)
                    {
                        foreach(Control item in this.groupBox1.Controls)
                        {
                            if(item is TextBox){
                                item.Text = "";
                            }
                        }
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnimg_Click(object sender, EventArgs e)
        {
          
            openFileDialog1.InitialDirectory = "C://Desktop";
            openFileDialog1.Title = "Select image to be upload.";
            openFileDialog1.Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            openFileDialog1.FilterIndex = 1;
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openFileDialog1.CheckFileExists)
                    {
                        string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
                        label9.Text = path;
                        pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else
                {
                    MessageBox.Show("Please Upload image.");
                }
            }
            catch (Exception ex)
            {
                //it will give if file is already exits..
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmAdd_Load(object sender, EventArgs e)
        {
            
        }
    }
}
