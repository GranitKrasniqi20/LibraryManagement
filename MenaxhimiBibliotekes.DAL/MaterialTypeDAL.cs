using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenaxhimiBibliotekes.BO.Interfaces;
using MenaxhimiBibliotekes.BO;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace MenaxhimiBibliotekes.DAL
{
    public class MaterialTypeDAL : ICrud<MaterialType>, IConvertToBO<MaterialType>
    {
        MaterialType mt;
        public bool Add(MaterialType obj)
        {
            int error;
            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    using (SqlCommand command = DbHelper.Command(conn, "usp_CreateMaterialType", CommandType.StoredProcedure))
                    {


                        command.Parameters.AddWithValue("MaterialType", obj._MaterialType);
                        command.Parameters.AddWithValue("InsBy", obj.InsBy);

                        SqlParameter sqlpa = new SqlParameter();
                        sqlpa.ParameterName = "Error";
                        sqlpa.SqlDbType = SqlDbType.Int;
                        sqlpa.Direction = ParameterDirection.Output;

                        command.Parameters.Add(sqlpa);

                         command.ExecuteNonQuery();
                         error = (int)sqlpa.Value ;

                        if (error == 1)
                        {
                            throw new Exception();
                        }
                        else if(error == 0)
                        {
                            MessageBox.Show("good");
                            return true;
                        }

                        return false ;
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
            int IsDeleted = 0;
            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    using (SqlCommand command = DbHelper.Command(conn, "usp_DeleteMaterialType", CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("MaterialTypeId", Id);
                        IsDeleted = command.ExecuteNonQuery();


                        if (IsDeleted > 0)
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



        public MaterialType Get(int Id)
        {
            throw new NotImplementedException();
        }


        public List<MaterialType> GetAll()
        {
            List<MaterialType> AllMaterialType = new List<MaterialType>();
            mt = new MaterialType();
            
            using (SqlConnection sqlconn = DbHelper.GetConnection())
            {
                using (SqlCommand command = DbHelper.Command(sqlconn, "usp_GetAllMaterialTypes", CommandType.StoredProcedure))
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
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                using (SqlCommand command = DbHelper.Command(conn, "usp_UpdateMaterialType", CommandType.StoredProcedure))
                {
                    command.Parameters.AddWithValue("MaterialTypeId", obj.MaterialTypeId);
                    command.Parameters.AddWithValue("MaterialType", obj._MaterialType);
                    command.Parameters.AddWithValue("UpdBy", obj.UpdBy);
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
