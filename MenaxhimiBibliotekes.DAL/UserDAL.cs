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
    public class UserDAL : ICrud<User>,IConvertToBO<User>
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
        public bool Add(User obj) 
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

                        if (error == 1)
                        {
                            throw new Exception();
                        }

                        else if(error == 2)
                        {
                            MessageBox.Show("You are not an Admin");
                            return false;
                        }
                        else if (error == 0)
                        {
                            return true;
                        }

                        return false;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Please contact your administrator");
                return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Material Type name  should be uniqe, please if this material type is deactivated update it");
                return false;
            }

        }

        public bool Delete(int Id)
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
                using (var conn = DbHelper.GetConnection())
                {
                    using (var command = DbHelper.Command(conn, "usp_GetUserById", CommandType.StoredProcedure))
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
                usr.UserID = int.Parse(reader["UserID"].ToString());
                usr.Username = reader["Username"].ToString();
                usr.Password = reader["Password"].ToString();
                usr.Name = reader["Name"].ToString();
                usr.LastName = reader["LastName"].ToString();
                usr.RoleID = int.Parse(reader["RoleId"].ToString());
               // usr._role.UserRoleId = int.Parse(reader["RoleId"].ToString());
               // usr._role.UserRole = reader["Role"].ToString();
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
                using (var conn = DbHelper.GetConnection())
                {
                    using (var command = DbHelper.Command(conn, "usp_UpdateUser", CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("UserName", obj.Username);
                        command.Parameters.AddWithValue("Password", obj.Password);
                        command.Parameters.AddWithValue("Name", obj.Name);
                        command.Parameters.AddWithValue("LastName", obj.LastName);
                        command.Parameters.AddWithValue("RoleId", obj.RoleID);
                        command.Parameters.AddWithValue("Email", obj.Email);
                        command.Parameters.AddWithValue("UpdBy", obj.UpdBy);//gabimmmmmm

                        int error;

                        SqlParameter sqlpa = new SqlParameter();
                        sqlpa.ParameterName = "Error";
                        sqlpa.SqlDbType = SqlDbType.Int;
                        sqlpa.Direction = ParameterDirection.Output;

                        command.Parameters.Add(sqlpa);

                        command.ExecuteNonQuery();
                        error = (int)sqlpa.Value;



                         if (error == 2)
                        {
                            MessageBox.Show("This username doese'nt exist");
                            return false;
                        }
                        else if (error == 0)
                        {
                            MessageBox.Show("good");
                            return true;
                        }

                        return false;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Please contact your administrator");
                return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Material Type name  should be uniqe, please if this material type is deactivated update it");
                return false;
            }

        }
    }
}


