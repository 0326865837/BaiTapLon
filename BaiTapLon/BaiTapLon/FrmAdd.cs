
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
        private Lop_BLL _studentClassService = new Lop_BLL();
        private HocSinh_BLL _studentService = new HocSinh_BLL();
        private List<HocSinh> _students = new List<HocSinh>();


        public FrmAdd()
        {
            InitializeComponent();
            
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnimg_Click(object sender, EventArgs e)
        {
          
            
        }

        private void FrmAdd_Load(object sender, EventArgs e)
        {
            
        }
    }
}
