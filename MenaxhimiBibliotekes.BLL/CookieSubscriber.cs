using MenaxhimiBibliotekes.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiBibliotekes.BLL
{
    public class CookieSubscriber
    {
        public static int ID { get; set; }
        public static string FullName { get; set; }
        public static string PersonalNumber { get; set; }
        public static string SubscriptionPlan { get; set; }
        public static DateTime BillingDate { get; set; }
        public static DateTime ExpirationDate { get; set; }
        public static decimal Price { get; set; }
        public static string Cashier { get; set; }
    }
}
