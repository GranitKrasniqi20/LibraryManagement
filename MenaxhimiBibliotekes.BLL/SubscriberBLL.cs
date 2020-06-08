using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenaxhimiBibliotekes.BO.Interfaces;
using MenaxhimiBibliotekes.BO;
using MenaxhimiBibliotekes.DAL;

namespace MenaxhimiBibliotekes.BLL
{
    public class SubscriberBLL : ICreate<Subscriber>, IUpdate<Subscriber>, IDelete, IRead<Subscriber>
    {
        SubscriberDAL subscriberDAL = new SubscriberDAL();

        public int Add(Subscriber obj)
        {
            return subscriberDAL.Add(obj);
        }

        public int Delete(int Id)
        {
            return subscriberDAL.Delete(Id);
        }

        public Subscriber Get(int Id)
        {
            return subscriberDAL.Get(Id);
        }

        public List<Subscriber> GetAll()
        {
            return subscriberDAL.GetAll();
        }

        public List<Subscriber> GetAllExpiredSubscribers()
        {
            return subscriberDAL.GetAllExpiredSubscribers();
        }

        public int Update(Subscriber obj)
        {
            return subscriberDAL.Update(obj);
        }

        public int MaxSubscriberId()
        {
            return subscriberDAL.MaxSubscriberId();
        }


        public void GetExpiredSubscribersEmail()
        {
            EmailService es = new EmailService();
            foreach (var item in subscriberDAL.GetExpiredSubscribersEmail())
            {
                if (item != null && item.Length > 0)
                {
                    es.SendMails(item, "Your subscibe will expire in 5 days", "your abonation will expire in 5 days blla blla");
                }
            }
        }

        public void SubscriberRegisterdEmail(Subscriber sub)
        {

            EmailService es = new EmailService();

            es.SendMails(sub.Email, $"Welcome to Stack Books", $"Congratulations  you registered to Stack Book," +
                $"we hope you will enjoy reading our Books. Your subscription will end at {sub.ExpirationDate}. We will you all the bests," +
                $"Stack Books staff");

        }


        public IEnumerable<Subscriber> BestSubscribers()
        {
            return subscriberDAL.BestSubscribers();
        }

        #region
        public int NumberOfActiveSubscribers()
        {
            return subscriberDAL.NumberOfActiveSubscribers();
        }

        public int NumberOfNonActiveSubscribers()
        {
            return subscriberDAL.NumberOfNonActiveSubscribers();
        }

        public List<Subscriber> Get5LastSubscribers()
        {
            return subscriberDAL.Get5LastSubscribers();
        }

        public List<Subscriber> Get10LastSubscribers()
        {
            return subscriberDAL.Get10LastSubscribers();
        }

        #endregion

    }
}
