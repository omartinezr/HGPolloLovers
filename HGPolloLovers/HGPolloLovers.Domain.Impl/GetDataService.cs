using HGPolloLovers.Domain.Contracts;
using HGPolloLovers.Repository.Contrats;

namespace HGPolloLovers.Domain.Impl
{
    public class GetDataService : IGetDataService
    {
        private readonly IGetDataFromRepository _getDataFromRepository;
        
        public GetDataService(IGetDataFromRepository getDataFromRepository)
        {
            _getDataFromRepository = getDataFromRepository;
            
        }

        public async Task<IEnumerable<CustomerDTO>> GetDataAsync()
        {
            var customersDTO = new List<CustomerDTO>();
            var customers = await _getDataFromRepository.GetDataFromRepositoryAsync();
            foreach (var customer in customers)
            {
                customersDTO.Add(new CustomerDTO() { Name = customer.Name });
            }
            return customersDTO;
        }
    }
}