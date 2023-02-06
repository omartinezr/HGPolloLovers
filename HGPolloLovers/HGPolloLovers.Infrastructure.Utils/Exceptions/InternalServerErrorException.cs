using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HGPolloLovers.Infrastructure.Utils.Exceptions
{
    public class InternalServerErrorException : CustomException
    {
        public InternalServerErrorException(string message, List<string>? errors = default)
        : base(message, errors, HttpStatusCode.InternalServerError)
        {
        }
    }
}
