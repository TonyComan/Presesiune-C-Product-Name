using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.ConstrainedExecution;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Test_Presesiune
{
    internal class Product : IComparable<Product>
    {
        private string Name { get; set; } 
        public int Price { get; set; }

       

        //constructor
        public Product(string name , int price) {
            Name = name;
            Price = price;

        }


        public bool CostsBetween(int a , int b)
        {
            return (Price >= a && Price <= b); 
                

        }

        public int CompareTo(Product  other)
        {
            return Price.CompareTo(other.Price);
        }

        public override string ToString()
        {
            return $"{Price} si  {Name}"  ;
        }
    }
}
