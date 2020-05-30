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
    public class MaterialTypeDAL : ICreate<MaterialType>, IUpdate<MaterialType>, IDelete, IRead<MaterialType>, IConvertToBO<MaterialType>
    {
        MaterialType mt;
        public int Add(MaterialType obj)
        {

            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    using (SqlCommand command = DbHelper.Command(conn, "usp_CreateMaterialType", CommandType.StoredProcedure))
                    {


                        command.Parameters.AddWithValue("MaterialType", obj._MaterialType);
                        command.Parameters.AddWithValue("MaterialTypeDelayFee", obj.MaterialTypeDelayFee);
                        command.Parameters.AddWithValue("InsBy", obj.InsBy);
                        int error;

                        SqlParameter sqlpa = new SqlParameter();
                        sqlpa.ParameterName = "Error";
                        sqlpa.SqlDbType = SqlDbType.Int;
                        sqlpa.Direction = ParameterDirection.Output;

                        command.Parameters.Add(sqlpa);

                        command.ExecuteNonQuery();
                        error = (int)sqlpa.Value;

                        return error; 
                    }
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Material Type has an problem, please contact your administrator " + " " + ex.Message );
                return -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Material Type has an problem, please contact your administrator ");
                return -1;
            }

        }

        public int Delete(int Id)
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
               mt.MaterialTypeDelayFee= (decimal)reader["MaterialTypeDelayFee"];
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
                mt.isActive = (bool)reader["IsActive"];
                mt.UpdNo = int.Parse(reader["UpdNo"].ToString());



                return mt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int Update(MaterialType obj)
        {
            int Updated;
            try
            {


                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    using (SqlCommand command = DbHelper.Command(conn, "usp_UpdateMaterialType", CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("MaterialTypeId", obj.MaterialTypeId);
                        command.Parameters.AddWithValue("MaterialType", obj._MaterialType);
                        command.Parameters.AddWithValue("MaterialTypeDelayFee", obj.MaterialTypeDelayFee);
                        command.Parameters.AddWithValue("UpdBy", obj.UpdBy);
                        command.Parameters.AddWithValue("@IsActive", obj.isActive) ;



                        Updated = command.ExecuteNonQuery();

                        if (Updated > 0)
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
            catch (Exception)
            {
                return -1;
            }


        }
    }


}
    

       