namespace HGPolloLovers.Application.Contrats
{
    public class CustomerResponse
    {
        public CustomerLoverResponse CustomerLovePH { get; set; } = new CustomerLoverResponse();
        public CustomerLoverResponse CustomerLovePP { get; set; } = new CustomerLoverResponse();
    }

    public class CustomerLoverResponse
    {
        public List<string> Names { get; set; } = new List<string>();
    }
}
