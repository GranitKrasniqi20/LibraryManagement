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
    public class BillTypeDAL : ICrud<BillType>, IConvertToBO<BillType>
    {
        private BillType billType;

        public bool Add(BillType obj)
        {
            int isInserted = 0;
            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    using (SqlCommand command = DbHelper.Command(conn, "usp_BillType_Insert", CommandType.StoredProcedure))
                    {
                        Connection.AddParameter(command, "BillType", obj._billType);
                        Connection.AddParameter(command, "InsBy", obj.InsBy);

                        SqlParameter sqlparam = Connection.OutputParameters("BillTypeId", SqlDbType.Int);

                        Connection.AddParameter(command, sqlparam);
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
            try
            {
                using (SqlConnection conn = Connection.GetConnection())
                {
                    using (SqlCommand command = Connection.Command(conn, "usp_BillType_Delete", CommandType.StoredProcedure))
                    {
                        Connection.AddParameter(command, "BillTypeId", Id);

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

        public bool Delete(BillType obj)
        {
            throw new NotImplementedException();
        }

        public BillType Get(int Id)
        {
            try
            {
                billType = new BillType();
                using (SqlConnection conn = Connection.GetConnection())
                {
                    using (SqlCommand command = Connection.Command(conn, "usp_BillType_GetByID", CommandType.StoredProcedure))
                    {
                        using (SqlDataReader sqr = command.ExecuteReader())
                        {
                            if (sqr.HasRows)
                            {
                                billType = ToBO(sqr);
                                if (billType == null)
                                {
                                    throw new Exception();
                                }
                            }
                            return billType;
                        }
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<BillType> GetAll()
        {
            List<BillType> _AllBillType = new List<BillType>();

            billType = new BillType();

            using (SqlConnection sqlconn = DbHelper.GetConnection())
            {
                using (SqlCommand command = Connection.Command(sqlconn, "usp_BillType_Read", CommandType.StoredProcedure))
                {
                    using (SqlDataReader sqr = command.ExecuteReader())
                    {
                        if (sqr.HasRows)
                        {
                            while (sqr.Read())
                            {

                                billType = ToBO(sqr);
                                if (billType == null)
                                {
                                    throw new Exception();
                                }
                                
                                _AllBillType.Add(billType);
                            }
                        }
                        return _AllBillType;
                    }
                }
            }
        }

        public BillType ToBO(SqlDataReader reader)
        {
            try
            {
                billType = new BillType();

                billType.BillTypeId = (int)reader["BillTypeId"];
                billType._BillType = reader["BillType"].ToString();

                billType.InsBy = int.Parse(reader["InsBy"].ToString());
                billType.InsDate = (DateTime)reader["InsDate"];

                if (reader["UpdBy"] != DBNull.Value)
                {
                    billType.UpdBy = int.Parse(reader["UpdBy"].ToString());
                }
                if (reader["UpdDate"] != DBNull.Value)
                {
                    billType.UpdDate = (DateTime)reader["UpdDate"];
                }

                billType.UpdNo = int.Parse(reader["UpdNo"].ToString());
                return billType;
            }
            
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(BillType obj)
        {
            int isUpdated = 0;
            using (SqlConnection conn = Connection.GetConnection())
            {
                using (SqlCommand command = Connection.Command(conn, "usp_BillType_Update", CommandType.StoredProcedure))
                {
                    Connection.AddParameter(command, "MaterialTypeId", obj.BillTypeId);
                    Connection.AddParameter(command, "MaterialType", obj._BillType);
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
