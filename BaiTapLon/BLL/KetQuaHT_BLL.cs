using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KetQuaHT_BLL
    {
        public List<KetQuaHT> showKetQuaHtWithClass(string malop)
        {
            List<KetQuaHT> scorelist = new List<KetQuaHT>();
            string sql = $"select * from KETQUAHT where malop='{malop}'";
            SqlDataReader read = SqlHelper.ExcuteReader(sql, null);
            while (read.Read())
            {
                scorelist.Add(new KetQuaHT()
                {
                    mahocsinh = read["mahocsinh"].ToString(),
                    tenhocsinh = read["tenhocsinh"].ToString(),
                    malop = read["malop"].ToString(),
                    mamonhoc = read["mamonhoc"].ToString(),
                    diemtb = float.Parse(read["diemtb"].ToString()),
                    diemthilan1 = float.Parse(read["diemthilan1"].ToString()),
                    diemthilan2 = float.Parse(read["diemthilan2"].ToString()),
                    diemtongket = float.Parse(read["diemtongket"].ToString()),
                    hanhkiem = read["hanhkiem"].ToString(),
                    hocky =Convert.ToInt32(read["hocky"]),
                    mota = read["mota"].ToString(),
                });
            }
            read.Close();

            return scorelist;
        }

        public List<KetQuaHT> showKetQuaHtWithMonHoc(string mamon)
        {
            List<KetQuaHT> scorelist = new List<KetQuaHT>();

            string sql = $"select * from KETQUAHT where  mamon = '{mamon}'";
            SqlDataReader read = SqlHelper.ExcuteReader(sql, null);
            while (read.Read())
            {
                scorelist.Add(new KetQuaHT()
                {
                    mahocsinh = read["mahocsinh"].ToString(),
                    tenhocsinh = read["tenhocsinh"].ToString(),
                    malop = read["malop"].ToString(),
                    mamonhoc = read["mamonhoc"].ToString(),
                    diemtb = float.Parse(read["diemtb"].ToString()),
                    diemthilan1 = float.Parse(read["diemthilan1"].ToString()),
                    diemthilan2 = float.Parse(read["diemthilan2"].ToString()),
                    diemtongket = float.Parse(read["diemtongket"].ToString()),
                    hanhkiem = read["hanhkiem"].ToString(),
                    hocky = Convert.ToInt32(read["hocky"]),
                    mota = read["mota"].ToString(),
                });

            }
            read.Close();

            return scorelist;
        }
        public List<KetQuaHT> showKetQuaHtWithHocSinh(string mahocsinh)
        {
            List<KetQuaHT> scorelist = new List<KetQuaHT>();
            string sql = $"select * from KETQUAHT where mahocsinh = '{mahocsinh}'";
            SqlDataReader read = SqlHelper.ExcuteReader(sql, null);
            while(read.Read())
            {  scorelist.Add ( new KetQuaHT()
                {
                mahocsinh = read["mahocsinh"].ToString(),
                tenhocsinh = read["tenhocsinh"].ToString(),
                malop = read["malop"].ToString(),
                mamonhoc = read["mamonhoc"].ToString(),
                diemtb = float.Parse(read["diemtb"].ToString()),
                diemthilan1 = float.Parse(read["diemthilan1"].ToString()),
                diemthilan2 = float.Parse(read["diemthilan2"].ToString()),
                diemtongket = float.Parse(read["diemtongket"].ToString()),
                hanhkiem = read["hanhkiem"].ToString(),
                hocky = Convert.ToInt32(read["hocky"]),
                mota = read["mota"].ToString(),
            });
            }
            read.Close(); 
            return scorelist;
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

    }
}

