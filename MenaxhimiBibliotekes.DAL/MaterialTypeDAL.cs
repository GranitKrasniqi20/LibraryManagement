using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenaxhimiBibliotekes.BO.Interfaces;
using MenaxhimiBibliotekes.BO;
using System.Data.SqlClient;
using System.Data;

namespace MenaxhimiBibliotekes.DAL
{
    public class MaterialTypeDAL : ICrud<MaterialType>, IConvertToBO<MaterialType>
    {
        MaterialType mt;
        public bool Add(MaterialType obj)
        {
            int isInserted = 0;
            try
            {
                using (SqlConnection conn = Connection.GetConnection())
                {
                    using (SqlCommand command = Connection.Command(conn, "usp_CreateMaterialType", CommandType.StoredProcedure))
                    {
                        Connection.AddParameter(command, "Genre", obj._MaterialType);
                        Connection.AddParameter(command, "InsBy", obj.InsBy);
                        isInserted = command.ExecuteNonQuery();


                        if (isInserted > 0)
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
            throw new NotImplementedException();
        }

        public bool Delete(MaterialType obj)
        {
            throw new NotImplementedException();
        }

        public MaterialType Get(int Id)
        {
            throw new NotImplementedException();
        }

        public MaterialType Get(MaterialType obj)
        {
            throw new NotImplementedException();
        }

        public List<MaterialType> GetAll()
        {
            List<MaterialType> AllMaterialType = new List<MaterialType>();
            mt = new MaterialType();
            
            using (SqlConnection sqlconn = Connection.GetConnection())
            {
                using (SqlCommand command = Connection.Command(sqlconn, "@GetAllGenres", CommandType.StoredProcedure))
                {
                    using (SqlDataReader sqr = command.ExecuteReader())
                    {
                        if (sqr.HasRows)
                        {
                            while (sqr.Read())
                            {

                                mt = ToBO(sqr);
                                if (mt == null)
                                {
                                    throw new Exception();
                                }

                                //rreshtat e rafteve ne listen brenda materialeve

                                AllMaterialType.Add(mt);



                            }
                        }
                        return AllMaterialType;
                    }
                }
            }
        }

        public MaterialType ToBO(SqlDataReader reader)
        {
            try
            {
                mt = new MaterialType();

                mt.MaterialTypeId = (int)reader["MaterialTypeId"];
                mt._MaterialType = reader["MaterialType"].ToString();

                mt.InsBy = int.Parse(reader["InsBy"].ToString());
                mt.InsDate = (DateTime)reader["InsDate"];

                if (reader["UpdBy"] != DBNull.Value)
                {
                    mt.UpdBy = int.Parse(reader["UpdBy"].ToString());
                }
                if (reader["UpdDate"] != DBNull.Value)
                {
                    mt.UpdDate = (DateTime)reader["UpdDate"];
                }

                mt.UpdNo = int.Parse(reader["UpdNo"].ToString());



                return mt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(MaterialType obj)
        {
            int isUpdated = 0;
            using (SqlConnection conn = Connection.GetConnection())
            {
                using (SqlCommand command = Connection.Command(conn, "usp_UpdateGenre", CommandType.StoredProcedure))
                {
                    Connection.AddParameter(command, "MaterialTypeId", obj.MaterialTypeId);
                    Connection.AddParameter(command, "MaterialType", obj._MaterialType);
                    Connection.AddParameter(command, "InsBy", obj.InsBy);
                    isUpdated = command.ExecuteNonQuery();


                    if (isUpdated > 0)
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
    }
}
