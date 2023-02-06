using HGPolloLovers.Application.Contrats;
using Microsoft.AspNetCore.Mvc;

namespace HGPolloLovers.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PolloLoversController : ControllerBase
    {
        private readonly ILogger<PolloLoversController> _logger;
        private readonly ICustomersApplication _customersApplication;

        public PolloLoversController(ILogger<PolloLoversController> logger, ICustomersApplication customersApplication)
        {
            _logger= logger;
            _customersApplication = customersApplication;
        }

        [HttpGet]
        public async Task<CustomerResponse> Index()
        {
            return await _customersApplication.GetCustomers();
        }
    }
}
