﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiBibliotekes.BO.Interfaces
{
    public interface IChangePassword
    {

        int ChangePassword(int UserId, string password, int UpdBy);

    }
}
