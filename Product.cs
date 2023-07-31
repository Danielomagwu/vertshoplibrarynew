using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vertshoplibrary
{
    public  class Product
    {
        public string Productid { get; set; }
        public string Desscription { get; set; }   
        public string  Category { get; set; }
        public int Quntity { get; set; }
        public double Price { get; set; }


        public Product(string productid, string desscription, string category, int quntity, double price)
        {
            Productid = productid;
            Desscription = desscription;
            Category = category;
            Quntity = quntity;
            Price = price;
        }
    }
}
