using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace MenaxhimiBibliotekes.DAL
{
    class Connection
    {
        private static string ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            
    }
}
