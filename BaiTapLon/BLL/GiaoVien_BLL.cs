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
                $"('{giaovien.magiaovien}','{giaovien.tengiaovien}','{giaovien.gioitinh}'," +
                $"'{giaovien.socmnd}','{giaovien.sodienthoai}','{giaovien.tobomon}','{giaovien.mota}' )";
            try
            {
                object result = SqlHelper.ExecuteScalar(sql, null);
                return Convert.ToInt32(result);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        public GiaoVien GetGiaoVienById(string magiaovien)
        {
            GiaoVien giaovien = new GiaoVien();
            string sql = $"select * from GIAOVIEN where magiaovien='{magiaovien}'";
            try
            {
                SqlDataReader result = SqlHelper.ExcuteReader(sql, null);
                if (result.Read()) {
                    giaovien = new GiaoVien()
                    {
                        magiaovien = result["magiaovien"].ToString(),
                        tengiaovien=result["tengiaovien"].ToString(),
                        gioitinh = result["gioitinh"].ToString(),
                        socmnd =result["socmnd"].ToString(),
                        sodienthoai=result["sodienthoai"].ToString(),
                        tobomon=result["tobomon"].ToString(),
                        mota=result["mota"].ToString()
                    };
                }
                result.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return giaovien;
        }
        public List<GiaoVien> GetGiaoViensByName(string tengiaovien)
        {
            List<GiaoVien> giaoviens = new List<GiaoVien>();
            string sql = $"select * from GIAOVIEN where tengiaovien like '{tengiaovien}%'";
            try
            {
                SqlDataReader result = SqlHelper.ExcuteReader(sql, null);
                if (result.Read())
                {
                    while (result.Read())
                    {
                        giaoviens.Add(new GiaoVien()
                        {
                            magiaovien = result["magiaovien"].ToString(),
                            tengiaovien = result["tengiaovien"].ToString(),
                            gioitinh = result["gioitinh"].ToString(),
                            socmnd = result["socmnd"].ToString(),
                            sodienthoai = result["sodienthoai"].ToString(),
                            tobomon = result["tobomon"].ToString(),
                            mota = result["mota"].ToString()
                        });
                    }
                }
                result.Close();
            }catch(Exception ex)
            {
                throw ex;
            }
            return giaoviens;
        }
        public List<GiaoVien> GetAll()
        {
            string sql = "select * from GIAOVIEN";
            List<GiaoVien> list = new List<GiaoVien>();
            try
            {
                SqlDataReader result = SqlHelper.ExcuteReader(sql, null);
                if (result.Read())
                {
                    while (result.Read())
                    {
                        list.Add(new GiaoVien()
                        {
                            magiaovien = result["magiaovien"].ToString(),
                            tengiaovien = result["tengiaovien"].ToString(),
                            gioitinh = result["gioitinh"].ToString(),
                            socmnd = result["socmnd"].ToString(),
                            sodienthoai = result["sodienthoai"].ToString(),
                            tobomon = result["tobomon"].ToString(),
                            mota = result["mota"].ToString()
                        });
                    }
                }
                result.Close();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return list;
        }
        public int Update(GiaoVien giaovien)
        {
            string sql = $"update GIAOVIEN set tengiaovien='{giaovien.tengiaovien}',gioitinh='{giaovien.gioitinh}'," +
                $"socmnd='{giaovien.socmnd}',sodienthoai='{giaovien.sodienthoai}',tobomon='{giaovien.tobomon}',mota='{giaovien.mota}' " +
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
