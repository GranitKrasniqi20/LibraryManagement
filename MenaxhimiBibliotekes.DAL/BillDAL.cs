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
                    using (var command = Connection.Command(conn, "usp_Bill_Insert", CommandType.StoredProcedure))
                    {
                        Connection.AddParameter(command, "SubscriberId", obj.SubscriberId);
                        Connection.AddParameter(command, "MaterialId", obj.MaterialId);
                        Connection.AddParameter(command, "BillType", obj.BillType);
                        Connection.AddParameter(command, "BillingDate", obj.BillingDate);
                        Connection.AddParameter(command, "RegistrationDate", obj.RegistrationDate);
                        Connection.AddParameter(command, "ExpirationDate", obj.ExpirationDate);
                        Connection.AddParameter(command, "Description", obj.Description);
                        Connection.AddParameter(command, "InstBy", obj.InsBy);

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
                    using (SqlCommand command = Connection.Command(conn, "usp_Bill_Delete", CommandType.StoredProcedure))
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

        public bool Delete(Bill obj)
        {
            throw new NotImplementedException();
        }

        public Bill Get(int Id)
        {
            try
            {
                bill = new Bill();
                using (SqlConnection conn = Connection.GetConnection())
                {
                    using (SqlCommand command = Connection.Command(conn, "usp_Bill_Read", CommandType.StoredProcedure))
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

        public Bill Get(Bill obj)
        {
            throw new NotImplementedException();
        }

        public List<Bill> GetAll()
        {
            try
            {
                List<Bill> _AllBill = new List<Bill>();
                bill = new Bill();
                using (SqlConnection conn = Connection.GetConnection())
                {
                    using (SqlCommand command = Connection.Command(conn, "usp_Bill_Read", CommandType.StoredProcedure))
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
            throw new NotImplementedException();
        }

        public bool Update(Bill obj)
        {
            throw new NotImplementedException();
        }
    }
}
