using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate;
using NHibernate.Cfg;

namespace NhibernateTutorial.Models
{
    public class NHibernateSession
    {
        public static ISession OpenSession()
        {
            var configuration = new Configuration();
            
            var configurationPath = 
                HttpContext.Current.Server.MapPath(@"~\Models\NHibernate\hibernate.cfg.xml");
            configuration.Configure(configurationPath);
            
            var coffeeShopConfigurationFile = 
                HttpContext.Current.Server.MapPath(@"~\Mappings\CoffeeShop.hbm.xml");
            configuration.AddFile(coffeeShopConfigurationFile);
            
            ISessionFactory sessionFactory = configuration.BuildSessionFactory();
            
            return sessionFactory.OpenSession();
        }
    }
}