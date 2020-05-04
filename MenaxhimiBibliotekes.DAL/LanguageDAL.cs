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
    public class LanguageDAL : ICrud<Language>, IConvertToBO<Language>
    {
        Language lang;
        public bool Add(Language obj)
        {
            int isInserted = 0;
            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    using (SqlCommand command = DbHelper.Command(conn, "usp_CreateLanguage", CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("Language", obj._Language);
                        command.Parameters.AddWithValue("InsBy", obj.InsBy);
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
            int IsDeleted = 0;
            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    using (SqlCommand command = DbHelper.Command(conn, "usp_DeleteLanguage", CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("LanguageId", Id);
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


        public Language Get(int Id)
        {

            //lang = new Language();

            //using (SqlConnection sqlconn = DbHelper.GetConnection())
            //{
            //    using (SqlCommand command = DbHelper.Command(sqlconn, "usp_GetLanguage", CommandType.StoredProcedure))
            //    {
            //        using (SqlDataReader sqr = command.ExecuteReader())
            //        {

            //                if (sqr.Read())
            //                {

            //                    lang = ToBO(sqr);
            //                }

            //            return lang;
            //        }
            //    }
            //}
            throw new NotImplementedException();
        }



        public List<Language> GetAll()
        {
            List<Language> AllLanguage = new List<Language>();
            lang = new Language();

            using (SqlConnection sqlconn = DbHelper.GetConnection())
            {
                using (SqlCommand command = DbHelper.Command(sqlconn, "usp_GetAllLanguages", CommandType.StoredProcedure))
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
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                using (SqlCommand command = DbHelper.Command(conn, "usp_UpdateLanguage", CommandType.StoredProcedure))
                {
                    command.Parameters.AddWithValue("LanguageId", obj.LanguageId);
                    command.Parameters.AddWithValue("Language", obj._Language);
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
