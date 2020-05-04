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
    public class BillDAL : ICrud<Bill>, IConvertToBO<Bill>
    {
        private Bill bill;

        public bool Add(Bill obj)
        {
            int rowsAffected = 0;
            try
            {
                using (var conn = Connection.GetConnection())
                {
                    using (var command = Connection.Command(conn, "usp_Bills_Insert", CommandType.StoredProcedure))
                    {
                        Connection.AddParameter(command, "SubscriberId", obj.SubscriberId);
                        Connection.AddParameter(command, "MaterialId", obj.MaterialId);
                        Connection.AddParameter(command, "BillType", obj.BillType);
                        Connection.AddParameter(command, "BillingDate", obj.BillingDate);
                        Connection.AddParameter(command, "RegistrationDate", obj.RegistrationDate);
                        Connection.AddParameter(command, "ExpirationDate", obj.ExpirationDate);
                        Connection.AddParameter(command, "Description", obj.Description);
                        Connection.AddParameter(command, "InstBy", obj.InsBy);

                        SqlParameter sqlparam = Connection.OutputParameters("BillId", SqlDbType.Int);

                        Connection.AddParameter(command, sqlparam);

                        rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
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
            try
            {
                using (SqlConnection conn = Connection.GetConnection())
                {
                    using (SqlCommand command = Connection.Command(conn, "usp_Bills_Delete", CommandType.StoredProcedure))
                    {
                        Connection.AddParameter(command, "BillId", Id);

                        int Affected = command.ExecuteNonQuery();

                        if (Affected > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception)
            {

                return false;
            }
        }


        public Bill Get(int Id)
        {
            try
            {
                bill = new Bill();
                using (SqlConnection conn = Connection.GetConnection())
                {
                    using (SqlCommand command = Connection.Command(conn, "usp_Bills_GetByID", CommandType.StoredProcedure))
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
                using (SqlConnection conn = Connection.GetConnection())
                {
                    using (SqlCommand command = Connection.Command(conn, "usp_Bills_GetAll", CommandType.StoredProcedure))
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

        public bool Update(Bill obj)
        {
            int rowsAffected = 0;
            try
            {
                using (var conn = Connection.GetConnection())
                {
                    using (var command = Connection.Command(conn, "usp_Bills_Update", CommandType.StoredProcedure))
                    {
                        Connection.AddParameter(command, "SubscriberId", obj.SubscriberId);
                        Connection.AddParameter(command, "MaterialId", obj.MaterialId);
                        Connection.AddParameter(command, "BillType", obj.BillType);
                        Connection.AddParameter(command, "BillingDate", obj.BillingDate);//Nuk ka nevoje me e dergu, d.faturimit duhet fshire
                        Connection.AddParameter(command, "RegistrationDate", obj.RegistrationDate);//Nuk ka nevoje me e dergu, d.regj. duhet fshire
                        Connection.AddParameter(command, "ExpirationDate", obj.ExpirationDate);//duhet me dergu parametrin numrin e muajve
                        Connection.AddParameter(command, "Description", obj.Description);
                        Connection.AddParameter(command, "UpdBy", obj.UpdBy);

                        rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
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
    }
}
