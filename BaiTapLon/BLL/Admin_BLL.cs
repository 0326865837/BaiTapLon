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
    public class Admin_BLL
    {
        public Admin Login(Admin admin)
        {
            Admin ad = null;
            string sql = $"select * from admin where username='{admin.username}' and password='{admin.password}'";
            try
            {
                SqlDataReader reader = SqlHelper.ExcuteReader(sql, null);
                if (reader.Read())
                {
                    ad = new Admin()
                    {
                        username = reader["username"].ToString(),
                        password = reader["password"].ToString()
                    };
                }
            }catch(Exception ex)
            {
                throw ex;
            }
            return ad;
        }
    }
}
