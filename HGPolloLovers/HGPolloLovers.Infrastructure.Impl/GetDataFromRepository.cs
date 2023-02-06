using HGPolloLovers.Domain.Contracts;
using HGPolloLovers.Infrastructure.Utils.Exceptions;
using HGPolloLovers.Repository.Contrats;
using Microsoft.Extensions.Configuration;

namespace HGPolloLovers.Infrastructure.Impl
{
    public class GetDataFromRepository : IGetDataFromRepository
    {
        private readonly string _urlOriginFile;
        private readonly string _urlFileName;

        public GetDataFromRepository(IConfiguration config)
        {
            _urlOriginFile = config["Repository:UrlOrigin"];
            _urlFileName = config["Repository:FileName"];
        }

        public async Task<IEnumerable<CustomerEntity>> GetDataFromRepositoryAsync()
        {
            var customers = new List<CustomerEntity>();
            var fileDownloaded = await DonwloadFile(_urlOriginFile, _urlFileName);

            foreach (var file in fileDownloaded.Split("\n"))
            {
                customers.Add(new CustomerEntity() { Name = file });
            }
            return customers;
        }

        private async Task<string> DonwloadFile(string originUrl, string fileName)
        {
            var uri = new Uri($"{originUrl}{fileName}");
            var client = new HttpClient();
            var response = await client.GetAsync(uri);
            
            return response.IsSuccessStatusCode 
                ? await response.Content.ReadAsStringAsync() 
                : throw new NotFoundErrorException("File not found");
        }
    }
}