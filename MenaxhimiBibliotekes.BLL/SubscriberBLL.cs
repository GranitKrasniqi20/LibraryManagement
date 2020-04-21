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
    public class SubscriberBLL : ICrud<Subscriber>
    {
        SubscriberDAL _subscriberDAL = new SubscriberDAL();

        public bool Add(Subscriber obj)
        {
            return _subscriberDAL.Add(obj);
        }

        public bool Delete(int Id)
        {
            return _subscriberDAL.Delete(Id);
        }

        public bool Delete(Subscriber obj)
        {
            throw new NotImplementedException();
        }

        public Subscriber Get(int Id)
        {
            return Get(Id);
        }

        public Subscriber Get(Subscriber obj)
        {
            return Get(obj);
        }

        public List<Subscriber> GetAll()
        {
            return GetAll();
        }

        public bool Update(Subscriber obj)
        {
            return _subscriberDAL.Update(obj);
        }
    }
}
