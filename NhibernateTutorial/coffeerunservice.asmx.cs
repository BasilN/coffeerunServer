using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Net.Http;
using NhibernateTutorial.Controllers;
using NhibernateTutorial.Models;

namespace NhibernateTutorial
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://coffeerun.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {
        CoffeeShopController coffeeShopController = new CoffeeShopController();
        

        [WebMethod]
        public string getCoffeeShops()
        {
            return coffeeShopController.getCoffeeShops();
        }

        [WebMethod]
        public string getCoffeeShopWithId(int id)
        {
            return coffeeShopController.getCoffeeShopWithId(id);
        }
        
        [WebMethod]
        public string insertCoffeeShop(CoffeeShop shop)
        {
            return coffeeShopController.Post(shop);
        }
        
        public string helloworld()
        {
            return "testing return";
        }
    }
}