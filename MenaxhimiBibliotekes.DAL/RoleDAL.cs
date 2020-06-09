using MenaxhimiBibliotekes.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiBibliotekes.DAL
{
    public class RoleDAL 
    {
        Role role;


        public List<Role> GetAll()
        {
            List<Role> AllRoles = new List<Role>();
            role = new Role();
            using (SqlConnection sqlconn = DbHelper.GetConnection())
            {
                using (SqlCommand command = DbHelper.Command(sqlconn, "usp_GetAllRoles", CommandType.StoredProcedure))
                {
                    using (SqlDataReader sqr = command.ExecuteReader())
                    {
                        if (sqr.HasRows)
                        {
                            while (sqr.Read())
                            {

                                role = ToBO(sqr);
                                if (role == null)
                                {
                                    throw new Exception();
                                }


                                AllRoles.Add(role);



                            }
                        }
                        return AllRoles; ;
                    }
                }
            }
        }
        public Role ToBO(SqlDataReader reader)
        {
            try
            {
                role = new Role();

                role.UserRoleId = (int)reader["RoleId"];
                role.UserRole = reader["Role"].ToString();

                role.InsBy = int.Parse(reader["InsBy"].ToString());
                role.InsDate = (DateTime)reader["InsDate"];

                if (reader["UpdBy"] != DBNull.Value)
                {
                    role.UpdBy = int.Parse(reader["UpdBy"].ToString());
                }
                if (reader["UpdDate"] != DBNull.Value)
                {
                    role.UpdDate = (DateTime)reader["UpdDate"];
                }

                role.UpdNo = int.Parse(reader["UpdNo"].ToString());


                return role;
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
