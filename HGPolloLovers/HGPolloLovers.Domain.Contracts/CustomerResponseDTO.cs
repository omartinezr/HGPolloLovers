namespace HGPolloLovers.Domain.Contracts
{
    public class CustomerResponseDTO
    {
        public CustomerLoverDTO CustomerLoverPH { get; set; } = new CustomerLoverDTO();
        public CustomerLoverDTO CustomerLoverPP { get; set; } = new CustomerLoverDTO();
    }

    public class CustomerLoverDTO 
    {
        public List<string> Names { get; set; } = new List<string>();
    }

}
