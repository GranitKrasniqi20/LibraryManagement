using MenaxhimiBibliotekes.BO;
using MenaxhimiBibliotekes.BO.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenaxhimiBibliotekes.DAL
{
   public class BorrowDAL : ICreate<Borrow> /*IUpdate<Borrow>, IDelete, IRead<Borrow>*/
    {



        public int Add(Borrow obj)
        {
            int error;
            try
            {

                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    using (SqlCommand command = DbHelper.Command(conn, "usp_CreateBorrow", CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("SubscriberId", obj.SubscriberId);
                        command.Parameters.AddWithValue("MaterialId", obj.materialId);
                        command.Parameters.AddWithValue("ReturnDate", obj.ReturnDate);
                        command.Parameters.AddWithValue("ShelfId", obj.shelfId);
                        command.Parameters.AddWithValue("Comment", obj.Comment);
                        command.Parameters.AddWithValue("TypeId", obj._typeOfActionId);
                        command.Parameters.AddWithValue("ReservationId", obj.ReservationId);
                        command.Parameters.AddWithValue("BillId", obj.BillId);
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
            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    using (SqlCommand command = DbHelper.Command(conn, "usp_Bills_Delete", CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("billId", Id);

                        int Affected = command.ExecuteNonQuery();

                        if (Affected > 0)
                        {
                            return 1;
                        }
                        else
                        {
                            return -1;
                        }
                    }
                }
            }
            catch (Exception)
            {

                return -1;
            }
        }

        public Borrow Get(int Id)
        {
            throw new NotImplementedException();
        }

        //public List<Borrow> GetAll()
        //{

        //    try
        //    {
        //        List<Language> AllLanguage = new List<Language>();
        //        lang = new Language();

        //        using (SqlConnection sqlconn = DbHelper.GetConnection())
        //        {
        //            using (SqlCommand command = DbHelper.Command(sqlconn, "usp_GetAllLanguages", CommandType.StoredProcedure))
        //            {
        //                using (SqlDataReader sqr = command.ExecuteReader())
        //                {
        //                    if (sqr.HasRows)
        //                    {
        //                        while (sqr.Read())
        //                        {

        //                            lang = ToBO(sqr);
        //                            if (lang == null)
        //                            {
        //                                throw new Exception();
        //                            }



        //                            AllLanguage.Add(lang);



        //                        }
        //                    }
        //                    return AllLanguage;
        //                }
        //            }
        //        }
        //    }
        //    catch (SqlException)
        //    {
        //        MessageBox.Show("There was a problem, please contact your administrator");
        //        return null;
        //    }
        //}

        //public int Update(Borrow obj)
        //{
        //    int isUpdated = 0;
        //    try
        //    {
        //        int error;

        //        using (SqlConnection conn = DbHelper.GetConnection())
        //        {
        //            using (SqlCommand command = DbHelper.Command(conn, "usp_UpdateLanguage", CommandType.StoredProcedure))
        //            {
        //                command.Parameters.AddWithValue("LanguageId", obj.LanguageId);
        //                command.Parameters.AddWithValue("Language", obj._Language);
        //                command.Parameters.AddWithValue("UpdBy", obj.UpdBy);




        //                isUpdated = command.ExecuteNonQuery();
        //                if (isUpdated > 0)
        //                {
        //                    return 0;
        //                }
        //                else
        //                {
        //                    return 1;
        //                }

        //            }
        //        }
        //    }


        //    catch (SqlException ex)
        //    {

        //        MessageBox.Show("Please contact your administrator");
        //        return -1;

        //    }

        //    catch (Exception)
        //    {
        //        MessageBox.Show("Material Type name  should be uniqe, please if this material type is deactivated update it");
        //        return -1;
        //    }
        //}
    }

}
