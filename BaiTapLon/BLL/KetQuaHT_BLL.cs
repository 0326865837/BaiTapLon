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
        public List<KetQuaHT> showKetQuaHtWithHocSinh(string mahocsinh, string mamon)
        {
            string sql = $"select * from KETQUAHT where mahocsinh = '{mahocsinh}' and mamonhoc='{mamon}'";
            List<KetQuaHT> kq = new List<KetQuaHT>();

            try
            {
                SqlDataReader objReader = SqlHelper.ExcuteReader(sql, null);
                while (objReader.Read())
                {
                    kq.Add(new KetQuaHT()
                    {
                        mahocsinh = objReader["mahocsinh"].ToString(),
                        tenhocsinh = objReader["tenhocsinh"].ToString(),
                        diemtb = objReader["diemtb"].ToString(),
                        diemthilan1 = objReader["diemthilan1"].ToString(),
                        diemthilan2=objReader["diemthilan2"].ToString(),
                        diemtongket = objReader["diemtongket"].ToString(),
                        hanhkiem=objReader["hankiem"].ToString(),
                        hocky=objReader["hocky"].ToString(),
                        malop=objReader["malop"].ToString(),
                        mamonhoc=objReader["mamonhoc"].ToString(),
                        mota=objReader["mota"].ToString()
                    });
                }
                objReader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }


            return kq;
        }
        public DataTable showKetquaWithLopVaMon(string malop, string mamon)
        {
            string sql = $"select * from KETQUAHT where malop = '{malop}' and mamonhoc='{mamon}'";
            DataTable dt = new DataTable();
            dt = SqlHelper.GetTable(sql);
            return dt;
        }
        public int Update(KetQuaHT kq )
        {

            string sql = $"update  KETQUAHT set diemtb={kq.diemtb}, " +
                $" diemthilan1={kq.diemthilan1}," +
                $" diemthilan2={kq.diemthilan2}," +
                $" diemtongket={kq.diemtongket} , " +
                $" hankiem=N'{kq.hanhkiem}',mota=N'{kq.mota}'," +
                $"hocky={kq.hocky}"+
                $" where mahocsinh='{kq.mahocsinh}' and mamonhoc='{kq.mamonhoc}'";
            try
            {
                return SqlHelper.ExcuteNonQuery(sql, null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Insert(KetQuaHT kq)
        {
            string diemtb = kq.diemtb == null ? "null" : kq.diemtb;
            string diemthilan1 = kq.diemthilan1 == null ? "null" : kq.diemthilan1;
            string diemthilan2 = kq.diemthilan2 == null ? "null" : kq.diemthilan2;
            string diemtongket = kq.diemtongket == null ? "null" : kq.diemtongket;
            string hocky = kq.hocky == null ? "null" : kq.hocky;
            string sql = $"insert into  KETQUAHT(mahocsinh,tenhocsinh,malop,mamonhoc,diemtb,diemthilan1,diemthilan2,diemtongket,hankiem,hocky,mota) " +
                $"values(N'{kq.mahocsinh}'," +
                $"N'{kq.tenhocsinh}'," +
                $"N'{kq.malop}'," +
                $"N'{kq.mamonhoc}'," +
                $"{diemtb}," +
                $"{diemthilan1}," +
                $"{diemthilan2}," +
                $"{diemtongket}," +
                $"N'{kq.hanhkiem}'," +
                $"{hocky}," +
                $"N'{kq.mota}');";
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

