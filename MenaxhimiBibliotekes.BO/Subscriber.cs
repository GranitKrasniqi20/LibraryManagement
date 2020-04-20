using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiBibliotekes.BO
{
    public class Subscriber
    {
        //Komenti GK
        public int SubscriberId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PersonalNo { get; set; }
        public string Email { get; set; }
        public bool Gender { get; set; }
        public DateTime SubscribeExpireDate { get; set; }
    }
}
