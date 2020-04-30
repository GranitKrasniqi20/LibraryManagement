using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenaxhimiBibliotekes.BO;
using MenaxhimiBibliotekes.BO.Interfaces;
using System.Data;
using System.Data.SqlClient;

namespace MenaxhimiBibliotekes.DAL
{
    public class UserDAL : ICrud<User>,IConvertToBO<User>
    {

        User usr = new User();
        public User LogIn(string username, string password)
        {
            usr = new User();
            try
            {

                using (SqlConnection conn = Connection.GetConnection())
                {
                    using (SqlCommand command = Connection.Command(conn, "usp_LogIn", CommandType.StoredProcedure))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            Connection.AddParameter(command, "UserName", username);
                            Connection.AddParameter(command, "Password", password);
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
                                throw new Exception();
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
        public bool Add(User obj) 
        {
            int rowsAffected = 0;
            try
            {
                using (var conn = Connection.GetConnection())
                {
                    using (var command = Connection.Command(conn, "usp_InsertUser", CommandType.StoredProcedure))
                    {
                        Connection.AddParameter(command, "UserName", obj.Username);
                        Connection.AddParameter(command, "Password", obj.Password);
                        Connection.AddParameter(command, "Name", obj.Name);
                        Connection.AddParameter(command, "LastName", obj.LastName);
                        Connection.AddParameter(command, "RoleId", obj.RoleID);
                        Connection.AddParameter(command, "Email", obj.Email);
                        Connection.AddParameter(command, "InstBy", obj.InsBy);

                         rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            return true;
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
                return false;
            }


        }

        public bool Delete(int Id)
        {
            int rowsAffected = 0;
            try
            {
                using (var conn = Connection.GetConnection())
                {
                    using (var command = Connection.Command(conn, "usp_DeleteUser", CommandType.StoredProcedure))
                    {
                        Connection.AddParameter(command, "@UserId", Id);


                        rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            return true;
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
                return false;
            }


        }



        public User Get(int Id)
        {
            usr = new User();
            try
            {
                using (var conn = Connection.GetConnection())
                {
                    using (var command = Connection.Command(conn, "usp_GetUserById", CommandType.StoredProcedure))
                    {
                        Connection.AddParameter(command, "@UserName",Id);

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
                using (var conn = Connection.GetConnection())
                {
                    using (var command = Connection.Command(conn, "usp_GetAllUsers", CommandType.StoredProcedure))
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
                usr.UserID = int.Parse(reader["UserID"].ToString());
                usr.Username = reader["Username"].ToString();
                usr.Password = reader["Password"].ToString();
                usr.Name = reader["Name"].ToString();
                usr.LastName = reader["LastName"].ToString();
                usr.RoleID = int.Parse(reader["RoleId"].ToString());
                usr._role.UserRoleId = int.Parse(reader["RoleId"].ToString());
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

        public bool Update(User obj)
        {
            int rowsAffected = 0;
            try
            {
                using (var conn = Connection.GetConnection())
                {
                    using (var command = Connection.Command(conn, "usp_UpdateUser", CommandType.StoredProcedure))
                    {
                        Connection.AddParameter(command, "UserName", obj.Username);
                        Connection.AddParameter(command, "Password", obj.Password);
                        Connection.AddParameter(command, "Name", obj.Name);
                        Connection.AddParameter(command, "LastName", obj.LastName);
                        Connection.AddParameter(command, "RoleId", obj.RoleID);
                        Connection.AddParameter(command, "Email", obj.Email);
                        Connection.AddParameter(command, "UpdBy", obj.UpdBy);//gabimmmmmm

                        rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            return true;
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
                return false;
            }


        }
    }
}


