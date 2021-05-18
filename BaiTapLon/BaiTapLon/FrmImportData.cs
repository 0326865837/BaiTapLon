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
    public partial class FrmImportData : Form
    {
        public FrmImportData()
        {
            InitializeComponent();
        }
        private static string strpath = "";
        List<Student> students = new List<Student>();
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Excel(*.xls)|*.xls";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                strpath = openFileDialog1.FileName;
                loadxls();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                StudentService studentService = new StudentService();
                foreach (Student student in students)
                {
                    studentService.Insert(student);
                }
                MessageBox.Show("Nhập dữ liệu thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadxls()
        {

            if (strpath != "")
            {
                try
                {
                    this.dgvStudentList.DataSource = null;
                    string strCon = " Provider = Microsoft.Jet.OLEDB.4.0 ; Data Source = " + strpath + " ;Extended Properties=Excel 8.0";
                    System.Data.OleDb.OleDbConnection myConn = new System.Data.OleDb.OleDbConnection(strCon);
                    string strCom = "SELECT * FROM [Sheet1$]";
                    System.Data.OleDb.OleDbDataAdapter myCommand = new System.Data.OleDb.OleDbDataAdapter(strCom, myConn);
                    System.Data.DataTable dt = new System.Data.DataTable();
                    myCommand.Fill(dt);
                    students.Clear();


                    students.Add(new Student()
                    {
                        StudentName = dt.Columns[0].ColumnName,
                        Gender = dt.Columns[1].ColumnName,
                        Birthday = Convert.ToDateTime(dt.Columns[2].ColumnName),
                        PhoneNumber = dt.Columns[4].ColumnName.Trim(),
                        StudentAddress = dt.Columns[5].ColumnName.Trim() == "" ? "" : dt.Columns[5].ColumnName.Trim(),
                        ClassId = dt.Columns[6].ToString(),
                        StuImage = "",
                    }); ;


                    foreach (DataRow item in dt.Rows)
                    {

                        students.Add(new Student()
                        {
                            StudentName = item[0].ToString(),
                            Gender = item[1].ToString(),
                            Birthday = Convert.ToDateTime(item[2].ToString()),
                            PhoneNumber = item[4].ToString().Trim(),
                            StudentAddress = item[5].ToString().Trim() == "" ? "" : item[5].ToString().Trim(),
                            ClassId = item[6].ToString(),
                            StuImage = "",
                        });

                    }
                    this.dgvStudentList.DataSource = students;


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi từ file excel：" + ex.Message);

                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn file excel");
            }

        }
    }
}
