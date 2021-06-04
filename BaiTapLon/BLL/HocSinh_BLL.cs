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
    public class HocSinh_BLL
    {
        MonHoc_BLL mon = new MonHoc_BLL();

       public string Insert(HocSinh hocsinh)
        {
            string sql = $"insert into HOCSINH" +
                $" (mahocsinh,tenhocsinh,ngaysinh,ngaynhaphoc,diachi,malop, gioitinh, mota) values(" +
                $"N'{hocsinh.mahocsinh}'," +
                $"N'{hocsinh.tenhocsinh}'," +
                $"N'{hocsinh.ngaysinh}'," +
                $"N'{hocsinh.ngaynhaphoc}'," +
                $"N'{hocsinh.diachi}'," +
                $"N'{hocsinh.malop}'," +
                $"N'{hocsinh.gioitinh}'," +
                $"N'{hocsinh.mota}'); select mahocsinh from HOCSINH where HOCSINH.mahocsinh='{hocsinh.mahocsinh}'";
            try
            {
                object result = SqlHelper.ExecuteScalar(sql);
                return Convert.ToString(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<HocSinh> GetStudentsByClass(string malop)
        {
            return GetHocSinhsByWhere($" malop='{malop}'");
        }
        public List<HocSinh> GetHocSinhByName(string hoten)
        {
            return GetHocSinhsByWhere($" tenhocsinh like  '%{hoten}%'");
        }
        private List<HocSinh> GetHocSinhsByWhere(string whereStr = "")
        {
            List<HocSinh> students= new List<HocSinh>();                       
            string sql = $"select * from HOCSINH" +
                $" where  " + whereStr;

            try
            {
                SqlDataReader objReader = SqlHelper.ExcuteReader(sql, null);
                while (objReader.Read())
                {
                    students.Add(new HocSinh()
                    {
                        mahocsinh = objReader["mahocsinh"].ToString(),
                        tenhocsinh = objReader["tenhocsinh"].ToString(),
                        gioitinh = objReader["gioitinh"].ToString(),
                        ngaysinh = Convert.ToDateTime(objReader["ngaysinh"]),
                        ngaynhaphoc = Convert.ToDateTime(objReader["ngaynhaphoc"]),
                        diachi = objReader["diachi"].ToString(),
                        malop = objReader["malop"].ToString(),
                        mota = objReader["mota"].ToString(),
                    });
                }
                objReader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
            return students;
        }

        public List<HocSinh> GetStudentById(string mahocsinh)
        {
            List<HocSinh> hocsinh = new List<HocSinh>();
            string sql = $"select * from HOCSINH where mahocsinh = '{mahocsinh}'";
            try
            {
                SqlDataReader objReader = SqlHelper.ExcuteReader(sql, null);
                if (objReader.Read())
                {
                    hocsinh.Add(new HocSinh()
                    {
                        mahocsinh = objReader["mahocsinh"].ToString(),
                        tenhocsinh = objReader["tenhocsinh"].ToString(),
                        gioitinh = objReader["gioitinh"].ToString(),
                        ngaysinh = Convert.ToDateTime(objReader["ngaysinh"]),
                        ngaynhaphoc = Convert.ToDateTime(objReader["ngaynhaphoc"]),
                        diachi = objReader["diachi"].ToString(),
                        malop = objReader["malop"].ToString(),
                        mota = objReader["mota"].ToString(),
                    });
                   
                }
              
                objReader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return hocsinh;
        }

        public int Update(HocSinh hocsinh)
        {
            string sql = $"update HOCSINH set tenhocsinh = N'{hocsinh.tenhocsinh}'," +
                $" gioitinh = N'{hocsinh.gioitinh}', " +
                $" ngaysinh = '{hocsinh.ngaysinh}' ," +
                $" ngaynhaphoc = '{hocsinh.ngaynhaphoc} '," +
                $" diachi = N'{hocsinh.diachi}'," +
                $" malop = '{hocsinh.malop}'," +
                $" mota = N'{hocsinh.mota}' " +
                $"where mahocsinh = '{hocsinh.mahocsinh}'";

            try
            {
                return SqlHelper.ExcuteNonQuery(sql, null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Delete(string mahocsinh)
        {
            List<string> sql = new List<string>();
            sql.Add($"delete HOCSINH where mahocsinh = '{mahocsinh}'");
            try
            {
                return SqlHelper.ExecuteSQL(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
