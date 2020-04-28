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
    public class SubscriberDAL : ICrud<Subscriber>, IConvertToBO<Subscriber>
    {
        private Subscriber subscriber;

        public bool Add(Subscriber obj)
        {
            int isInserted = 0;
            try
            {
                using (SqlConnection conn = Connection.GetConnection())
                {
                    using (SqlCommand command = Connection.Command(conn, "usp_Subscriber_Insert", CommandType.StoredProcedure))
                    {
                        Connection.AddParameter(command, "Name", obj.Name);
                        Connection.AddParameter(command, "LastName", obj.LastName);
                        Connection.AddParameter(command, "Address", obj.Address);
                        Connection.AddParameter(command, "Birthday", obj.Birthday);
                        Connection.AddParameter(command, "PersonalNo", obj.PersonalNo);
                        Connection.AddParameter(command, "PhoneNo", obj.PhoneNo);
                        Connection.AddParameter(command, "Email", obj.Email);
                        Connection.AddParameter(command, "Gender", obj.Gender);
                        Connection.AddParameter(command, "EndDate", obj.EndDate);
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
            try
            {
                using (SqlConnection conn = Connection.GetConnection())
                {
                    using (SqlCommand command = Connection.Command(conn, "usp_Subsriber_Delete", CommandType.StoredProcedure))
                    {
                        Connection.AddParameter(command, "SubscriberId", Id);
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

        public bool Delete(Subscriber obj)
        {
            throw new NotImplementedException();
        }

        public Subscriber Get(int Id)
        {
            try
            {
                subscriber = new Subscriber();
                using (SqlConnection conn = Connection.GetConnection())
                {
                    using (SqlCommand command = Connection.Command(conn, "usp_Subscriber_Read", CommandType.StoredProcedure))
                    {
                        using (SqlDataReader sqr = command.ExecuteReader())
                        {
                            if (sqr.HasRows)
                            {
                                subscriber = ToBO(sqr);
                                if (subscriber == null)
                                {
                                    throw new Exception();
                                }
                            }
                            return subscriber;
                        }
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }

        }

        public Subscriber Get(Subscriber obj)
        {
            throw new NotImplementedException();
        }

        public List<Subscriber> GetAll()
        {
            try
            {
                List<Subscriber> _AllSubscriber = new List<Subscriber>();
                subscriber = new Subscriber();
                using (SqlConnection conn = Connection.GetConnection())
                {
                    using (SqlCommand command = Connection.Command(conn, "usp_Subscriber_Read", CommandType.StoredProcedure))
                    {
                        using (SqlDataReader sqr = command.ExecuteReader())
                        {
                            if (sqr.HasRows)
                            {
                                while (sqr.Read())
                                {
                                    subscriber = ToBO(sqr);
                                    if (subscriber == null)
                                    {
                                        throw new Exception();
                                    }

                                    _AllSubscriber.Add(subscriber);
}
                            }
                            return _AllSubscriber;
                        }
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Subscriber ToBO(SqlDataReader reader)
        {
            try
            {
                subscriber = new Subscriber();

                subscriber.SubscriberId = int.Parse(reader["SubscriberId"].ToString());
                subscriber.Name = reader["Name"].ToString();
                subscriber.LastName = reader["LastName"].ToString();
                subscriber.Address = reader["Address"].ToString();

                if (reader["Birthday"] != DBNull.Value)
                {
                    subscriber.Birthday = DateTime.Parse(reader["Birthday"].ToString());
                }

                if (reader["PersonalNo"] != DBNull.Value)
                {
                    subscriber.PersonalNo = reader["Birthday"].ToString();
                }

                subscriber.PhoneNo = reader["PhoneNo"].ToString();
                subscriber.Email = reader["Email"].ToString();
                subscriber.EndDate = DateTime.Parse(reader["EndDate"].ToString());


               

                subscriber.InsBy = int.Parse(reader["InsBy"].ToString());
                subscriber.InsDate = (DateTime)reader["InsDate"];
                subscriber.UpdBy = int.Parse(reader["UpdBy"].ToString());
                subscriber.UpdDate = (DateTime)reader["UpdDate"];
                subscriber.UpdNo = int.Parse(reader["UpdNo"].ToString());





                return subscriber;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public bool Update(Subscriber obj)
        {
            int rowsAffected = 0;
            try
            {
                using (var conn = Connection.GetConnection())
                {
                    using (var command = Connection.Command(conn, "usp_Subscriber_Update", CommandType.StoredProcedure))
                    {
                        Connection.AddParameter(command, "Name", obj.Name);
                        Connection.AddParameter(command, "LastName", obj.LastName);
                        Connection.AddParameter(command, "Address", obj.Address);
                        Connection.AddParameter(command, "Birthday", obj.Birthday);
                        Connection.AddParameter(command, "PersonalNo", obj.PersonalNo);
                        Connection.AddParameter(command, "PhoneNo", obj.PhoneNo);
                        Connection.AddParameter(command, "Email", obj.Email);
                        Connection.AddParameter(command, "Gender", obj.Gender);
                        Connection.AddParameter(command, "EndDate", obj.EndDate);
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
