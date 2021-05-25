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
    public class GiaoVien_BLL
    {
        public int Insert(GiaoVien giaovien)
        {
            string sql = $"insert into GIAOVIEN(magiaovien,tengiaovien,gioitinh,socmnd,sodienthoai,tobomon,mota) values" +
                $"(N'{giaovien.magiaovien}',N'{giaovien.tengiaovien}',N'{giaovien.gioitinh}'," +
                $"N'{giaovien.socmnd}',N'{giaovien.sodienthoai}',N'{giaovien.tobomon}',N'{giaovien.mota}' )";
            try
            {
                object result = SqlHelper.ExecuteScalar(sql, null);
                return Convert.ToInt32(result);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetGiaoVienById(string magiaovien)
        {
            DataTable dt = new DataTable();
            string sql = $"select * from GIAOVIEN where magiaovien='{magiaovien}'";
            dt = SqlHelper.GetTable(sql);
            return dt;
        }
        public DataTable GetGiaoViensByName(string tengiaovien)
        {
            DataTable dt = new DataTable();
            string sql = $"select * from GIAOVIEN where tengiaovien like '{tengiaovien}%'";
            dt = SqlHelper.GetTable(sql);
            return dt;
        }
        public DataTable GetAll()
        {
            DataTable dt = new DataTable();
            string sql = "select * from GIAOVIEN";
            dt = SqlHelper.GetTable(sql);
            return dt;
        }
        public int Update(GiaoVien giaovien)
        {
            string sql = $"update GIAOVIEN set tengiaovien=N'{giaovien.tengiaovien}',gioitinh=N'{giaovien.gioitinh}'," +
                $"socmnd=N'{giaovien.socmnd}',sodienthoai=N'{giaovien.sodienthoai}',tobomon=N'{giaovien.tobomon}',mota=N'{giaovien.mota}' " +
                $"where magiaovien = '{giaovien.magiaovien}'";
            try
            {
                return SqlHelper.ExcuteNonQuery(sql, null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(string magiaovien)
        {
            List<string> sql = new List<string>();
             sql.Add( $"delete GIAOVIEN where magiaovien='{magiaovien}'");
            try {
                return SqlHelper.ExecuteSQL(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
