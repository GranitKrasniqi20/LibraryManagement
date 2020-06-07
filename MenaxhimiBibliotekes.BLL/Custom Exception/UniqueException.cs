using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace MenaxhimiBibliotekes.BLL.Custom_Exception
{
    class UniqueException : Exception
    {
        public UniqueException(string message): base(message)
        {

        }
        public UniqueException():base()
        {

        }
        public UniqueException(string message,Exception innerExcetion):base(message,innerExcetion)
        {

        }
        public UniqueException(SerializationInfo info, StreamingContext context):base(info, context)
        {
             
        }

    }
}
