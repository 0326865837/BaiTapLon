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
    public class SubjectService
    {
        public List<Subjects> getAllSubjects()
        {
            List<Subjects> list = new List<Subjects>();
            string sql = "select * from Subjects";
            SqlDataReader reader = SqlHelper.ExcuteReader(sql, null);
            while (reader.Read())
            {
                list.Add(new Subjects()
                {
                    SubId = reader["SubId"].ToString(),
                    SubName = reader["SubName"].ToString()
                }); ;
            }
            reader.Close();
            return list;
        }
    }
}
