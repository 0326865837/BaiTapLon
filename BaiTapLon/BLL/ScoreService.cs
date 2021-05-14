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
    public class ScoreService
    {
        List<ScoreList> scorelist = new List<ScoreList>();

    
        public List<ScoreList> showScorceWithClass(string classId)
        {
            scorelist.Clear();
            string sql = $"select * " +
                $"from ScoreList inner join Student on Student.StudentId = ScoreList.StudentId" +
                $" inner join Subjects on ScoreList.SubId = Subjects.SubId" +
                $" where ClassId = '{classId}'";
            SqlDataReader read = SqlHelper.ExcuteReader(sql, null);
            while (read.Read())
            {
                scorelist.Add(new ScoreList()
                {
                    StudentId = read["StudentId"].ToString(),
                    StudentName = read["StudentName"].ToString(),
                    ClassId = read["ClassId"].ToString(),
                    
                    Score =Convert.ToInt32(read["Score"]),
                    SubId = read["SubId"].ToString(),
                    SubName = read["SubName"].ToString()
                });

                // add ClassName to database and edit on StudentClass and Student
            }
            read.Close();
            SqlHelper.connection.Close();
            return scorelist;
        }

        public List<ScoreList> showScorceWithSubject(string subId)
        {
            scorelist.Clear();
            string sql = $"select * " +
                $"from ScoreList inner join Student on Student.StudentId = ScoreList.StudentId" +
                $" inner join Subjects on ScoreList.SubId = Subjects.SubId" +
                $" where Subjects.SubId = '{subId}'";
            SqlDataReader read = SqlHelper.ExcuteReader(sql, null);
            while (read.Read())
            {
                scorelist.Add(new ScoreList()
                {
                    StudentId = read["StudentId"].ToString(),
                    StudentName = read["StudentName"].ToString(),
                    ClassId = read["ClassId"].ToString(),
                    Score = Convert.ToInt32(read["Score"]),
                    SubId = read["SubId"].ToString(),
                    SubName = read["SubName"].ToString()
                });

                // add ClassName to database and edit on StudentClass and Student
            }
            read.Close();
            SqlHelper.connection.Close();
            return scorelist;
        }


    }
}

