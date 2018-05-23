using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace UWProjectQ3
{
    /// <summary>
    /// Summary description for SqlHelper
    /// </summary>
    public class SqlHelper
    {
        //
        // TODO: Add constructor logic here
        //
        private SqlConnection conn;
        public SqlHelper()
        {
            string str = ConfigurationManager.AppSettings["LocalConnectionString"];
            conn = new SqlConnection(str);
        }

        public string InsertLoginRequest(User u)
        {
            conn.Open();

            try
            {
                int result = 0;
                using (SqlCommand cmd = new SqlCommand(ConfigurationManager.AppSettings["LoginRequest"], conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", u.UserName);
                    cmd.Parameters.AddWithValue("@EmailAddress", u.Email);
                    cmd.Parameters.AddWithValue("@LoginName", u.UserLogin);
                    cmd.Parameters.AddWithValue("@NewOrReactivate", "New");
                    cmd.Parameters.AddWithValue("@ReasonForAccess", u.ReasonForRequestingUser);
                    cmd.Parameters.AddWithValue("@DateNeededBy", DateTime.Today.AddDays(10));

                    result = cmd.ExecuteNonQuery();
                }
                if (result < 0)
                    return "Something went wrong while saving your Login Request";
                else if (result > 0)
                    return "Login Request accepted. A Password will be sent to you once a staff member has manually gone over your request.";
                else
                    return "Its Suspicious what happened!!!";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving New Login Request.");
                throw ex;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
        public List<UWProjectQ3.Clss> GetAllClasses()
        {
            conn.Open();

            try
            {
                List<Clss> AllClasses = new List<Clss>();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM "+ ConfigurationManager.AppSettings["AllClasses"], conn))
                {
                    SqlDataReader sqlrdr = cmd.ExecuteReader();
                    while(sqlrdr.Read())
                    {
                        int a = (int)sqlrdr["ClassId"];
                        string b = sqlrdr["ClassName"].ToString();
                        DateTime c = (DateTime)sqlrdr["ClassDate"];
                        String d = sqlrdr["ClassDescription"].ToString();
                        Clss cl = new Clss(a, b, c, d);
                        AllClasses.Add(cl);
                        
                    }
                    
                }
                return AllClasses;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving all available classes.");
                throw (ex);
            }
            finally
            {
                conn.Close();
                //conn.Dispose();
            }
        }
        public void GetUserClasses(User u)
        {
            conn.Open();

            try
            {
                
                using (SqlCommand cmd = new SqlCommand(ConfigurationManager.AppSettings["GetStudentClass"], conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StudentId", u.StudentId);

                    SqlDataReader sqlrdr = cmd.ExecuteReader();
                    while (sqlrdr.Read())
                    {
                        int stuId = (int)sqlrdr["StudentId"];
                        string StuName = sqlrdr["StudentName"].ToString();
                        string StuEmail = sqlrdr["StudentEmail"].ToString();
                        int ClassId = (int)sqlrdr["ClassId"];
                        string ClassName = sqlrdr["ClassName"].ToString();
                        DateTime ClassDt = (DateTime)sqlrdr["ClassDate"];
                        string ClassDesc = sqlrdr["ClassDescription"].ToString();
                        Clss cl = new Clss(ClassId, ClassName, ClassDt, ClassDesc);
                        u.RegisteredClasses.Add(ClassId, cl);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving all available classes.");
                throw (ex);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
        public void GetStudentId(User u)
        {
            conn.Open();

            try
            {

                using (SqlCommand cmd = new SqlCommand(ConfigurationManager.AppSettings["GetLogin"], conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter outStudentId = new SqlParameter("@StudentId", System.Data.SqlDbType.Int);
                    outStudentId.Direction = System.Data.ParameterDirection.Output;

                    cmd.Parameters.AddWithValue("@StudentLogin", u.UserLogin);
                    cmd.Parameters.AddWithValue("@StudentPassword", u.Password);
                    cmd.Parameters.Add(outStudentId);
                    SqlDataReader result = cmd.ExecuteReader();
                    
                    if ((int)outStudentId.Value > 0)
                        u.StudentId = (int)outStudentId.Value;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving all available classes.");
                throw (ex);
            }
            finally
            {
                conn.Close();
                //conn.Dispose();
            }
        }
        public void RegisterForClass(User u, int ClassId)
        {
            conn.Open();

            try
            {

                using (SqlCommand cmd = new SqlCommand(ConfigurationManager.AppSettings["RegisterClassStudent"], conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StudentId", u.StudentId);
                    cmd.Parameters.AddWithValue("@ClassId", ClassId);
                    int result = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error registering for Class.");
                throw (ex);
            }
            finally
            {
                conn.Close();
                //conn.Dispose();
            }
        }
        public void UnRegisterForClass(User u, int ClassId)
        {
            conn.Open();

            try
            {

                using (SqlCommand cmd = new SqlCommand(ConfigurationManager.AppSettings["UnregisterClassStudent"], conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StudentId", u.StudentId);
                    cmd.Parameters.AddWithValue("@ClassId", ClassId);
                    int result = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error un registering for Class.");
                throw (ex);
            }
            finally
            {
                conn.Close();
                //conn.Dispose();
            }
        }
    }
}