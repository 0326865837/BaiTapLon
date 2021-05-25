using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KetQuaHT_BLL
    {
        public DataTable showKetQuaHtWithClass(string malop)
        {
            string sql = $"select * from KETQUAHT where malop='{malop}'";
            DataTable dt = new DataTable();
            dt = SqlHelper.GetTable(sql);
            return dt;
        }
        public DataTable showKetQuaHtWithMonHoc(string mamonhoc)
        {
            string sql = $"select * from KETQUAHT where  mamonhoc = '{mamonhoc}'";
            DataTable dt = new DataTable();
            dt = SqlHelper.GetTable(sql);
            return dt;
        }
        public DataTable showKetQuaHtWithHocSinh(string mahocsinh)
        {
            string sql = $"select * from KETQUAHT where mahocsinh = '{mahocsinh}'";
            DataTable dt = new DataTable();
            dt = SqlHelper.GetTable(sql);
            return dt;
        }
        public int Update(KetQuaHT kq )
        {

            string sql = $"update  KETQUAHT set diemtb='{kq.diemtb}', diemthilan1='{kq.diemthilan1}'," +
                $" diemthilan2='{kq.diemthilan2}',diemtongket='{kq.diemtongket}' , " +
                $" hanhkiem='{kq.hanhkiem}',mota='{kq.mota}'" +
                $" where mahocsinh='{kq.mahocsinh}' and mamonhoc='{kq.mamonhoc}";
            try
            {
                return SqlHelper.ExcuteNonQuery(sql, null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Inser(KetQuaHT kq)
        {
            string sql = $"insert into  KETQUAHT(mahocsinh,tenhocsinh,malop,mamonhoc,diemtb,diemthilan1,diemthilan2,diemtongket,hankiem,hocky,mota) " +
                $"values(N'{kq.mahocsinh}',N'{kq.tenhocsinh}',N'{kq.malop}',N'{kq.mamonhoc}'," +
                $"{kq.diemtb},{kq.diemthilan1},{kq.diemthilan2},{kq.diemtongket}," +
                $"N'{kq.hanhkiem}',{kq.hocky},N'{kq.mota}')";
            try
            {
                return SqlHelper.ExcuteNonQuery(sql, null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}

