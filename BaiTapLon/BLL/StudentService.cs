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
                $"'{objStudent.StudentId}'," +
                $"'{objStudent.StudentName}'," +
                $"'{objStudent.Birthday}'," +
                $"'{objStudent.PhoneNumber}'," +
                $"'{objStudent.StudentAddress}'," +
                $"'{objStudent.ClassId}'," +
                $"'{objStudent.Gender}'," +
                $"'{objStudent.StuImage}'); select @@Identity";

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
            string sql = $"select StudentId, StudentName, Gender, PhoneNumber, Birthday, ClassName from Class,Student where Student.ClassId = Class.ClassId " + whereStr;

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
                        ClassName = objReader["ClassName"].ToString()
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
            return GetHocSinhsByWhere($" and StudentId = {StudentId}");
        }

        public Student GetStudentsById(string StudentId)
        {
            Student student = null;
            string sql = $"select StudentId,StudentName,Gender,PhoneNumber,Birthday,ClassId,StuImage,StudentAddress from Student,Class where Student.ClassId= Class.ClassId and StudentId = {StudentId}";
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


        public bool delete(int id)
        {
            List<string> sql = new List<string>();
           // sql.Add($"delete ScoreList where mahs = {id}");
            sql.Add($"delete hocsinh where StudentId = {id}");
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
