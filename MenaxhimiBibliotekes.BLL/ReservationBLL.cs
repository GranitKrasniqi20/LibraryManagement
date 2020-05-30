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
            return reservationDAL.Delete(Id);
        }

        public Reservation Get(int Id)
        {
            return reservationDAL.Get(Id);
        }

        public List<Reservation> GetAll()
        {
            return reservationDAL.GetAll();
        }

        public int Update(Reservation obj)
        {
            return reservationDAL.Update(obj);
        }
    }
}
