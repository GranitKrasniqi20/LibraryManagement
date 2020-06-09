using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenaxhimiBibliotekes.BO;
using MenaxhimiBibliotekes.BO.Interfaces;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MenaxhimiBibliotekes.DAL
{
    public class UserDAL : ICreate<User>, IUpdate<User>, IDelete, IRead<User>, IConvertToBO<User>, IChangePassword
    {
        User usr = new User();


        public User LogIn(string username, string password)
        {
            usr = new User();
            try
            {

                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    using (SqlCommand command = DbHelper.Command(conn, "usp_LogIn", CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("@UserName", username);
                        command.Parameters.AddWithValue("@Password", password);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {//logfgdsgdgsdgsd

                            if (reader.Read())
                            {
                                usr = ToBO(reader);
                                if (usr != null)
                                {
                                    return usr;
                                }
                                else
                                {
                                    throw new Exception();
                                }
                            }
                            else
                            {
                                return null;

                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }

        }
        public User GetUserByUsername(string username)
        {
            usr = new User();
            try
            {

                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    using (SqlCommand command = DbHelper.Command(conn, "usp_GetUserByUsername", CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("@UserName", username);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                usr = ToBO(reader);
                                if (usr != null)
                                {
                                    return usr;
                                }
                                else
                                {
                                    throw new Exception();
                                }
                            }
                            else
                            {
                                return null;

                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        public int Add(User obj) 
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    using (SqlCommand command = DbHelper.Command(conn, "usp_CreateUsers", CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("UserName", obj.Username);
                        command.Parameters.AddWithValue("Password", obj.Password);
                        command.Parameters.AddWithValue("Name", obj.Name);
                        command.Parameters.AddWithValue("LastName", obj.LastName);
                        command.Parameters.AddWithValue("RoleId", obj.RoleID);
                        command.Parameters.AddWithValue("Email", obj.Email);
                        command.Parameters.AddWithValue("InsertBy", obj.InsBy);
                        int error;

                        SqlParameter sqlpa = new SqlParameter();
                        sqlpa.ParameterName = "Error";
                        sqlpa.SqlDbType = SqlDbType.Int;
                        sqlpa.Direction = ParameterDirection.Output;

                        command.Parameters.Add(sqlpa);

                        command.ExecuteNonQuery();

                        error = (int)sqlpa.Value;

                        if (error == 0)
                        {
                            return 0;
                        }

                        else if(error == 1)
                        {
                            return 1;
                        }
                        else
                        {
                            throw new Exception();
                        }

                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Please contact your administrator");
                return -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Material Type name  should be uniqe, please if this material type is deactivated update it");
                return -1;
            }

        }
        public int Delete(int Id)
        {
            int rowsAffected = 0;
            try
            {
                using (var conn = DbHelper.GetConnection())
                {
                    using (var command = DbHelper.Command(conn, "usp_DeleteUser", CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("@UserId", Id);


                        rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            return 0;
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }

                }
            }
            catch (Exception)
            {
                return -1;
            }


        }
        public User Get(int Id)
        {
            usr = new User();
            try
            {
                using (var conn = DbHelper.GetConnection())
                {
                    using (var command = DbHelper.Command(conn, "usp_GetUser", CommandType.StoredProcedure))
                    {

                        command.Parameters.AddWithValue("@UserId",Id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                usr = ToBO(reader);
                                if (usr != null)
                                {
                                    return usr;
                                }
                                else
                                {
                                    throw new Exception();
                                }

                            }
                            else
                            {
                                return null;
                            }
                        }
                    }

                }
            }
            catch (Exception)
            {

                return null;
            }
        }
        public List<User> GetAll()
        {
            usr = new User();
            try
            {

                List<User> AllUsers = new List<User>();
                using (var conn = DbHelper.GetConnection())
                {
                    using (var command = DbHelper.Command(conn, "usp_GetAllUsers", CommandType.StoredProcedure))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    usr = ToBO(reader);
                                    if (usr != null)
                                    {
                                        AllUsers.Add(usr);
                                    }
                                }
                            }
                        }
                    }

                }
                if (AllUsers.Count > 0)
                {
                    return AllUsers;

                }
                else
                {
                    throw new Exception();
                }

            }
            catch (Exception)
            {

                return null;
            }
        }
        public User ToBO(SqlDataReader reader)
        {
            try
            {
                User usr = new User();

                usr.Username = reader["Username"].ToString();
                if (reader["Password"] != DBNull.Value)
                {
                    usr.Password = reader["Password"].ToString();


                }
                usr.Name = reader["Name"].ToString();
                usr.UserID = (int)reader["UserId"];
                usr.LastName = reader["LastName"].ToString();
                usr.RoleID = int.Parse(reader["RoleId"].ToString());
                usr._role.UserRoleId = usr.RoleID;
                usr._role.UserRole = reader["Role"].ToString();
                usr.Email = reader["Email"].ToString();


                usr.IsActive = (bool)reader["IsActive"];



                return usr;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public int Update(User obj)
        {
            int rowsAffected = 0;
            try
            {
                using (var conn = DbHelper.GetConnection())
                {
                    using (var command = DbHelper.Command(conn, "usp_UpdateUser", CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("UserName", obj.Username);
                        command.Parameters.AddWithValue("Name", obj.Name);
                        command.Parameters.AddWithValue("LastName", obj.LastName);
                        command.Parameters.AddWithValue("RoleId", obj.RoleID);
                        command.Parameters.AddWithValue("Email", obj.Email);
                        command.Parameters.AddWithValue("UpdBy", obj.UpdBy);//gabimmmmmm
                        command.Parameters.AddWithValue("IsActive", obj.IsActive);



                        rowsAffected= command.ExecuteNonQuery();



                         if (rowsAffected > 0)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;

                        }

                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Please contact your administrator");
                return -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Material Type name  should be uniqe, please if this material type is deactivated update it");
                return -1;
            }

        }
        public int ChangePassword(int UserId, string password,int UpdBy)
        {
            int rowsAffected = 0;
            try
            {
                using (var conn = DbHelper.GetConnection())
                {
                    using (var command = DbHelper.Command(conn, "usp_ChangeUserPassword", CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("UserId", UserId);
                        command.Parameters.AddWithValue("Password", password);
                        command.Parameters.AddWithValue("UpdBy", UpdBy);

                        rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            return 0;
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }

                }
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}


