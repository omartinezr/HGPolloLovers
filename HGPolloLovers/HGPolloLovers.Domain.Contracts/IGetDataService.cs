namespace HGPolloLovers.Domain.Contracts
{
    public interface IGetDataService
    {
        Task<IEnumerable<CustomerDTO>> GetDataAsync();
    }
}