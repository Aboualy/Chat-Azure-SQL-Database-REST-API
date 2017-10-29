using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Backend.Connector;
using Backend.Models;
namespace Backend.Controllers
{
    public class UserController : ApiController
    {
        // GET: api/User
        public List<User> Get()
        {
            UserDbConnector dbc = new UserDbConnector();
            return dbc.GetUsers();
        }

        // GET: api/User/5
        // GET: api/Person/5
        public User Get(int id)
        {
            return null;
        }


        // POST: api/User
        public void Post(User user)
        {
            UserDbConnector dbc = new UserDbConnector();
            dbc.SaveUser(user);
        }

        // PUT: api/User/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/User/5
        public void Delete(int id)
        {
        }
    }
}
