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
    class LanguageDAL : ICrud<Language>, IConvertToBO<Language>
    {
        Language lang;
        public bool Add(Language obj)
        {
            int isInserted = 0;
            try
            {
                using (SqlConnection conn = Connection.GetConnection())
                {
                    using (SqlCommand command = Connection.Command(conn, "usp_CreateLanguage", CommandType.StoredProcedure))
                    {
                        Connection.AddParameter(command, "Language", obj._Language);
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

        public bool Delete(Language obj)
        {
            throw new NotImplementedException();
        }

        public Language Get(int Id)
        {
            throw new NotImplementedException();
        }

        public Language Get(Language obj)
        {
            throw new NotImplementedException();
        }

        public List<Language> GetAll()
        {
            List<Language> AllLanguage = new List<Language>();
            lang = new Language();

            using (SqlConnection sqlconn = Connection.GetConnection())
            {
                using (SqlCommand command = Connection.Command(sqlconn, "@GetAllLanguages", CommandType.StoredProcedure))
                {
                    using (SqlDataReader sqr = command.ExecuteReader())
                    {
                        if (sqr.HasRows)
                        {
                            while (sqr.Read())
                            {

                                lang = ToBO(sqr);
                                if (lang == null)
                                {
                                    throw new Exception();
                                }

                               

                                AllLanguage.Add(lang);



                            }
                        }
                        return AllLanguage;
                    }
                }
            }


        }
        public bool Update(Language obj)
        {
            int isUpdated = 0;
            using (SqlConnection conn = Connection.GetConnection())
            {
                using (SqlCommand command = Connection.Command(conn, "usp_UpdateGenre", CommandType.StoredProcedure))
                {
                    Connection.AddParameter(command, "MaterialTypeId", obj.LanguageId);
                    Connection.AddParameter(command, "MaterialType", obj._Language);
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
        public Language ToBO(SqlDataReader reader)
        {

            try
            {
                lang = new Language();

                lang.LanguageId = (int)reader["LanguageId"];
                lang._Language = reader["Language"].ToString();

                lang.InsBy = int.Parse(reader["InsBy"].ToString());
                lang.InsDate = (DateTime)reader["InsDate"];

                if (reader["UpdBy"] != DBNull.Value)
                {
                    lang.UpdBy = int.Parse(reader["UpdBy"].ToString());
                }
                if (reader["UpdDate"] != DBNull.Value)
                {
                    lang.UpdDate = (DateTime)reader["UpdDate"];
                }

                lang.UpdNo = int.Parse(reader["UpdNo"].ToString());
                return lang;
            }





            catch (Exception)
            {

                throw;
            }
        }



    }


 }

