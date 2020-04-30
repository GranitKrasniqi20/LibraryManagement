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
        BillType billType;

        public bool Add(BillType obj)
        {
            int isInserted = 0;
            try
            {
                using (SqlConnection conn = Connection.GetConnection())
                {
                    using (SqlCommand command = Connection.Command(conn, "usp_BillType_Insert", CommandType.StoredProcedure))
                    {
                        Connection.AddParameter(command, "BillType", obj._billType);
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

        public bool Delete(BillType obj)
        {
            throw new NotImplementedException();
        }

        public BillType Get(int Id)
        {
            throw new NotImplementedException();
        }

        public BillType Get(BillType obj)
        {
            throw new NotImplementedException();
        }

        public List<BillType> GetAll()
        {
            List<BillType> _AllBillType = new List<BillType>();

            billType = new BillType();

            using (SqlConnection sqlconn = Connection.GetConnection())
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
            throw new NotImplementedException();
        }

        public bool Update(BillType obj)
        {
            throw new NotImplementedException();
        }
    }
}
