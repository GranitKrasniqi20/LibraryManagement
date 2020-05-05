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
    public class BillDAL : ICreate<Bill>, IUpdate<Bill>, IDelete, IRead<Bill>, IConvertToBO<Bill>
    {
        Bill bill;

        public int Add(Bill obj)
        {
            int rowsAffected = 0;
            try
            {
                using (var conn = DbHelper.GetConnection())
                {
                    using (var command = DbHelper.Command(conn, "usp_Bill_Insert", CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("SubscriberId", obj.SubscriberId);
                        command.Parameters.AddWithValue("MaterialId", obj.MaterialId);
                        command.Parameters.AddWithValue("BillType", obj.BillTypeId);
                        command.Parameters.AddWithValue("BillingDate", obj.BillingDate);
                        command.Parameters.AddWithValue("Price", obj.Price);

                        if (obj.RegistrationDate != null)
                        {
                            command.Parameters.AddWithValue("RegistrationDate", obj.RegistrationDate);
                        }

                        if (obj.ExpirationDate != null)
                        {
                            command.Parameters.AddWithValue("ExpirationDate", obj.ExpirationDate);
                        }

                        if (obj.Description != null)
                        {
                            command.Parameters.AddWithValue("Description", obj.Description);
                        }

                        command.Parameters.AddWithValue("InstBy", obj.InsBy);

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

        public int Delete(int Id)
        {
            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    using (SqlCommand command = DbHelper.Command(conn, "usp_Bill_Delete", CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("BillId", Id);

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
                    using (SqlCommand command = DbHelper.Command(conn, "usp_Bill_Read", CommandType.StoredProcedure))
                    {
                        using (SqlDataReader sqr = command.ExecuteReader())
                        {
                            if (sqr.HasRows)
                            {
                                bill = ToBO(sqr);
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
                    using (SqlCommand command = DbHelper.Command(conn, "usp_Bill_Read", CommandType.StoredProcedure))
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

            bill.BillId = int.Parse(reader["SubscriberId"].ToString());
            bill._Subscriber.SubscriberId = int.Parse(reader["SubscriberId"].ToString());
           
            if (reader["MaterialId"] != DBNull.Value)
            {
                bill._Material.MaterialId = int.Parse(reader["MaterialId"].ToString());
            }

            bill._BillType.BillTypeId = int.Parse(reader["BillTypeId"].ToString());
            bill.BillingDate = DateTime.Parse(reader["BillingDate"].ToString());
            bill.Price = decimal.Parse(reader["Price"].ToString());

            if (reader["RegistrationDate"] != DBNull.Value)
            {
                bill.RegistrationDate = DateTime.Parse(reader["RegistrationDate"].ToString());
            }

            if (reader["ExpirationDate"] != DBNull.Value)
            {
                bill.ExpirationDate = DateTime.Parse(reader["ExpirationnDate"].ToString());
            }

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
                        command.Parameters.AddWithValue("SubscriberId", obj.SubscriberId);
                        command.Parameters.AddWithValue("MaterialId", obj.MaterialId);
                        command.Parameters.AddWithValue("BillTypeId", obj.BillTypeId);
                        command.Parameters.AddWithValue("BillingDate", obj.BillingDate);
                        command.Parameters.AddWithValue("Price", obj.Price);

                        if (obj.RegistrationDate != null)
                        {
                            command.Parameters.AddWithValue("RegistrationDate", obj.RegistrationDate);
                        }

                        if (obj.ExpirationDate != null)
                        {
                            command.Parameters.AddWithValue("ExpirationDate", obj.ExpirationDate);
                        }

                        if (obj.Description != null)
                        {
                            command.Parameters.AddWithValue("Description", obj.Description);
                        }

                        command.Parameters.AddWithValue("UpdBy", obj.UpdBy);

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
    }
}
