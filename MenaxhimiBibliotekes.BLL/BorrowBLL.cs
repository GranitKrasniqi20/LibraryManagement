using MenaxhimiBibliotekes.BO;
using MenaxhimiBibliotekes.BO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenaxhimiBibliotekes.DAL;

namespace MenaxhimiBibliotekes.BLL
{
   public class BorrowBLL : ICreate<Borrow>, IUpdate<Borrow>, IDelete, IRead<Borrow>
    {

        BorrowDAL bd = new BorrowDAL();
        EmailService es;
        public int Add(Borrow obj)
        {
            return bd.Add(obj);
        }

        public int Delete(int Id)
        {
            return bd.Delete(Id);
        }

        public Borrow Get(int Id)
        {

            return bd.Get(Id);
        }

        public List<Borrow> GetAll()
        {
            return bd.GetAll();
        }

        public int Update(Borrow obj)
        {
            return bd.Update(obj);
        }
        public void EmailBorrowsToReturn()
        {

             es = new EmailService();
            List<Borrow> emails = bd.EmailsToExpire();
            if (emails.Count > 0)
            {
                foreach (var item in bd.EmailsToExpire())
                {
                        es.SendMails(item._subscriber.Email, "Your Borrow is about to expire", $"Your {item._material._MaterialType._MaterialType} will expire in 5 days," +
                            $"we hope you enjoyed reading {item._material.Title} from author {item._material._Author.AuthorName}");
                }
            }



        }

        public List<MonthBorrowStatistic> Last12MonthBorrowStatistics()
        {


            return bd.Last12MonthBorrowStatistics();
        }

            public void EmailBorrows(Borrow b)
        {
             es = new EmailService();
                    es.SendMails(b._subscriber.Email, $"Your have borrowed {b._material.Title}", $"Your {b._material._MaterialType._MaterialType} will expire at {b.DeadLine.ToShortDateString()}," +
                        $"we hope you will enjoy reading {b._material.Title} from author {b._material._Author.AuthorName}"
                        );
        }

    }
}
