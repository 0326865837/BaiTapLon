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
    public class Lop_BLL
    {
        public DataTable getAllClass()
        {
            DataTable dt = new DataTable();
            string sql = "select * from LOP";
            dt = SqlHelper.GetTable(sql);
            return dt;
        }

        public DataTable GetLop(string malop)
        {
            DataTable dt = new DataTable();
            string sql = $"select * from LOP where malop='{malop}'";
            dt = SqlHelper.GetTable(sql);
            return dt;
        }
        public int Insert(Lop lop)
        {
            string sql = $"insert into LOP(malop,tenlop,makhoi,mota) " +
                $"values(N'{lop.malop}',N'{lop.tenlop}',N'{lop.makhoi}',N'{lop.mota}')";
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
            string sql = $"update LOP set tenlop=N'{lop.tenlop}',makhoi=N'{lop.makhoi}',mota=N'{lop.mota}' where malop='{lop.malop}'";
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
