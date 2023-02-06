using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HGPolloLovers.Infrastructure.Utils.Exceptions
{
    public class NotFoundErrorException : CustomException
    {
        public NotFoundErrorException(string message)
        : base(message, null, HttpStatusCode.NotFound)
        {
        }
    }
}
