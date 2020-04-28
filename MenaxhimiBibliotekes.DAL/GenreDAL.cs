
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
    class GenreDAL:ICrud<Genre>, IConvertToBO<Genre>
    {
        Genre gen;
        public bool Add(Genre obj)
        {
            int isInserted = 0;
            try
            {
                using (SqlConnection conn = Connection.GetConnection())
                {
                    using (SqlCommand command = Connection.Command(conn, "usp_CreateGenre", CommandType.StoredProcedure))
                    {
                        Connection.AddParameter(command, "Genre", obj._Genre);
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

        public bool Delete(Genre obj)
        {
            throw new NotImplementedException();
        }

        public Genre Get(int Id)
        {
            throw new NotImplementedException();
        }

        public Genre Get(Genre obj)
        {
            throw new NotImplementedException();
        }

        public List<Genre> GetAll()
        {
            List<Genre> AllGenres = new List<Genre>();
            gen = new Genre();
            using (SqlConnection sqlconn = Connection.GetConnection())
            {
                using (SqlCommand command = Connection.Command(sqlconn, "@GetAllGenres",CommandType.StoredProcedure))
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
            using (SqlConnection conn = Connection.GetConnection())
            {
                using (SqlCommand command = Connection.Command(conn, "usp_UpdateGenre", CommandType.StoredProcedure))
                {
                    Connection.AddParameter(command, "GenreId", obj.GenreId);
                    Connection.AddParameter(command, "Genre", obj._Genre);
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
