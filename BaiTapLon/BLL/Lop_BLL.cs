using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DAL;
using DTO;
namespace BLL
{
    public class Lop_BLL
    {
        public List<Lop> getAllClass()
        {
            List<Lop> lops = new List<Lop>();
            string sql = "select * from LOP";
            try
            {
                SqlDataReader objReader = SqlHelper.ExcuteReader(sql, null);
                while (objReader.Read())
                {
                    lops.Add(new Lop()
                    {
                        malop = objReader["malop"].ToString(),
                        tenlop = objReader["tenlop"].ToString(),
                        makhoi = objReader["makhoi"].ToString(),
                        mota = objReader["mota"].ToString(),
                    });

                }

                objReader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lops;
        }

        public List<Lop> GetLop(string malop)
        {
            List<Lop> lop = new List<Lop>();
            string sql = $"select * from LOP where malop='{malop}'";
            try
            {
                SqlDataReader objReader = SqlHelper.ExcuteReader(sql, null);
                while (objReader.Read())
                {
                    lop.Add( new Lop()
                    {
                        malop = objReader["malop"].ToString(),
                        tenlop = objReader["tenlop"].ToString(),
                        makhoi = objReader["makhoi"].ToString(),
                        mota = objReader["mota"].ToString(),
                    });

                }

                objReader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lop;
        }
        public List<Lop> GetLopWithKhoi(string makhoi)
        {

            List<Lop> lops = new List<Lop>();
            string sql = $"select * from LOP where makhoi='{makhoi}'";
            try
            {
                SqlDataReader objReader = SqlHelper.ExcuteReader(sql, null);
                while (objReader.Read())
                {
                    lops.Add(new Lop()
                    {
                        malop = objReader["malop"].ToString(),
                        tenlop = objReader["tenlop"].ToString(),
                        makhoi = objReader["makhoi"].ToString(),
                        mota = objReader["mota"].ToString(),
                    });

                }

                objReader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lops;
        }
        public string Insert(Lop lop)
        {
            string sql = $"insert into LOP(malop,tenlop,makhoi,mota) " +
                $"values(N'{lop.malop}'," +
                $"N'{lop.tenlop}'," +
                $"N'{lop.makhoi}'," +
                $"N'{lop.mota}');" +
                $"select malop from LOP where malop='{lop.malop}'";
            try
            {
                object result = SqlHelper.ExecuteScalar(sql, null);
                return Convert.ToString(result);
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
