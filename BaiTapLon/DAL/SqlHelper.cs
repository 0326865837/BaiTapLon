using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SqlHelper
    {
        private static readonly string sql_con= @"Data Source=DESKTOP-12DN8EK\SQLEXPRESS;Initial Catalog=QLHStieuhoc;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static SqlConnection connection = null;

        public static int ExcuteNonQuery(string sql, params SqlParameter[] parameters)
        {
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(sql_con);
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                throw new Exception("Lỗi truy cập cơ sở dữ liệu" + ex.Message);
            }
            finally
            {
                if (connection != null) connection.Close();
            }
        }

        public static SqlDataReader ExcuteReader(string sql, SqlParameter[] parameters)
        {
            connection = null;
            try
            {
                connection = new SqlConnection(sql_con);
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                if (parameters != null)
                    command.Parameters.AddRange(parameters);
                return command.ExecuteReader();
            }
            catch (Exception ex)
            {
                if (connection != null)
                    connection.Close();
                throw new Exception("Lỗi truy cập cơ sở dữ liệu! " + ex.Message);
            }
        }

        public static object ExecuteScalar(string sql, params SqlParameter[] parameters)
        {
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(sql_con);
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                if (parameters != null)
                    command.Parameters.AddRange(parameters);
                return command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi truy cập cơ sở dữ liệu!Chi tiết:" + ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
        public static bool ExecuteSQL(List<string> sqlList)
        {
            bool isSuccess = false;
            SqlConnection connection = null;
            SqlTransaction transaction = null;
            try
            {
                connection = new SqlConnection(sql_con);

                connection.Open();

                transaction = connection.BeginTransaction();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;

                command.Transaction = transaction;
                foreach (var sql in sqlList)
                {
                    command.CommandText = sql;
                    command.ExecuteNonQuery();
                }

                transaction.Commit();
                isSuccess = true;
            }
            catch (Exception ex)
            {

                transaction.Rollback();
                throw ex;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
            return isSuccess;
        }

        public static DataTable GetTable(string sql)
        {
            SqlConnection connection = null;
            DataTable dt = new DataTable();
            try
            {
                connection = new SqlConnection(sql_con);
                connection.Open();

                SqlDataAdapter da = new SqlDataAdapter(sql, connection);
                da.Fill(dt);
            }catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
            

            return dt;
        }
    }
}
