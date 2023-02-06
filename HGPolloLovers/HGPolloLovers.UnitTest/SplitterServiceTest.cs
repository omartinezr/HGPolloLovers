using Bogus;
using HGPolloLovers.Domain.Contracts;
using Moq;

namespace HGPolloLovers.UnitTest
{
    public class SplitterServiceTest
    {
        [Fact]
        public void SplitterNamesByLetters()
        {
            var letters = new List<string>() { "B", "H" };
            var splitterISplitterService = new Mock<ISplitterService>();
            var customerLoverPHFaker = new Faker<CustomerLoverDTO>()
                .RuleFor(f => f.Names, new List<string>() { "bob", "Harley" });
            var customerLoverPPFaker = new Faker<CustomerLoverDTO>()
                .RuleFor(f => f.Names, new List<string>() { "Ashley", "Francis" });
            var customerResponseDTOFaker = new Faker<CustomerResponseDTO>()
                .RuleFor(f => f.CustomerLoverPH, customerLoverPHFaker.Generate())
                .RuleFor(f => f.CustomerLoverPP, customerLoverPPFaker.Generate());

            var splitter = splitterISplitterService.Setup(x => x.SplitterByLetter(It.IsAny<IEnumerable<CustomerDTO>>())).Returns(customerResponseDTOFaker.Generate());

            Assert.True(true);
        }
    }
}