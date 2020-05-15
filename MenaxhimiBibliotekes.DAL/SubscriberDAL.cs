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
    public class SubscriberDAL : ICreate<Subscriber>, IUpdate<Subscriber>, IDelete, IRead<Subscriber>, IConvertToBO<Subscriber>
    {
        Subscriber subscriber;

        public int Add(Subscriber obj)
        {
            int isInserted ;
            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    using (SqlCommand command = DbHelper.Command(conn, "usp_Subscribers_Insert", CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("name", obj.Name);
                        command.Parameters.AddWithValue("lastName", obj.LastName);
                        command.Parameters.AddWithValue("address", obj.Address);

                        if (obj.Birthday != null)
                        {
                            command.Parameters.AddWithValue("birthday", obj.Birthday);
                        }

                        if (obj.PersonalNo != null)
                        {
                            command.Parameters.AddWithValue("personalNumber", obj.PersonalNo);
                        }

                        command.Parameters.AddWithValue("phoneNumber", obj.PhoneNo);
                        command.Parameters.AddWithValue("email", obj.Email);
                        command.Parameters.AddWithValue("gender", obj.Gender);
                        command.Parameters.AddWithValue("expirationDate", obj.ExpirationDate);
                        command.Parameters.AddWithValue("isActive", obj.IsActive);
                        command.Parameters.AddWithValue("insBy", obj.InsBy);

                        isInserted = command.ExecuteNonQuery();
                        if (isInserted > 0)
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
                MessageBox.Show("Problem me DAL-in", "Fail!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
        }
         

        public int Delete(int Id)
        {
            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    using (SqlCommand command = DbHelper.Command(conn, "usp_Subscribers_Delete", CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("subscriberId", Id);
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



        public Subscriber Get(int Id)
        {
            try
            {
                subscriber = new Subscriber();
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    using (SqlCommand command = DbHelper.Command(conn, "usp_Subscribers_GetByID", CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("subscriberId", Id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            //    if (sqr.HasRows)
                            //    {
                            //        subscriber = ToBO(sqr);
                            //        if (subscriber == null)
                            //        {
                            //            throw new Exception();
                            //        }
                            //    }
                            //    return subscriber;

                            if (reader.HasRows)
                            {
                                return ToBO(reader);
                            }
                            else
                            {
                                return null;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }

        }


        public List<Subscriber> GetAll()
        {
            try
            {
                List<Subscriber> _AllSubscriber = new List<Subscriber>();
                subscriber = new Subscriber();
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    using (SqlCommand command = DbHelper.Command(conn, "usp_Subscribers_GetAll", CommandType.StoredProcedure))
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

                //ERRORI I MADH 
                subscriber.SubscriberId = int.Parse(reader["SubscriberId"].ToString());
                subscriber.Name = reader["Name"].ToString();
                subscriber.LastName = reader["LastName"].ToString();
                subscriber.Address = reader["Address"].ToString();

                if (reader["Birthday"] != DBNull.Value)
                {
                    subscriber.Birthday = DateTime.Parse(reader["Birthday"].ToString());
                }

                if (reader["PersonalNumber"] != DBNull.Value)
                {
                    subscriber.PersonalNo = reader["PersonalNumber"].ToString();
                }

                subscriber.PhoneNo = reader["PhoneNumber"].ToString();
                subscriber.Email = reader["Email"].ToString();
                subscriber.Gender = char.Parse(reader["Gender"].ToString());

                subscriber.ExpirationDate = DateTime.Parse(reader["EndDate"].ToString());

                subscriber.IsActive = (bool)reader["IsActive"];

                subscriber.InsBy = int.Parse(reader["InsBy"].ToString());
                subscriber.InsDate = (DateTime)reader["InsDate"];

                if (reader["UpdBy"] != DBNull.Value)
                {
                    subscriber.UpdBy = int.Parse(reader["UpdBy"].ToString());
                }
                if (reader["UpdDate"] != DBNull.Value)
                {
                    subscriber.UpdDate = DateTime.Parse(reader["UpdDate"].ToString());
                }

                subscriber.UpdNo = int.Parse(reader["UpdNo"].ToString());

                //subscriber.SubscriberId = 20;subscriber.Name = "ee"; subscriber.LastName = "ee";subscriber.Address = "rrr";
                //subscriber.Birthday = DateTime.Parse("2020/05/10");subscriber.PersonalNo = "rr"; subscriber.PhoneNo = "rr";
                //subscriber.Email = "rrr"; subscriber.Gender = 'F'; subscriber.ExpirationDate = DateTime.Parse("2020 - 06 - 10");

                return subscriber;
            }

            catch (Exception)
            {
                MessageBox.Show("Problem me ToBo", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }

        public int Update(Subscriber obj)
        {
            int rowsAffected = 0;
            try
            {
                using (var conn = DbHelper.GetConnection())
                {
                    using (var command = DbHelper.Command(conn, "usp_Subscribers_Update", CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("subscriberId", obj.SubscriberId);
                        command.Parameters.AddWithValue("name", obj.Name);
                        command.Parameters.AddWithValue("lastName", obj.LastName);
                        command.Parameters.AddWithValue("address", obj.Address);

                        if (obj.Birthday != null)
                        {
                            command.Parameters.AddWithValue("birthday", obj.Birthday);
                        }

                        if (obj.PersonalNo != null)
                        {
                            command.Parameters.AddWithValue("personalNumber", obj.PersonalNo);
                        }

                        command.Parameters.AddWithValue("phoneNumber", obj.PhoneNo);
                        command.Parameters.AddWithValue("email", obj.Email);
                        command.Parameters.AddWithValue("gender", obj.Gender);
                        command.Parameters.AddWithValue("expirationDate", obj.ExpirationDate);
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
    }
}
