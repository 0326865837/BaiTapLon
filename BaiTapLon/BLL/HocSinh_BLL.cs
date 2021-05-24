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
        MonHoc_BLL subjectService = new MonHoc_BLL();
        
       public int Insert(HocSinh hocsinh)
        {
            string sql = $"insert into Student" +
                $" (mahocsinh,tenhocsinh,ngaysinh,ngaynhaphoc,diachi,malop, gioitinh, mota) values(" +
                $"N'{hocsinh.mahocsinh}'," +
                $"N'{hocsinh.tenhocsinh}'," +
                $"N'{hocsinh.ngaysinh}'," +
                $"N'{hocsinh.ngaynhaphoc}'," +
                $"N'{hocsinh.diachi}'," +
                $"N'{hocsinh.malop}'," +
                $"N'{hocsinh.gioitinh}'," +
                $"N'{hocsinh.mota}'); select @@Identity";
            
            try
            {
                object result = SqlHelper.ExecuteScalar(sql);
                return Convert.ToInt32(result);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public List<HocSinh> GetStudentsByClassName(string malop)
        {
            return GetHocSinhsByWhere($" and malop='{malop}'");
        }
        public List<HocSinh> GetStudentsByNameDesc(string malop)
        {
            return GetStudentsByClassName(malop)
                .OrderByDescending(p => p.tenhocsinh).ToList();
        }
        public List<HocSinh> GetStudentsByIdDesc(string malop)
        {
            return GetStudentsByClassName(malop)
                .OrderByDescending(p => p.mahocsinh).ToList();
        }
        private List<HocSinh> GetHocSinhsByWhere(string whereStr = "")
        {
            List<HocSinh> students= new List<HocSinh>();                       
            string sql = $"select * from HOCSINH,LOP" +
                $" where HOCSINH.malop = LOP.malop " + whereStr;

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
            return GetHocSinhsByWhere($" and mahocsinh = '{mahocsinh}'");
        }

        public HocSinh GetStudentsById(string mahocsinh)
        {
            HocSinh hocsinh = new HocSinh();
            string sql = $"select * from HOCSINH,LOP where HOCSINH.malop= LOP.malop and mahocsinh = '{mahocsinh}'";
            try
            {
                SqlDataReader objReader = SqlHelper.ExcuteReader(sql, null);
                if (objReader.Read())
                {
                    hocsinh = new HocSinh()
                    {
                        mahocsinh = objReader["mahocsinh"].ToString(),
                        tenhocsinh = objReader["tenhocsinh"].ToString(),
                        gioitinh = objReader["gioitinh"].ToString(),
                        ngaysinh = Convert.ToDateTime(objReader["ngaysinh"]),
                        ngaynhaphoc = Convert.ToDateTime(objReader["ngaynhaphoc"]),
                        diachi = objReader["diachi"].ToString(),
                        malop = objReader["malop"].ToString(),
                        mota = objReader["mota"].ToString(),
                    };
                   
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
            string sql = $"update HOCSINH set tenhocsinh = '{hocsinh.tenhocsinh}'," +
                $" gioitinh = '{hocsinh.gioitinh}', " +
                $" ngaysinh = '{hocsinh.ngaysinh}' ," +
                $" ngaynhaphoc = '{hocsinh.ngaynhaphoc} '," +
                $" diachi = '{hocsinh.diachi}'," +
                $" malop = '{hocsinh.malop}'," +
                $" mota ='{hocsinh.mota}' " +
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
        public bool delete(string mahocsinh)
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
