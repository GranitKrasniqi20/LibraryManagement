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
    public class ReservationBLL : ICreate<Reservation>, IUpdate<Reservation>, IDelete, IRead<Reservation>
    {
        ReservationDAL reservationDAL = new ReservationDAL();

        public int Add(Reservation obj)
        {
            return reservationDAL.Add(obj);
        }

        public int Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Reservation Get(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Update(Reservation obj)
        {
            throw new NotImplementedException();
        }
    }
}
