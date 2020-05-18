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
    public class BillDAL : ICreate<Bill>, IUpdate<Bill>, IDelete, IRead<Bill>, IConvertToBO<Bill>
    {
        Bill bill;
        public int Add(Bill obj)
        {
            int rowsAffected;
            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    using (SqlCommand command = DbHelper.Command(conn, "usp_Bills_Insert", CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("subscriberId", obj.SubscriberId);
                        command.Parameters.AddWithValue("billingDate", obj.BillingDate);
                        command.Parameters.AddWithValue("price", obj.Price); 
                        
                        if (obj.RegistrationDate != null)
                        {
                            command.Parameters.AddWithValue("registrationDate", obj.RegistrationDate);
                        }

                        if (obj.ExpirationDate != null)
                        {
                            command.Parameters.AddWithValue("expirationDate", obj.ExpirationDate);
                        }


                        if (obj.MaterialId != 0)
                        {
                            command.Parameters.AddWithValue("materialId", obj.MaterialId);
                        }

                        if (obj.BillTypeId != 0)
                        {
                            command.Parameters.AddWithValue("billTypeId", obj.BillTypeId);
                        }

                        if (obj.Description != null)
                        {
                            command.Parameters.AddWithValue("description", obj.Description);
                        }
                        //command.Parameters.AddWithValue("isActive", obj.IsActive);
                        command.Parameters.AddWithValue("insBy", obj.InsBy);

                        rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
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
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
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


        public Bill Get(int Id)
        {
            try
            {
                bill = new Bill();
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    using (SqlCommand command = DbHelper.Command(conn, "usp_Bills_GetByID", CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("BillId", Id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                bill = ToBO(reader);
                                if (bill == null)
                                {
                                    throw new Exception();
                                }
                            }
                            return bill;
                        }
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
        }


        public List<Bill> GetAll()
        {
            try
            {
                List<Bill> _AllBill = new List<Bill>();
                bill = new Bill(); 
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    using (SqlCommand command = DbHelper.Command(conn, "usp_Bills_GetAll", CommandType.StoredProcedure))
                    {
                        using (SqlDataReader sqr = command.ExecuteReader())
                        {
                            if (sqr.HasRows)
                            {
                                while (sqr.Read())
                                {
                                    bill = ToBO(sqr);
                                    if (bill == null)
                                    {
                                        throw new Exception();
                                    }

                                    _AllBill.Add(bill);
                                }
                            }
                            return _AllBill;
                        }
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Bill ToBO(SqlDataReader reader)
        {
            bill = new Bill();

            bill.BillId = int.Parse(reader["BillId"].ToString());
            bill.SubscriberId = int.Parse(reader["SubscriberId"].ToString());
           
            if (reader["MaterialId"] != DBNull.Value)
            {
                bill.MaterialId = int.Parse(reader["MaterialId"].ToString());
            }

            bill.BillTypeId = int.Parse(reader["BillTypeId"].ToString());
            bill.BillingDate = DateTime.Parse(reader["BillingDate"].ToString());
            bill.Price = decimal.Parse(reader["Price"].ToString());

            if (reader["RegistrationDate"] != DBNull.Value)
            {
                bill.RegistrationDate = DateTime.Parse(reader["RegistrationDate"].ToString());
            }

            if (reader["ExpirationDate"] != DBNull.Value)
            {
                bill.ExpirationDate = DateTime.Parse(reader["ExpirationDate"].ToString());
            }

            //bill.IsActive = (bool)reader["IsActive"];

            bill.InsBy = int.Parse(reader["InsBy"].ToString());
            bill.InsDate = (DateTime)reader["InsDate"];

            if (reader["UpdBy"] != DBNull.Value)
            {
                bill.UpdBy = int.Parse(reader["UpdBy"].ToString());
            }
            if (reader["UpdDate"] != DBNull.Value)
            {
                bill.UpdDate = (DateTime)reader["UpdDate"];
            }

            bill.UpdNo = int.Parse(reader["UpdNo"].ToString());

            return bill;
        }

        public int Update(Bill obj)
        {
            int rowsAffected = 0;
            try
            {
                using (var conn = DbHelper.GetConnection())
                {
                    using (var command = DbHelper.Command(conn, "usp_Bill_Update", CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("subscriberId", obj.SubscriberId);

                        if (obj.MaterialId != 0)
                        {
                            command.Parameters.AddWithValue("materialId", obj.MaterialId);
                        }

                        if (obj.BillTypeId !=0 )
                        {
                            command.Parameters.AddWithValue("billTypeId", obj.BillTypeId);
                        }
                        command.Parameters.AddWithValue("billingDate", obj.BillingDate);
                        command.Parameters.AddWithValue("price", obj.Price);

                        if (obj.RegistrationDate != null)
                        {
                            command.Parameters.AddWithValue("registrationDate", obj.RegistrationDate);
                        }

                        if (obj.ExpirationDate != null)
                        {
                            command.Parameters.AddWithValue("expirationDate", obj.ExpirationDate);
                        }

                        if (obj.Description != null)
                        {
                            command.Parameters.AddWithValue("description", obj.Description);
                        }

                        command.Parameters.AddWithValue("isActive", obj.IsActive);
                        command.Parameters.AddWithValue("updBy", obj.UpdBy);

                        rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
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

        public int MaxBillId()
        {
            try
            {
                bill = new Bill();
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    using (SqlCommand command = DbHelper.Command(conn, "SELECT MAX(BillId) as Id FROM Bills; ",
                        CommandType.Text))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                bill.BillId = int.Parse(reader["Id"].ToString());
                                return bill.BillId;
                            }
                            else
                            {
                                return 0;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                return 0;
            }

        }
    }
}
