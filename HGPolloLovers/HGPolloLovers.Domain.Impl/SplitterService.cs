using HGPolloLovers.Domain.Contracts;
using Microsoft.Extensions.Configuration;

namespace HGPolloLovers.Domain.Impl
{
    public class SplitterService : ISplitterService
    {
        private readonly IEnumerable<string> _lettersLovePH;

        public SplitterService(IConfiguration configuration)
        {
            _lettersLovePH = configuration["LetersLovePH"].Split(";").ToList();
        }

        public CustomerResponseDTO SplitterByLetter(IEnumerable<CustomerDTO> customers)
        {
            var customersDTO = new CustomerResponseDTO();
            foreach (var customer in customers)
            {
                var nameToCharArray = customer.Name.ToCharArray();
                var nameWithExpecificLetter = nameToCharArray.Where(s => _lettersLovePH.Contains(s.ToString().ToUpper())).Select(s => s);
                if (nameWithExpecificLetter != null && nameWithExpecificLetter.Any())
                    customersDTO.CustomerLoverPH.Names.Add(customer.Name);
                else
                    customersDTO.CustomerLoverPP.Names.Add(customer.Name);
            }

            return customersDTO;
        }
    }
}
