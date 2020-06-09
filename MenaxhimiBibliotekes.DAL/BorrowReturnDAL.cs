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
    public class BorrowReturnDAL: ICreate<BorrowReturn>, IUpdate<BorrowReturn>, IDelete, IRead<BorrowReturn>, IConvertToBO<BorrowReturn>
    {
        BorrowReturn br = new BorrowReturn();


        public int Add(BorrowReturn obj)
        {

            int error;
            try
            {

                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    using (SqlCommand command = DbHelper.Command(conn, "usp_CreateBorrowReturns", CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("BorrowId", obj.BorrowId);
                        command.Parameters.AddWithValue("ReturnDate", obj.ReturnDate);



                        if (obj.BillId > 0)
                        {
                            command.Parameters.AddWithValue("BillId", obj.BillId);
                        }

                        if (obj.Comment != string.Empty)
                        {
                            command.Parameters.AddWithValue("Comment", obj.Comment);
                        }


                        command.Parameters.AddWithValue("InsBy", obj.InsBy);



                        return command.ExecuteNonQuery();
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
                    using (SqlCommand command = DbHelper.Command(conn, "usp_DelteBorrowReturn", CommandType.StoredProcedure))
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
        public BorrowReturn Get(int Id)
        {
            try
            {
                br = new BorrowReturn();

                using (SqlConnection sqlconn = DbHelper.GetConnection())
                {
                    using (SqlCommand command = DbHelper.Command(sqlconn, "usp_GetBorrowReturnByBorrowId", CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("BorrowId", Id);

                        using (SqlDataReader sqr = command.ExecuteReader())
                        {


                            if (sqr.Read())
                            {

                                br = ToBO(sqr);
                                if (br == null)
                                {
                                    throw new Exception();
                                }
                                return br;


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
        public List<BorrowReturn> GetAll()
        {
            try
            {
                List<BorrowReturn> AllBorrowings = new List<BorrowReturn>();
                br = new BorrowReturn();

                using (SqlConnection sqlconn = DbHelper.GetConnection())
                {
                    using (SqlCommand command = DbHelper.Command(sqlconn, "usp_GetAllBorrowReturn", CommandType.StoredProcedure))
                    {
                        using (SqlDataReader sqr = command.ExecuteReader())
                        {
                            if (sqr.HasRows)
                            {
                                while (sqr.Read())
                                {

                                    br = ToBO(sqr);
                                    if (br == null)
                                    {
                                        throw new Exception();
                                    }

                                    AllBorrowings.Add(br);

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
        public BorrowReturn ToBO(SqlDataReader reader)
        {
            br = new BorrowReturn();
            try
            {
                br.BorrowId = int.Parse(reader["BorrowId"].ToString());
                br.BorrowReturnId = int.Parse(reader["BorrowReturnId"].ToString());

                br.ReturnDate = (DateTime)reader["ReturnDate"];

                if (reader["BillId"] != DBNull.Value)
                {
                    br.BillId = int.Parse(reader["BillId"].ToString());


                }

                if (reader["Comment"] != DBNull.Value)
                {
                    br.Comment = reader["Comment"].ToString();
                }


                br.InsBy = int.Parse(reader["InsBy"].ToString());
                br.InsDate = (DateTime)reader["InsDate"];

                if (reader["UpdBy"] != DBNull.Value)
                {
                    br.UpdBy = int.Parse(reader["UpdBy"].ToString());
                }
                if (reader["UpdDate"] != DBNull.Value)
                {
                    br.UpdDate = (DateTime)reader["UpdDate"];
                }

                br.UpdNo = int.Parse(reader["UpdNo"].ToString());

                return br;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
                ;
            }
        }
        public int Update(BorrowReturn obj)
        {


            int error;
            try
            {

                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    using (SqlCommand command = DbHelper.Command(conn, "usp_UpdateBorrowReturn", CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("BorrowReturnId", obj.BorrowReturnId);
                        command.Parameters.AddWithValue("BorrowId", obj.BorrowId);
                        command.Parameters.AddWithValue("ReturnDate", obj.ReturnDate);




                        if (obj.BillId > 0)
                        {
                            command.Parameters.AddWithValue("BillId", obj.BillId);
                        }

                        if (obj.Comment != string.Empty)
                        {
                            command.Parameters.AddWithValue("Comment", obj.Comment);
                        }


                        command.Parameters.AddWithValue("UpdBy", obj.UpdBy);

                        //SqlParameter sqlpa = new SqlParameter();
                        //sqlpa.ParameterName = "Error";
                        //sqlpa.SqlDbType = SqlDbType.Int;
                        //sqlpa.Direction = ParameterDirection.Output;

                        //command.Parameters.Add(sqlpa);

                        //command.ExecuteNonQuery();
                        //error = (int)sqlpa.Value;

                        return command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }
    }
}
