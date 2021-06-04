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
        public string Insert(GiaoVien giaovien)
        {
            string sql = $"insert into GIAOVIEN(magiaovien,tengiaovien,gioitinh,socmnd,sodienthoai,tobomon,mota) values" +
                $"(N'{giaovien.magiaovien}'," +
                $"N'{giaovien.tengiaovien}'," +
                $"N'{giaovien.gioitinh}'," +
                $"N'{giaovien.socmnd}'," +
                $"N'{giaovien.sodienthoai}'," +
                $"N'{giaovien.tobomon}'," +
                $"N'{giaovien.mota}'); select magiaovien from GIAOVIEN where magiaovien='{giaovien.magiaovien}'";
            try
            {
                object result = SqlHelper.ExecuteScalar(sql, null);
                return Convert.ToString(result);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        public List<GiaoVien> GetGiaoVienById(string magiaovien)
        {
            return GetGiaoVienByWhere($" magiaovien='{magiaovien}'");
        }
        public List<GiaoVien> GetGiaoViensByName(string tengiaovien)
        {
            return GetGiaoVienByWhere($" tengiaovien like  '%{tengiaovien}%'");
        }
        public List<GiaoVien> GetAll()
        {
            string sql = "select * from GIAOVIEN";
            List<GiaoVien> gv = new List<GiaoVien>();
            try
            {
                SqlDataReader objReader = SqlHelper.ExcuteReader(sql, null);
                while (objReader.Read()) { 
                    gv.Add(new GiaoVien()
                    {
                        magiaovien = objReader["magiaovien"].ToString(),
                        tengiaovien = objReader["tengiaovien"].ToString(),
                        gioitinh = objReader["gioitinh"].ToString(),
                        socmnd = objReader["socmnd"].ToString(),
                        sodienthoai = objReader["sodienthoai"].ToString(),
                        tobomon = objReader["tobomon"].ToString(),
                        mota = objReader["mota"].ToString(),
                    });
                }

                objReader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return gv;
        }

        private List<GiaoVien> GetGiaoVienByWhere(string whereStr = "")
        {
            List<GiaoVien> gv = new List<GiaoVien>();
            string sql = $"select * from GIAOVIEN" +
                $" where  " + whereStr;

            try
            {
                SqlDataReader objReader = SqlHelper.ExcuteReader(sql, null);
                while (objReader.Read())
                {
                    gv.Add(new GiaoVien()
                    {
                        magiaovien = objReader["magiaovien"].ToString(),
                        tengiaovien = objReader["tengiaovien"].ToString(),
                        gioitinh = objReader["gioitinh"].ToString(),
                        socmnd = objReader["socmnd"].ToString(),
                        sodienthoai = objReader["sodienthoai"].ToString(),
                        tobomon = objReader["tobomon"].ToString(),
                        mota = objReader["mota"].ToString(),
                    });
                }
                objReader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return gv;
        }

        public int Update(GiaoVien giaovien)
        {
            string sql = $"update GIAOVIEN set" +
                $" tengiaovien=N'{giaovien.tengiaovien}'," +
                $"gioitinh=N'{giaovien.gioitinh}'," +
                $"socmnd=N'{giaovien.socmnd}'," +
                $"sodienthoai=N'{giaovien.sodienthoai}'," +
                $"tobomon=N'{giaovien.tobomon}'," +
                $"mota=N'{giaovien.mota}' " +
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
