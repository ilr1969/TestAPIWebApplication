using Microsoft.AspNetCore.Mvc;

namespace TestAPIWebApplication.Controllers
{
    [ApiController]
    [Route("ApiController")]
    public class ApiController : Controller
    {
        private readonly DatabaseContext _databaseContext;

        public ApiController(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        // GET: ApiController/GetPersons
        [HttpGet("GetPersons")]
        public List<PersonAllView> GetPersons([FromQuery] ApiFilterArgs apiFilterArgs)
        {
            var page = apiFilterArgs.Page;
            var itemsToDisplay = apiFilterArgs.PageSize;
            var itemsToSkip = (page - 1) * itemsToDisplay;
            var minAge = int.Parse(apiFilterArgs._Ages.Split("-")[0]);
            var maxAge = int.Parse(apiFilterArgs._Ages.Split("-")[1]);
            List<int> ages = new List<int>();
            for (int i = minAge; i <= maxAge; i++)
            {
                ages.Add(i);
            }
            return _databaseContext.Persons
                .Where(x => ages.Contains(x.Age))
                .Where(x => apiFilterArgs.Sex.Contains(x.Sex))
                .Skip(itemsToSkip)
                .Take(itemsToDisplay)
                .Select(x => new PersonAllView(x.Id, x.Name, x.Sex))
                .ToList();
        }

        // GET: ApiController/GetPerson/5
        [HttpGet("GetPerson")]
        public Person GetPerson(string id)
        {
            return _databaseContext.Persons.FirstOrDefault(person => person.Id == id);
        }
    }
}
