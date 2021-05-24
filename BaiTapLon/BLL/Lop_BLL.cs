using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class Lop_BLL
    {
        public List<Lop> getAllClass()
        {
            List<Lop> list = new List<Lop>();
            string sql = "select * from LOP";
            try
            {
                SqlDataReader reader = SqlHelper.ExcuteReader(sql, null);
                while (reader.Read())
                {
                    list.Add(new Lop()
                    {
                        malop = reader["ClassId"].ToString(),
                        tenlop = reader["tenlop"].ToString(),
                        makhoi = reader["makhoi"].ToString(),
                        mota = reader["mota"].ToString(),
                    }); ;
                }
                reader.Close();
                return list;
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        public int Insert(Lop lop)
        {
            string sql = $"insert into LOP(malop,tenlop,makhoi,mota) values(malop='{lop.malop}',tenlop='{lop.tenlop}',makhoi='{lop.makhoi}',mota='{lop.mota}')";
            try
            {
                object result = SqlHelper.ExecuteScalar(sql, null);
                return Convert.ToInt32(result);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        public int Update(Lop lop)
        {
            string sql = $"update LOP set tenlop='{lop.tenlop}',makhoi='{lop.makhoi}',mota='{lop.mota}' where malop='{lop.malop}'";
            try
            {
                return SqlHelper.ExcuteNonQuery(sql, null);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        public bool Delete(string malop)
        {
            List<string> sql = new List<string>();
            sql.Add($"delete LOP where malop = '{malop}'");
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
