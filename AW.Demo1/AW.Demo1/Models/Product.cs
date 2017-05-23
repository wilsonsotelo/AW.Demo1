using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AW.Demo1.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string name { get; set; }
        public decimal Price { get; set; }
        public decimal Stock { get; set; }
    }
}