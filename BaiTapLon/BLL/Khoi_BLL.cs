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
    public class Khoi_BLL
    {
        public List<Khoi> getAll()
        {
            List<Khoi> khois = new List<Khoi>();
            string sql = "select * from KHOILOP";
            try
            {
                SqlDataReader reader = SqlHelper.ExcuteReader(sql, null);
                while(reader.Read())
                {
                    khois.Add(new Khoi()
                    {
                        makhoi = reader["makhoi"].ToString(),
                        tenkhoi = reader["tenkhoi"].ToString(),
                        soluong = Convert.ToInt32(reader["soluong"])
                    });
                }
                reader.Close();
            }catch(Exception ex)
            {
                throw ex;
            }
            return khois;
        }
        public List<Khoi> getAllLopWithKhoi(string makhoi)
        {
            List<Khoi> khois = new List<Khoi>();
            string sql = $"select * from KHOILOP where makhoi='{makhoi}'";
            try
            {
                SqlDataReader reader = SqlHelper.ExcuteReader(sql, null);
                while (reader.Read())
                {
                    khois.Add(new Khoi()
                    {
                        makhoi = reader["makhoi"].ToString(),
                        tenkhoi = reader["tenkhoi"].ToString(),
                        soluong = Convert.ToInt32(reader["soluong"])
                    });
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return khois;
        }
    }
}
