﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiBibliotekes.BO.Interfaces
{
    public interface IConvertToBO<T>
    {
        T ToBO(SqlDataReader reader);
    }
}
