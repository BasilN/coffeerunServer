using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NhibernateTutorial.Models
{
    public class CoffeeShop
    {
        public virtual int id { get; set; }
        public virtual string name { get; set; }
        public virtual int raitng { get; set; }
        public virtual int contactId { get; set; }
        public virtual int imagesId { get; set; }
    }
}