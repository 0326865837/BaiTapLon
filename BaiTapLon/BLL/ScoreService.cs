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

        public List<ScoreList> showScore()
        {
            scorelist.Clear();
            string sql = "select a.StudentId,a.StudentName,a.Gender,a.ClassId, b.ClassName,c.CSharp,c.SQLServerDB,a.PhoneNumber  from Student as a,StudentClass as b,ScoreList as c where a.StudentId=c.StudentId and a.ClassId=b.ClassId";

            SqlDataReader read = SqlHelper.ExcuteReader(sql, null);
            while (read.Read())
            {
                scorelist.Add(new ScoreList()
                {
                    StudentId = read[0].ToString(),
                    StudentName = read[1].ToString(),
                    Gender = read[2].ToString(),
                    ClassId = read[3].ToString(),
                    ClassName = read[4].ToString(),
                    CSharp = read[5].ToString(),
                    SQLServerDB = read[6].ToString(),
                    PhoneNumber = read[7].ToString(),
                });
            }
            read.Close();
            SqlHelper.connection.Close();
            return scorelist;
        }
        public List<ScoreList> showScorce(string className)
        {
            scorelist.Clear();
            string sql = $"select a.StudentId,a.StudentName,a.Gender,a.ClassId,b.ClassName,c.CSharp,c.SQLServerDB  from Students as a,StudentClass as b,Scorelist as c where a.StudentId=c.StudentId and a.ClassId=b.ClassId and b.ClassName='{className}'";

            SqlDataReader read = SqlHelper.ExcuteReader(sql, null);
            while (read.Read())
            {
                scorelist.Add(new ScoreList()
                {
                    StudentId = read[0].ToString(),
                    StudentName = read[1].ToString(),
                    Gender = read[2].ToString(),
                    ClassId = read[3].ToString(),
                    CSharp = read[5].ToString(),
                    SQLServerDB = read[6].ToString(),

                });
            }
            read.Close();
            SqlHelper.connection.Close();
            return scorelist;
        }

        public List<ScoreList> showScorce(string className, int score)
        {
            scorelist.Clear();
            string sql = $"select a.StudentId,a.StudentName,a.Gender,a.ClassId,b.ClassName,c.CSharp,c.SQLServerDB  from Students as a,StudentClass as b,ScoreList as c where a.StudentId=c.StudentId and a.ClassId=b.ClassId and b.ClassName='{className}' and c.CSharp>{score}";

            SqlDataReader read = SqlHelper.ExcuteReader(sql, null);
            while (read.Read())
            {
                scorelist.Add(new ScoreList()
                {
                    StudentId = read[0].ToString(),
                    StudentName = read[1].ToString(),
                    Gender = read[2].ToString(),
                    ClassId = read[3].ToString(),
                    CSharp = read[5].ToString(),
                    SQLServerDB = read[6].ToString(),

                });
            }
            read.Close();
            SqlHelper.connection.Close();
            return scorelist;
        }
        public List<string> showlack()
        {
            string sql = "select StudentName from Student where Student.StudentId in (select Student.StudentId from Student EXCEPT select ScoreList.StudentId from ScoreList)";
            SqlDataReader read = SqlHelper.ExcuteReader(sql, null);
            List<string> arrName = new List<string>();
            while (read.Read())
            {
                arrName.Add(read[0].ToString());
            }
            read.Close();
            SqlHelper.connection.Close();
            return arrName;
        }
        public List<string> showlack(string className)
        {
            string sql = $"select StudentName from Student where Student.StudentId in (select Student.StudentId from Student EXCEPT select ScoreList.StudentId from ScoreList) and Student.ClassId in (select ClassId from StudentClass where ClassName='" + className + "')";

            SqlDataReader read = SqlHelper.ExcuteReader(sql, null);
            List<string> arrName = new List<string>();
            while (read.Read())
            {
                arrName.Add(read[0].ToString());
            }
            read.Close();
            SqlHelper.connection.Close();
            return arrName;
        }
    }
}

