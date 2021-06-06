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
        public List<MonHoc> GetAllMonHoc()
        {
            List<MonHoc> list = new List<MonHoc>();
            string sql = "select * from MONHOC";
            try
            {
                SqlDataReader objReader = SqlHelper.ExcuteReader(sql, null);
                while(objReader.Read())
                {
                    list.Add(new MonHoc()
                    {
                        mamonhoc = objReader["mamonhoc"].ToString(),
                        tenmonhoc = objReader["tenmonhoc"].ToString(),
                        magiaovien = objReader["magiaovien"].ToString(),
                        hocky = Convert.ToInt32(objReader["hocky"]),
                        mota = objReader["mota"].ToString(),
                    });

                }

                objReader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }
        public List<MonHoc> GetMon(string mamonhoc)
        {
            List<MonHoc> mh = new List<MonHoc>();
            string sql = $"select * from MONHOC where mamonhoc = '{mamonhoc}'";
            try
            {
                SqlDataReader objReader = SqlHelper.ExcuteReader(sql, null);
                while (objReader.Read())
                {
                    mh.Add(new MonHoc()
                    {
                        mamonhoc = objReader["mamonhoc"].ToString(),
                        tenmonhoc = objReader["tenmonhoc"].ToString(),
                        magiaovien = objReader["magiaovien"].ToString(),
                        hocky = Convert.ToInt32(objReader["hocky"]),
                        mota = objReader["mota"].ToString(),
                    });

                }

                objReader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mh;
        }
        public List<MonHoc> GetMonWithGiaoVien(string magaiovien)
        {
            List<MonHoc> mh = new List<MonHoc>();
            string sql = $"select * from MONHOC where magiaovien = '{magaiovien}'";
            try
            {
                SqlDataReader objReader = SqlHelper.ExcuteReader(sql, null);
                while (objReader.Read())
                {
                    mh.Add(new MonHoc()
                    {
                        mamonhoc = objReader["mamonhoc"].ToString(),
                        tenmonhoc = objReader["tenmonhoc"].ToString(),
                        magiaovien = objReader["magiaovien"].ToString(),
                        hocky = Convert.ToInt32(objReader["hocky"]),
                        mota = objReader["mota"].ToString(),
                    });

                }

                objReader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mh;
        }
        public List<MonHoc> GetMonWithName(string tenmon)
        {
            List<MonHoc> mh = new List<MonHoc>();
            string sql = $"select * from MONHOC where tenmonhoc like '%{tenmon}%'";
            try
            {
                SqlDataReader objReader = SqlHelper.ExcuteReader(sql, null);
                while (objReader.Read())
                {
                    mh.Add(new MonHoc()
                    {
                        mamonhoc = objReader["mamonhoc"].ToString(),
                        tenmonhoc = objReader["tenmonhoc"].ToString(),
                        magiaovien = objReader["magiaovien"].ToString(),
                        hocky = Convert.ToInt32(objReader["hocky"]),
                        mota = objReader["mota"].ToString(),
                    });

                }

                objReader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mh;
        }
        public int Update(MonHoc monhoc)
        {
            string sql = $"update MONHOC set tenmonhoc=N'{monhoc.tenmonhoc}', " +
                $"magiaovien=N'{monhoc.magiaovien}'," +
                $" hocky={monhoc.hocky}, " +
                $"mota=N'{monhoc.mota}' where mamonhoc='{monhoc.mamonhoc}'";
            try
            {
                return SqlHelper.ExcuteNonQuery(sql, null);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        public string Insert(MonHoc monhoc)
        {
            string sql = $"insert into MONHOC(mamonhoc, tenmonhoc, magiaovien, hocky, mota) values" +
                $"(N'{monhoc.mamonhoc}', " +
                $"N'{monhoc.tenmonhoc}'," +
                $" N'{monhoc.magiaovien}'," +
                $" N'{monhoc.hocky}', " +
                $"N'{monhoc.mota}');" +
                $" select mamonhoc from MONHOC where mamonhoc = '{monhoc.mamonhoc}'";
            try
            {
                object result = SqlHelper.ExecuteScalar(sql, null);
                return Convert.ToString(result);
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
