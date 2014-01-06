using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NHibernate;
using NHibernate.Linq;
using Newtonsoft.Json;
using NhibernateTutorial.Models;

namespace NhibernateTutorial.Controllers
{
    public class CoffeeShopsController : ApiController
    {
        // GET api/<controller>
        public HttpResponseMessage Get()
        {
            using (ISession session = NHibernateSession.OpenSession())
            {
                var coffeeShops = session.Query<CoffeeShop>().ToList();
                var serializedCoffeeShops = new List<string>();

                return Request.CreateResponse<IEnumerable<CoffeeShop>>(HttpStatusCode.OK, coffeeShops);
            }
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}