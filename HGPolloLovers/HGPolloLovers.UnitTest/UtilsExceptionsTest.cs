using HGPolloLovers.Infrastructure.Utils.Exceptions;
using System.Net;

namespace HGPolloLovers.UnitTest
{
    public class UtilsExceptionsTest
    {
        [Theory]
        [InlineData(HttpStatusCode.InternalServerError)]
        public void ThowInternalServerError(HttpStatusCode statusCode)
        {
            var exception = new InternalServerErrorException("Internal Server Error");
            Assert.Equal(exception.StatusCode, statusCode);
        }
    }
}