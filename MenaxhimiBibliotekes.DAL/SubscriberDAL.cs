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
            //int error;
            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    using (SqlCommand command = DbHelper.Command(conn, "usp_Subscribers_Insert", CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("Name", obj.Name);
                        command.Parameters.AddWithValue("LastName", obj.LastName);
                        command.Parameters.AddWithValue("Address", obj.Address);

                        if (obj.Birthday != null)
                        {
                            command.Parameters.AddWithValue("Birthday", obj.Birthday);
                        }

                        if (obj.PersonalNo != null)
                        {
                            command.Parameters.AddWithValue("PersonalNumber", obj.PersonalNo);
                        }

                        command.Parameters.AddWithValue("PhoneNumber", obj.PhoneNo);
                        command.Parameters.AddWithValue("Email", obj.Email);
                        command.Parameters.AddWithValue("Gender", obj.Gender);
                        command.Parameters.AddWithValue("EndDate", obj.ExpirationDate);
                        command.Parameters.AddWithValue("IsActive", obj.IsActive);
                        command.Parameters.AddWithValue("InsBy", obj.InsBy);

                        MessageBox.Show(
                            "name:" + obj.Name + "\n" +
                            "lastName:" + obj.LastName + "\n" +
                            "adres:" + obj.Address + "\n" +
                            "birth:" + obj.Birthday + "\n" +
                            "persNo:" + obj.PersonalNo + "\n" +
                            "phoneNo:" + obj.PhoneNo + "\n" +
                            "email:" + obj.Email + "\n" +
                            "gender:" + obj.Gender + "\n" +
                            "expDate:" + obj.ExpirationDate + "\n" +
                            "isActiv:" + obj.IsActive + "\n" +
                            "insBy:" + obj.InsBy + "\n" , "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        isInserted = command.ExecuteNonQuery();//ketu eshte errori

                        if (isInserted > 0)
                        {
                            return 1;

                        }
                        else
                        {
                            return -1;
                        }

                        //SqlParameter sqlpa = new SqlParameter();
                        //sqlpa.ParameterName = "Error";
                        //sqlpa.SqlDbType = SqlDbType.Int;
                        //sqlpa.Direction = ParameterDirection.Output;
                        //command.Parameters.Add(sqlpa);
                        //command.ExecuteNonQuery();//errori
                        //error = (int)sqlpa.Value;

                        //return error;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Problem me DAL-in", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
        }
         

        public int Delete(int Id)
        {
            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    using (SqlCommand command = DbHelper.Command(conn, "usp_Subsriber_Delete", CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("SubscriberId", Id);
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
                    using (SqlCommand command = DbHelper.Command(conn, "usp_Subscriber_Read", CommandType.StoredProcedure))
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


        public List<Subscriber> GetAll()
        {
            try
            {
                List<Subscriber> _AllSubscriber = new List<Subscriber>();
                subscriber = new Subscriber();
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    using (SqlCommand command = DbHelper.Command(conn, "usp_Subscriber_Read", CommandType.StoredProcedure))
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
                subscriber.ExpirationDate = DateTime.Parse(reader["ExpirationDate"].ToString());


               

                subscriber.InsBy = int.Parse(reader["InsBy"].ToString());
                subscriber.InsDate = (DateTime)reader["InsDate"];

                if (reader["UpdBy"] != DBNull.Value)
                {
                    subscriber.UpdBy = int.Parse(reader["UpdBy"].ToString());
                }
                if (reader["UpdDate"] != DBNull.Value)
                {
                    subscriber.UpdDate = (DateTime)reader["UpdDate"];
                }

                subscriber.UpdNo = int.Parse(reader["UpdNo"].ToString());





                return subscriber;
            }
            catch (Exception)
            {

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
                    using (var command = DbHelper.Command(conn, "usp_Subscriber_Update", CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("SubscriberId", obj.SubscriberId);
                        command.Parameters.AddWithValue("Name", obj.Name);
                        command.Parameters.AddWithValue("LastName", obj.LastName);
                        command.Parameters.AddWithValue("Address", obj.Address);

                        if (obj.Birthday != null)
                        {
                            command.Parameters.AddWithValue("Birthday", obj.Birthday);
                        }

                        if (obj.PersonalNo != null)
                        {
                            command.Parameters.AddWithValue("PersonalNo", obj.PersonalNo);
                        }

                        command.Parameters.AddWithValue("PhoneNo", obj.PhoneNo);
                        command.Parameters.AddWithValue("Email", obj.Email);
                        command.Parameters.AddWithValue("Gender", obj.Gender);
                        command.Parameters.AddWithValue("ExpirationDate", obj.ExpirationDate);
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
