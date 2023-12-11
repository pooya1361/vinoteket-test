using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VinoteketTestWebApp.Models
{
    public class Product
    {
        public int id { get; set; }
        public string sku { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string image_url { get; set; }
        public int price { get; set; }
        public string url { get; set; }
    }
}