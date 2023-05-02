using TestAPIWebApplication.Controllers;

namespace TestAPIWebApplication.Test
{
    public class ApiControllerTest
    {

        private static readonly DatabaseContext databaseContext = new DatabaseContext();
        private readonly ApiController ApiController = new ApiController(databaseContext);
        private readonly ApiFilterArgs apiFilterArgs = new ApiFilterArgs();

        [Fact]
        private void GetPersons()
        {
            var result = ApiController.GetPersons(apiFilterArgs);
            Assert.NotNull(result);
        }

        [Fact]
        private void GetPerson()
        {
            var person = ApiController.GetPerson("hqwuiehquikxhc5");
            Assert.Equal("German Titov", person.Name);
        }
    }
}
