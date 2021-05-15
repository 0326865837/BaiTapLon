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
        List<Score> scorelist = new List<Score>();

    
        public List<Score> showScorceWithClass(string classId)
        {
            scorelist.Clear();
            string sql = $"select* from ScoreList inner join Student on Student.StudentId = ScoreList.StudentId inner join Subjects on ScoreList.SubId = Subjects.SubId where ClassId = '{classId}'";
            SqlDataReader read = SqlHelper.ExcuteReader(sql, null);
            while (read.Read())
            {
                scorelist.Add(new Score()
                {
                    StudentId = read["StudentId"].ToString(),
                    StudentName = read["StudentName"].ToString(),
                    ClassId = read["ClassId"].ToString(),
                    ScoreMedium = read["ScoreMedium"].ToString(),
                    ScoreOral =read["ScoreOral"].ToString(),
                    ScoreSementer =read["ScoreSementer"].ToString(),
                    SubId = read["SubId"].ToString(),
                    SubName = read["SubName"].ToString()
                });

                // add ClassName to database and edit on StudentClass and Student
            }
            read.Close();
            SqlHelper.connection.Close();
            return scorelist;
        }

        public List<Score> showScorceWithSubject(string subId)
        {
            scorelist.Clear();
            string sql = $"select * " +
                $"from ScoreList inner join Student on Student.StudentId = ScoreList.StudentId" +
                $" inner join Subjects on ScoreList.SubId = Subjects.SubId" +
                $" where Subjects.SubId = '{subId}'";
            SqlDataReader read = SqlHelper.ExcuteReader(sql, null);
            while (read.Read())
            {
                scorelist.Add(new Score()
                {
                    StudentId = read["StudentId"].ToString(),
                    StudentName = read["StudentName"].ToString(),
                    ClassId = read["ClassId"].ToString(),
                    ScoreMedium =read["ScoreMedium"].ToString(),
                    ScoreOral = read["ScoreOral"].ToString(),
                    ScoreSementer = read["ScoreSementer"].ToString(),
                    SubId = read["SubId"].ToString(),
                    SubName = read["SubName"].ToString()
                });

                // add ClassName to database and edit on StudentClass and Student
            }
            read.Close();
            SqlHelper.connection.Close();
            return scorelist;
        }
        public List<Score> showScoreWithStudent(string stuId)
        {
            scorelist.Clear();
            string sql = $"select * " +
                $"from ScoreList inner join Student on Student.StudentId = ScoreList.StudentId" +
                $" inner join Subjects on ScoreList.SubId = Subjects.SubId" +
                $" where Student.StudentId = '{stuId}'";
            SqlDataReader read = SqlHelper.ExcuteReader(sql, null);
            while(read.Read())
            {  scorelist.Add ( new Score()
                {
                    StudentId = read["StudentId"].ToString(),
                    StudentName = read["StudentName"].ToString(),
                    ClassId = read["ClassId"].ToString(),
                    ScoreMedium = read["ScoreMedium"].ToString(),
                    ScoreOral = read["ScoreOral"].ToString(),
                    ScoreSementer = read["ScoreSementer"].ToString(),
                    SubId = read["SubId"].ToString(),
                    SubName = read["SubName"].ToString()
                });
            }
            read.Close();
                // add ClassName to database and edit on StudentClass and Student
            return scorelist;
        }

        public Score getScore(string subId, string stuId)
        {
            string sql = $"select *  from ScoreList" +
                $" inner join Student on Student.StudentId = ScoreList.StudentId" +
                $" inner join Subjects on ScoreList.SubId = Subjects.SubId" +
                $" inner join Class on Class.ClassId = Student.ClassId" +
                $" where Subjects.SubId = '{subId}' and Student.StudentId = '{stuId}'";
            Score score = new Score();
            
            try
            {
                SqlDataReader objReader = SqlHelper.ExcuteReader(sql, null);
                if (objReader.Read())
                {
                    score = new Score()
                    {
                        StudentId = objReader["StudentId"].ToString(),
                        StudentName = objReader["StudentName"].ToString(),
                        ScoreMedium = objReader["ScoreMedium"].ToString(),
                        ScoreOral = objReader["ScoreOral"].ToString(),
                        ScoreSementer = objReader["ScoreSementer"].ToString(),
                        SubId = objReader["SubId"].ToString(),
                        SubName = objReader["SubName"].ToString()
                    };
                }
                objReader.Close();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return score;
        }

        public int editScore(string ScoreOral, string ScoreMedium,  string ScoreSementer, string StudentId, string SubId)
        {

            string sql = $"update ScoreList set ScoreSementer='{ScoreSementer}'," +
                $" ScoreOral='{ScoreOral}'," +
                $"ScoreMedium='{ScoreMedium}'  where StudentId = '{StudentId}' and SubId='{SubId}'";
            try
            {
               
                return SqlHelper.ExcuteNonQuery(sql, null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}

