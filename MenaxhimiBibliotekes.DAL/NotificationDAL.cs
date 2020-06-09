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
    public class NotificationDAL : ICreate<Notification>,  IRead<Notification>, IConvertToBO<Notification>
    {
        private Notification notification;


        public int Add(Notification obj)
        {
            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    using (SqlCommand command = DbHelper.Command(conn, "CreateNotification", CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("@Message", obj.Message);

                        command.Parameters.AddWithValue("@Date", obj.Date);

                        command.Parameters.AddWithValue("@Category", obj.Category);

                        //---

                        int rows = command.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            return 0;
                        }
                        else
                        {

                            return 1;

                        }
                    }
                }
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public Notification Get(int Id)
        {
            throw new NotImplementedException();
        }
        public List<Notification> GetAll()
        {
            try
            {
                List<Notification> notificationList = new List<Notification>();
                notification = new Notification();

                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    using (SqlCommand command = DbHelper.Command(conn, "GetAllNotifications", CommandType.StoredProcedure))
                    {
                        using (SqlDataReader sqr = command.ExecuteReader())
                        {
                            if (sqr.HasRows)
                            {
                                while (sqr.Read())
                                {

                                    notification = ToBO(sqr);
                                    if (notification == null)
                                    {
                                        throw new Exception();
                                    }

                                    notificationList.Add(notification);
                                }
                            }

                            return notificationList;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public Notification ToBO(SqlDataReader reader)
        {
            notification = new Notification();

            try
            {
                notification.ID = int.Parse(reader["ID"].ToString());
                notification.Message = reader["NotificationMessage"].ToString();
                notification.Date = (DateTime)reader["NotificationDate"];
                notification.Category = reader["NotificationCategory"].ToString();

                return notification;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
