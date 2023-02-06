namespace HGPolloLovers.Application.Contrats
{
    public interface ICustomersApplication
    {
        Task<CustomerResponse> GetCustomers();
    }
}