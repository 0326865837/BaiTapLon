using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class TeacherService
    {
        SqlHelper da = new SqlHelper();
        public Teacher Login(Teacher giaovien)
        {
            Teacher gv = null;

            string sql = "select * from giaovien where taikhoan=@taikhoan and matkhau=@matkhau";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@taikhoan", giaovien.taikhoan),
                new SqlParameter("@matkhau", giaovien.matkhau)
            };
            try
            {
                SqlDataReader reader = SqlHelper.ExcuteReader(sql, parameters);
                if (reader.Read())
                {
                    gv = new Teacher()
                    {
                        taikhoan = reader["taikhoan"].ToString(),
                        matkhau = reader["matkhau"].ToString(),
                        tengv = reader["tengv"].ToString(),
                        magv = reader["magv"].ToString(),
                        quyen = reader["quyen"].ToString()
                    };
                  
                }
            }catch(Exception ex)
            {
                throw ex;
            }
            return gv;
            
        }

         public int UpdateAccout(string us, string pw, string name)
        {
            string sql = $"update giaovien set matkhau='{pw}', taikhoan='{us}', tengv='{name}' where taikhoan = '{us}'";
            try
            {
                return SqlHelper.ExcuteNonQuery(sql, null);
            }catch (Exception ex)
            {
                throw ex;
            }
        } 
    }
}
