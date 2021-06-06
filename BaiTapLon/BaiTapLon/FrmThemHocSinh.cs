
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
    public partial class FrmThemHocSinh : Form
    {
        private Lop_BLL lop_bll = new Lop_BLL();
        private HocSinh_BLL hocSinh_bll = new HocSinh_BLL();
        private List<HocSinh> hocSinhs = new List<HocSinh>();
        private HocSinh hocSinh = new HocSinh();
        private List<MonHoc> listmon = new List<MonHoc>();
        private MonHoc_BLL monHoc_BLL = new MonHoc_BLL();
        private KetQuaHT ketQuaHT = new KetQuaHT();
        private KetQuaHT_BLL ketQuaHT_BLL = new KetQuaHT_BLL();
        public FrmThemHocSinh()
        {
            InitializeComponent();
            cblop.DataSource = lop_bll.getAllClass();
            cblop.ValueMember = "malop";
            cblop.DisplayMember = "tenlop";
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string thoten = txtten.Text;
            string tmahs = txtmahs.Text;
            string tdiachi = txtdiachi.Text;
            DateTime tngaysinh = dtpNgaySinh.Value;
            DateTime tngaynhaphoc = dateNhaphoc.Value;
            string tmota = rtMota.Text.Length > 0 ? rtMota.Text : " ";
            string tlop = cblop.SelectedValue.ToString();
            string tgioitinh = rdNam.Checked ? "Nam" : "Nữ";
            if (thoten.Length == 0 || tmahs.Length == 0 || tdiachi.Length == 0) MessageBox.Show("Vui lòng nhập đầy đủ thông tin học sinh");
            else
            {

                    hocSinh = new HocSinh()
                    {
                        tenhocsinh = thoten,
                        mahocsinh = tmahs,
                        diachi = tdiachi,
                        ngaysinh =tngaysinh,
                        ngaynhaphoc=tngaynhaphoc,
                        gioitinh = tgioitinh,
                        mota=tmota,
                        malop=tlop
                    };
                    string result = hocSinh_bll.Insert(hocSinh);
                    if (result.Length != 0)
                    {
                        hocSinhs.Add(hocSinh);
                        dgvStudentList.DataSource = null;
                        dgvStudentList.DataSource = hocSinhs;
                        MessageBox.Show("thêm thành công");

                        listmon = monHoc_BLL.GetAllMonHoc();
                        foreach (MonHoc m in listmon)
                        {
                            ketQuaHT = new KetQuaHT()
                            {
                                mahocsinh = hocSinh.mahocsinh,
                                tenhocsinh = hocSinh.tenhocsinh,
                                malop = hocSinh.malop,
                                mamonhoc = m.mamonhoc,
                            };
 
                            ketQuaHT_BLL.Insert(ketQuaHT);
                        }
                    }

            }
            

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtdiachi.Clear();
            txtmahs.Clear();
            txtten.Clear();
            dgvStudentList.Rows.Clear();
        }
    }
}
