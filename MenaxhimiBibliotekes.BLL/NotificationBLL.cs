using MenaxhimiBibliotekes.BO;
using MenaxhimiBibliotekes.BO.Interfaces;
using MenaxhimiBibliotekes.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiBibliotekes.BLL
{
    public class NotificationBLL : ICreate<Notification>, IRead<Notification>
    {
        NotificationDAL notificationDAL = new NotificationDAL();

        public int Add(Notification obj)
        {
            return notificationDAL.Add(obj);
        }

        public Notification Get(int Id)
        {
            return notificationDAL.Get(Id);
        }

        public List<Notification> GetAll()
        {
            return notificationDAL.GetAll();
        }
    }
}
