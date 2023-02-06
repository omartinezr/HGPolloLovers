using HGPolloLovers.Domain.Contracts;

namespace HGPolloLovers.Repository.Contrats
{
    public interface IGetDataFromRepository
    {
        Task<IEnumerable<CustomerEntity>> GetDataFromRepositoryAsync();
    }
}