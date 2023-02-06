namespace HGPolloLovers.Domain.Contracts
{
    public interface ISplitterService
    {
        CustomerResponseDTO SplitterByLetter(IEnumerable<CustomerDTO> customers);
    }
}
