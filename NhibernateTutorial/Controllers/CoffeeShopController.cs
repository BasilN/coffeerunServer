using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate;
using NHibernate.Linq;
using NhibernateTutorial.Models;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;


namespace NhibernateTutorial.Controllers
{
    public class CoffeeShopController
    {

        public string getCoffeeShops()
        {
            using (ISession session = NHibernateSession.OpenSession())
            {
                var coffeeShops = session.Query<CoffeeShop>().ToList();
                var serializedCoffeeShops = new List<string>();

                return JsonConvert.SerializeObject(coffeeShops);
            }
        }

        public string getCoffeeShopWithId(int id)
        {
            using (ISession session = NHibernateSession.OpenSession())
            {
                var coffeeShop = session.Get<CoffeeShop>(id);
                return JsonConvert.SerializeObject(coffeeShop);
            }
        }
        
        public string Post(CoffeeShop shop)
        {
            using (ISession session = NHibernateSession.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction()){
                    session.Save(shop);
                    transaction.Commit();
                   // var msg = new HttpResponseMessage(HttpStatusCode.Created);
                    return "msg";
                }
            }
        }

    }
}