
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
   public class GenreDAL : ICreate<Genre>, IUpdate<Genre>, IDelete, IRead<Genre>, IConvertToBO<Genre>
    {
        Genre gen;
        public int Add(Genre obj)
        {
            int error ;
            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    using (SqlCommand command = DbHelper.Command(conn, "usp_CreateGenre", CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("Genre", obj._Genre);
                        command.Parameters.AddWithValue("InsBy", obj.InsBy);


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
            catch (SqlException)
            {
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
                    using (SqlCommand command = DbHelper.Command(conn, "usp_DeleteGenre", CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("GenreId", Id);
                        IsDeleted = command.ExecuteNonQuery();

                        return IsDeleted;
                    }

                }
            }
            catch (Exception)
            {
                return -1;
            }
        }



        public Genre Get(int Id)
        {
            throw new NotImplementedException();
        }



        public List<Genre> GetAll()
        {
            List<Genre> AllGenres = new List<Genre>();
            gen = new Genre();
            using (SqlConnection sqlconn = DbHelper.GetConnection())
            {
                using (SqlCommand command = DbHelper.Command(sqlconn, "usp_GetAllGenres",CommandType.StoredProcedure))
                {
                    using (SqlDataReader sqr = command.ExecuteReader())
                    {
                        if (sqr.HasRows)
                        {
                            while (sqr.Read())
                            {

                                gen = ToBO(sqr);
                                if (gen == null)
                                {
                                    throw new Exception();
                                }

                                //rreshtat e rafteve ne listen brenda materialeve

                                AllGenres.Add(gen);



                            }
                        }
                        return AllGenres;
                    }
                }
            }
        }

        public Genre ToBO(SqlDataReader reader)
        {
            try
            {
                gen = new Genre();

                gen.GenreId =(int)reader["GenreId"];
                gen._Genre = reader["Genre"].ToString();

                gen.InsBy = int.Parse(reader["InsBy"].ToString());
                gen.InsDate = (DateTime)reader["InsDate"];

                if (reader["UpdBy"] != DBNull.Value)
                {
                    gen.UpdBy = int.Parse(reader["UpdBy"].ToString());
                }
                if (reader["UpdDate"] != DBNull.Value)
                {
                    gen.UpdDate = (DateTime)reader["UpdDate"];
                }

                gen.UpdNo = int.Parse(reader["UpdNo"].ToString());



                return gen;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public int Update(Genre obj)
        {
            int isUpdated = 0;
            try
            {

                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    using (SqlCommand command = DbHelper.Command(conn, "usp_UpdateGenre", CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("GenreId", obj.GenreId);
                        command.Parameters.AddWithValue("Genre", obj._Genre);
                        command.Parameters.AddWithValue("UpdBy", obj.UpdBy);


                        SqlParameter sqlpa = new SqlParameter();
                        sqlpa.ParameterName = "Error";
                        sqlpa.SqlDbType = SqlDbType.Int;
                        sqlpa.Direction = ParameterDirection.Output;

                        command.Parameters.Add(sqlpa);

                        isUpdated = command.ExecuteNonQuery();
                        return (int)sqlpa.Value;



                    }
                }
            }
            catch(Exception)
            {
                
                    return -1;
                
            }


        
        }
                


        
    }
}
