using HGPolloLovers.Application.Contrats;
using HGPolloLovers.Domain.Contracts;

namespace HGPolloLovers.Application.Impl
{
    public class CustomersApplication : ICustomersApplication
    {
        private readonly IGetDataService _getDataService;
        private readonly ISplitterService _splitterService;

        public CustomersApplication(IGetDataService getDataService, ISplitterService splitterService)
        {
            _getDataService = getDataService;
            _splitterService= splitterService;
        }

        public async Task<CustomerResponse> GetCustomers()
        {
            var customerResponse = new CustomerResponse();

            var customers = await _getDataService.GetDataAsync();
            var namesSplitedByName = _splitterService.SplitterByLetter(customers);
            
            customerResponse.CustomerLovePP.Names.AddRange(namesSplitedByName.CustomerLoverPP.Names);
            customerResponse.CustomerLovePH.Names.AddRange(namesSplitedByName.CustomerLoverPH.Names);

            return customerResponse;
        }
    }
}