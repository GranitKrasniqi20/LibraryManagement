using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiBibliotekes.BO
{
    public class User:Audit
    {
        public int UserID { get; set; }
        public bool IsActive { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int RoleID { get; set; }
        public virtual Role _role { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User()
        {
            _role = new Role();
        }
    }
}
