using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestAPIWebApplication.Controllers
{
    [ApiController]
    [Route("ApiController")]
    public class ApiController : Controller
    {
        // POST: ApiController
        [HttpPost("GetData")]
        public async void SetData()
        {
            await GetSourceData.SetData();
        }

        // GET: ApiController/GetPersons
        [HttpGet("GetPersons")]
        public List<Person> GetPersons()
        {
            return GetSourceData.GetData();
        }

        // GET: ApiController/GetPerson/5
        [HttpGet("GetPerson")]
        public ActionResult GetPerson()
        {
            return View();
        }
    }
}
