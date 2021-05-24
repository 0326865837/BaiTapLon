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
    public class MonHoc_BLL
    {
        public List<MonHoc> GetAllMonHoc()
        {
            List<MonHoc> list = new List<MonHoc>();
            string sql = "select * from MONHOC";
            try
            {
                SqlDataReader reader = SqlHelper.ExcuteReader(sql, null);
                while (reader.Read())
                {
                    list.Add(new MonHoc()
                    {
                        mamonhoc = reader["mamonhoc"].ToString(),
                        tenmonhoc = reader["tenmonhoc"].ToString(),
                        magiaovien = reader["magiaovien"].ToString(),
                        hocky = Convert.ToInt32(reader["hocky"]),
                        mota = reader["mota"].ToString()
                    }); ;
                }
                reader.Close();
            }catch(Exception ex)
            {
                throw ex;
            }
            return list;
        }
        public MonHoc GetMon(string mamonhoc)
        {
            MonHoc monhoc = new MonHoc();
            string sql = $"select * from monhoc where mamonhoc='{mamonhoc}'";
            try
            {
                SqlDataReader result = SqlHelper.ExcuteReader(sql, null);
                if (result.Read())
                {
                    monhoc = new MonHoc()
                    {
                        mamonhoc = result["mamonhoc"].ToString(),
                        tenmonhoc = result["tenmonhoc"].ToString(),
                        magiaovien = result["magiaovien"].ToString(),
                        hocky = Convert.ToInt32(result["hocky"]),
                        mota = result["mota"].ToString()
                    };
                }
                result.Close();

            }catch(Exception ex)
            {
                throw ex;
            }
            return monhoc;
        }
        public int Update(MonHoc monhoc)
        {
            string sql = $"update MONHOC set tenmonhoc='{monhoc.tenmonhoc}', magiaovien='{monhoc.magiaovien}', hocky='{monhoc.hocky}', mota='{monhoc.mota}' where mamonhoc='{monhoc.mamonhoc}'";
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
                $"('{monhoc.mamonhoc}', tenmonhoc='{monhoc.tenmonhoc}', magiaovien='{monhoc.magiaovien}'," +
                $" hocky='{monhoc.hocky}', mota='{monhoc.mota}')";
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
