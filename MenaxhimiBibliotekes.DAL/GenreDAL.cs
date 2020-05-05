
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
   public class GenreDAL:ICrud<Genre>, IConvertToBO<Genre>
    {
        Genre gen;
        public bool Add(Genre obj)
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

                        if (error == 1)
                        {
                            throw new Exception();
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
                MessageBox.Show("Genre name  should be uniqe, please if this material type is deactivated update it");
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
                    using (SqlCommand command = DbHelper.Command(conn, "usp_DeleteGenre", CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue( "GenreId", Id);
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

        public bool Update(Genre obj)
        {
            int isUpdated = 0;
            try
            {
                int error;

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
                        error = (int)sqlpa.Value;

                        if (error == 1 )
                        {
                            throw new Exception();
                        }
                        else if (error == 0 && isUpdated > 0)
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
