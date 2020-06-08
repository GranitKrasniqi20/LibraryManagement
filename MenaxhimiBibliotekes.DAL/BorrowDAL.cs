using MenaxhimiBibliotekes.BO;
using MenaxhimiBibliotekes.BO.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MenaxhimiBibliotekes.DAL
{
   public class BorrowDAL : ICreate<Borrow>, IUpdate<Borrow>, IDelete, IRead<Borrow>,IConvertToBO<Borrow>
    {


        Borrow borr;
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
                        command.Parameters.AddWithValue("ReturnDate", obj.DeadLine);

                        if (obj.shelfId > 0)
                        {
                            command.Parameters.AddWithValue("ShelfId", obj.shelfId);
                        }

                        if (obj.ReservationId > 0)
                        {
                            command.Parameters.AddWithValue("ReservationId", obj.ReservationId);
                        }

                        if (obj.Comment != string.Empty)
                        {
                            command.Parameters.AddWithValue("Comment", obj.Comment);
                        }
                            command.Parameters.AddWithValue("BorrowDate", obj.BorrowDate);

                        command.Parameters.AddWithValue("InsBy", obj.InsBy);

                        SqlParameter sqlpa = new SqlParameter();
                        sqlpa.ParameterName = "Error";
                        sqlpa.SqlDbType = SqlDbType.Int;
                        sqlpa.Direction = ParameterDirection.Output;

                        command.Parameters.Add(sqlpa);


                       

                        int i = command.ExecuteNonQuery();
                        error = (int)sqlpa.Value;
                        if (error ==0 && i > 0)
                        {
                            return 0;
                        }
                        else if (error == 1)
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
            catch (SqlException ex)
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
                    using (SqlCommand command = DbHelper.Command(conn, "usp_DelteBorrow", CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("BorrowId", Id);

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
            try
            {
                borr = new Borrow();

                using (SqlConnection sqlconn = DbHelper.GetConnection())
                {
                    using (SqlCommand command = DbHelper.Command(sqlconn, "usp_GetBorrowById", CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("BorrowId", Id);

                        using (SqlDataReader sqr = command.ExecuteReader())
                        {


                            if (sqr.Read())
                            {

                                    borr = ToBO(sqr);
                                    if (borr == null)
                                    {
                                        throw new Exception();
                                    }
                                return borr;


                            }
                            return null;
                        }
                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("There was a problem, please contact your administrator");
                return null;
            }
        }

        public List<Borrow> GetAll()
        {
            try
            {
                List<Borrow> AllBorrowings = new List<Borrow>();
                borr = new Borrow();

                using (SqlConnection sqlconn = DbHelper.GetConnection())
                {
                    using (SqlCommand command = DbHelper.Command(sqlconn, "usp_GetAllBorrowings", CommandType.StoredProcedure))
                    {
                        using (SqlDataReader sqr = command.ExecuteReader())
                        {
                            if (sqr.HasRows)
                            {
                                while (sqr.Read())
                                {

                                    borr = ToBO(sqr);
                                    if (borr == null)
                                    {
                                        throw new Exception();
                                    }

                                    AllBorrowings.Add(borr);

                                }
                            }
                            return AllBorrowings;
                        }
                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("There was a problem, please contact your administrator");
                return null;
            }
        }

        public List<MonthBorrowStatistic> Last12MonthBorrowStatistics()
        {
            try
            {
                List<MonthBorrowStatistic> borrs = new List<MonthBorrowStatistic>();
                MonthBorrowStatistic borr ;

                using (SqlConnection sqlconn = DbHelper.GetConnection())
                {
                    using (SqlCommand command = DbHelper.Command(sqlconn, "usp_GetBorrowCountLast12Months", CommandType.StoredProcedure))
                    {
                        using (SqlDataReader sqr = command.ExecuteReader())
                        {
                            if (sqr.HasRows)
                            {
                                while (sqr.Read())
                                {
                                    borr = new MonthBorrowStatistic();
                                    borr.BorrowingsCount = (int)sqr["borrowings"];
                                    borr.Month = (int)sqr["month"];
                                    borrs.Add(borr);
                                }
                            }

                            return borrs;
                        }
                    }
                }
            }
            catch (SqlException)
            {
                return null;
            }

        }

        public List<Borrow> EmailsToExpire()
        {
            try
            {
                List<Borrow> borrs = new List<Borrow>();
                Borrow borr;
                using (SqlConnection sqlconn = DbHelper.GetConnection())
                {
                    using (SqlCommand command = DbHelper.Command(sqlconn, "usp_GetSubsBorrowReturn", CommandType.StoredProcedure))
                    {
                        using (SqlDataReader sqr = command.ExecuteReader())
                        {
                            if (sqr.HasRows)
                            {
                                while (sqr.Read())
                                {
                                    borr = new Borrow();
                                    borr._subscriber = new Subscriber();
                                    borr._subscriber.Email = sqr["Email"].ToString();
                                    borr._subscriber.Name = sqr["Name"].ToString();
                                    borr._subscriber.Name = sqr["LastName"].ToString();
                                    borr._material.Title = sqr["Title"].ToString();
                                    borr._material._Author.AuthorName = sqr["AuthorName"].ToString();
                                    borr._material._MaterialType._MaterialType = sqr["MaterialType"].ToString();
                                    borrs.Add(borr);
                                }
                            }

                            return borrs;
                        }
                    }
                }
            }
            catch (SqlException)
            {
                return null;
            }

        }


        public Borrow ToBO(SqlDataReader reader)
        {
            borr = new Borrow();
            try
            {


                borr.BorrowId = int.Parse(reader["BorrowId"].ToString());
                borr._material.MaterialId = int.Parse(reader["MaterialId"].ToString());
                borr.materialId = int.Parse(reader["MaterialId"].ToString());


                borr._material = new Material();
                borr._material.Title = reader["Title"].ToString();
                borr._material.MaterialTypeId = int.Parse(reader["MaterialTypeId"].ToString());
                borr._material._MaterialType.MaterialTypeId = int.Parse(reader["MaterialTypeId"].ToString());
                borr._material._MaterialType._MaterialType = reader["MaterialType"].ToString();
                borr._material._MaterialType.MaterialTypeDelayFee = (decimal)reader["MaterialTypeDelayFee"];
                borr._material.AuthorId = int.Parse(reader["AuthorId"].ToString());
                borr._material._Author.AuthorID = int.Parse(reader["AuthorId"].ToString());
                borr._material._Author.AuthorName = reader["AuthorName"].ToString();



                borr.SubscriberId = int.Parse(reader["SubscriberId"].ToString());
                borr._subscriber = new Subscriber();
                borr._subscriber.SubscriberId = int.Parse(reader["SubscriberId"].ToString());
                borr._subscriber.Name = reader["Name"].ToString();
                borr._subscriber.LastName = reader["LastName"].ToString();




                borr.DeadLine = (DateTime)reader["Deadline"];

                if (reader["shelfId"] != DBNull.Value)
                {
                    borr.shelfId = int.Parse(reader["ShelfId"].ToString());
                    borr._shelf.ShelfId = int.Parse(reader["ShelfId"].ToString());
                    borr._shelf.Location = reader["Location"].ToString();

                }

                if (reader["Comment"] != DBNull.Value)
                {
                    borr.Comment = reader["Comment"].ToString();
                }

                if (reader["BorrowDate"] != DBNull.Value)
                {
                    borr.BorrowDate = (DateTime)reader["BorrowDate"];
                }

                //if (reader["reservationId"] != DBNull.Value)
                //{
                //    borr.ReservationId = int.Parse(reader["ReservationId"].ToString());
                //    borr._reservation.ReservationId = int.Parse(reader["ReservationId"].ToString());
                //    borr._reservation.ReservationDate = (DateTime)reader["ReservationDate"];

                //}


                if (reader["BorrowReturnId"] != DBNull.Value)
                {
                    borr.BorrowReturnId = int.Parse(reader["BorrowReturnId"].ToString());
                    borr.BorrowReturn = new BorrowReturn();
                    borr.BorrowReturn.BorrowReturnId = int.Parse(reader["BorrowReturnId"].ToString());
                    borr.BorrowReturn.ReturnDate = (DateTime)reader["ReturnDate"];
                    if (reader["BillId"] != DBNull.Value)
                    {
                        borr.BorrowReturn.BillId = (int)reader["BillId"];
                    }

                    //if (reader["ReturnComment"] != DBNull.Value)
                    //{
                    //    borr.BorrowReturn.Comment = (string)reader["[ReturnComment]"];
                    //}

                }















                borr.InsBy = int.Parse(reader["InsBy"].ToString());
                borr.InsDate = (DateTime)reader["InsDate"];

                if (reader["UpdBy"] != DBNull.Value)
                {
                    borr.UpdBy = int.Parse(reader["UpdBy"].ToString());
                }
                if (reader["UpdDate"] != DBNull.Value)
                {
                    borr.UpdDate = (DateTime)reader["UpdDate"];
                }

                borr.UpdNo = int.Parse(reader["UpdNo"].ToString());

                return borr;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public int Update(Borrow obj)
        {
            int isUpdated = 0;

            try
            {
                int error;

                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    using (SqlCommand command = DbHelper.Command(conn, "usp_UpdateBorrow", CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("BorrowId", obj.BorrowId);
                        command.Parameters.AddWithValue("SubscriberId", obj.SubscriberId);
                        command.Parameters.AddWithValue("MaterialId", obj.materialId);
                        command.Parameters.AddWithValue("ReturnDate", obj.DeadLine);

                        if (obj.shelfId > 0)
                        {
                            command.Parameters.AddWithValue("ShelfId", obj.shelfId);
                        }

                        if (obj.ReservationId > 0)
                        {
                            command.Parameters.AddWithValue("ReservationId", obj.ReservationId);
                        }
                        

                        if (obj.Comment != string.Empty)
                        {
                            command.Parameters.AddWithValue("Comment", obj.Comment);
                        }

                        //if (obj.BorrowDate != )
                        //{
                        //    command.Parameters.AddWithValue("BorrowDate", obj.BorrowDate);
                        //}

                        command.Parameters.AddWithValue("UpdBy", obj.UpdBy);




                        isUpdated = command.ExecuteNonQuery();
                        if (isUpdated > 0)
                        {
                            return 0;
                        }
                        else
                            return -1;


                    }
                }
            }


            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
                return -1;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }
    }

}
