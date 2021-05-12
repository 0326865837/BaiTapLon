using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class StudentClassService
    {
        public List<StudentClass> getAllClass()
        {
            List<StudentClass> list = new List<StudentClass>();
            string sql = "select * from Class";
            SqlDataReader reader = SqlHelper.ExcuteReader(sql, null);
            while (reader.Read())
            {
                list.Add(new StudentClass()
                {
                    ClassId = reader["ClassId"].ToString(),
                    ClassName =reader["ClassName"].ToString()
                }); ;
            }
            reader.Close();
            return list;
        }
    }
}
