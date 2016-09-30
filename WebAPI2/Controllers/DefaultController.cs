using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebAPI2.Controllers
{
    public class DefaultController : ApiController
    {
        // GET: api/Default
        [Route("api/users")]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public IEnumerable<User> Get()
        {
            return new[]
            {
                new User
                {
                    FirstName = "Bob",
                    LastName = "Smith",
                    Id = 1
                },
                new User
                {
                    FirstName = "Jane",
                    LastName = "Andrews",
                    Id = 2
                },
                new User
                {
                    FirstName = "Pat",
                    LastName = "Jones",
                    Id = 3
                }
            };
        }

        public class User
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
    }
}
