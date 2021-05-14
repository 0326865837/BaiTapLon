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
    public class StudentService
    {
       public int Insert(Student objStudent)
        {
            string sql = $"insert into Student (StudentId,StudentName,Birthday,PhoneNumber,StudentAddress,ClassId, Gender, StuImage) values(" +
                $"N'{objStudent.StudentId}'," +
                $"N'{objStudent.StudentName}'," +
                $"N'{objStudent.Birthday}'," +
                $"N'{objStudent.PhoneNumber}'," +
                $"N'{objStudent.StudentAddress}'," +
                $"N'{objStudent.ClassId}'," +
                $"N'{objStudent.Gender}'," +
                $"N'{objStudent.StuImage}'); select @@Identity";

            try
            {
                object result = SqlHelper.ExecuteScalar(sql);
                return Convert.ToInt32(result);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public List<Student> GetStudentsByClassName(string className){
            List<Student> st = GetHocSinhsByWhere($" and ClassName='{className}'");

            return GetHocSinhsByWhere($" and ClassName='{className}'");
        }
        public List<Student> GetStudentsByNameDesc(string className)
        {
            return GetStudentsByClassName(className)
                .OrderByDescending(p => p.StudentName).ToList();
        }
        public List<Student> GetStudentsByIdDesc(string className)
        {
            return GetStudentsByClassName(className)
                .OrderByDescending(p => p.StudentId).ToList();
        }
        private List<Student> GetHocSinhsByWhere(string whereStr = "")
        {
            List<Student> students= new List<Student>();                       
            string sql = $"select StudentId, StudentName, Gender, PhoneNumber, Birthday, ClassName,StudentAddress from Class,Student" +
                $" where Student.ClassId = Class.ClassId " + whereStr;

            try
            {
                SqlDataReader objReader = SqlHelper.ExcuteReader(sql, null);
                while (objReader.Read())
                {
                    students.Add(new Student()
                    {
                        StudentId = objReader["StudentId"].ToString(),
                        StudentName = objReader["StudentName"].ToString(),
                        Gender = objReader["Gender"].ToString(),
                        PhoneNumber = objReader["PhoneNumber"].ToString(),
                        Birthday = Convert.ToDateTime(objReader["Birthday"]),
                        ClassName = objReader["ClassName"].ToString(),
                        StudentAddress = objReader["StudentAddress"].ToString()
                    });
                }
                objReader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
            return students;
        }


        public List<Student> GetStudentById(string StudentId)
        {
            return GetHocSinhsByWhere($" and StudentId = '{StudentId}'");
        }

        public Student GetStudentsById(string id)
        {
            Student student = new Student();
            string sql = $"select StudentId,StudentName,Gender,PhoneNumber,Birthday,Class.ClassId,Class.ClassName, StuImage,StudentAddress from Student,Class where Student.ClassId= Class.ClassId and StudentId = '{id}'";
            try
            {
                SqlDataReader objReader = SqlHelper.ExcuteReader(sql, null);
                if (objReader.Read())
                {
                    student = new Student()
                    {
                        StudentId = objReader["StudentId"].ToString(),
                        StudentName = objReader["StudentName"].ToString(),
                        Gender = objReader["Gender"].ToString(),
                        PhoneNumber = objReader["PhoneNumber"].ToString(),
                        Birthday = Convert.ToDateTime(objReader["Birthday"]),
                        ClassId = objReader["ClassId"].ToString(),
                        ClassName = objReader["ClassName"].ToString(),
                        StuImage = objReader["StuImage"].ToString(),
                        StudentAddress = objReader["StudentAddress"].ToString()
                    };
                   
                }
              
                objReader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return student;
        }

        public int Update(Student student)
        {
            string sql = $"update Student set StudentName = '{student.StudentName}'," +
                $" Gender = '{student.Gender}', " +
                $" Birthday = '{student.Birthday}' ," +
                $" PhoneNumber = '{student.PhoneNumber} '," +
                $" StudentAddress = '{student.StudentAddress}'," +
                $" ClassId = '{student.ClassId}'," +
                $" StuImage ='{student.StuImage}' " +
                $"where StudentId = '{student.StudentId}'";

           

            try
            {
                return SqlHelper.ExcuteNonQuery(sql, null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool delete(string id)
        {
            List<string> sql = new List<string>();
           // sql.Add($"delete ScoreList where mahs = {id}");
            sql.Add($"delete Student where StudentId = '{id}'");
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
