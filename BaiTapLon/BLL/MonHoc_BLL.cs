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
    public class MonHoc_BLL
    {
        public DataTable GetAllMonHoc()
        {
            List<MonHoc> list = new List<MonHoc>();
            string sql = "select * from MONHOC";
            DataTable dt = new DataTable();
            dt = SqlHelper.GetTable(sql);
            return dt;
        }
        public DataTable GetMon(string mamonhoc)
        {
            string sql = $"select * from monhoc where mamonhoc='{mamonhoc}'";
            DataTable dt = new DataTable();
            dt = SqlHelper.GetTable(sql);
            return dt;
        }
        public int Update(MonHoc monhoc)
        {
            string sql = $"update MONHOC set tenmonhoc=N'{monhoc.tenmonhoc}', magiaovien=N'{monhoc.magiaovien}', hocky={monhoc.hocky}, mota=N'{monhoc.mota}' where mamonhoc='{monhoc.mamonhoc}'";
            try
            {
                return SqlHelper.ExcuteNonQuery(sql, null);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        public int Insert(MonHoc monhoc)
        {
            string sql = $"insert into MONHOC(mamonhoc, tenmonhoc, magiaovien, hocky, mota) values" +
                $"(N'{monhoc.mamonhoc}', N'{monhoc.tenmonhoc}', N'{monhoc.magiaovien}'," +
                $" N'{monhoc.hocky}', N'{monhoc.mota}')";
            try
            {
                object result = SqlHelper.ExecuteScalar(sql, null);
                return Convert.ToInt32(result);
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(string mamonhoc)
        {
            List<string> sql = new List<string>();
            sql.Add($"delete MONHOC where mamonhoc='{mamonhoc}'");
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
