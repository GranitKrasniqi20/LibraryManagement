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
        public bool Add(User obj) 
        {
            int rowsAffected = 0;
            try
            {
                using (var conn = Connection.GetConnection())
                {
                    using (var command = Connection.Command(conn, "usp_InsertUser", CommandType.StoredProcedure))
                    {
                        Connection.AddParameter(command, "@UserName", obj.Username);
                        Connection.AddParameter(command, "@Password", obj.Password);
                        Connection.AddParameter(command, "@Name", obj.Name);
                        Connection.AddParameter(command, "@LastName", obj.LastName);
                        Connection.AddParameter(command, "@RoleId", obj.RoleID);
                        Connection.AddParameter(command, "@Email", obj.Email);
                        Connection.AddParameter(command, "@InsertBy", obj.InsBy);

                         rowsAffected = command.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception)
            {
                return false;
            }

            if (rowsAffected >0)
            {
                return true;
            }
            else
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
                    using (var command = Connection.Command(conn, "usp_InsertUser", CommandType.StoredProcedure))
                    {
                        Connection.AddParameter(command, "@UserId", Id);


                        rowsAffected = command.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception)
            {
                return false;
            }

            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Delete(User obj)
        {
            int rowsAffected = 0;
            try
            {
                using (var conn = Connection.GetConnection())
                {
                    using (var command = Connection.Command(conn, "usp_InsertUser", CommandType.StoredProcedure))
                    {
                        Connection.AddParameter(command, "@Username", obj.Username);


                        rowsAffected = command.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception)
            {
                return false;
            }

            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public User Get(int Id)
        {
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

                                return ToBO(reader);

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

        public User Get(User obj)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
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
                                AllUsers.Add(ToBO(reader));
                            }
                        }
                    }
                }

            }
            return AllUsers;
        }

        public User ToBO(SqlDataReader reader)
        {
            User usr = new User();
            usr.UserID = int.Parse(reader["UserID"].ToString());
            usr.Username = reader["Username"].ToString();
            usr.Password = reader["Password"].ToString();
            usr.Name = reader["Name"].ToString();
            usr.LastName = reader["LastName"].ToString();
            usr.RoleID =int.Parse(reader["RoleId"].ToString());
            usr._role.UserRoleId = int.Parse(reader["RoleId"].ToString());
            usr._role.UserRole = reader["Role"].ToString();
            usr.Email = reader["Email"].ToString();

            if (reader["IsActive"].ToString() == "1")
            {
                usr.IsActive = true;
            }
            else
            {
                usr.IsActive = false;
            }


            return usr;
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
                        Connection.AddParameter(command, "@UserName", obj.Username);
                        Connection.AddParameter(command, "@Password", obj.Password);
                        Connection.AddParameter(command, "@Name", obj.Name);
                        Connection.AddParameter(command, "@LastName", obj.LastName);
                        Connection.AddParameter(command, "@RoleId", obj.RoleID);
                        Connection.AddParameter(command, "@Email", obj.Email);
                        Connection.AddParameter(command, "@InsertBy", obj.InsBy);

                        rowsAffected = command.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception)
            {
                return false;
            }

            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}


