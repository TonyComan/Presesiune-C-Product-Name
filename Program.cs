using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Test_Presesiune
{
    internal class Program
    {
        static void Main(string[] args)
        {
            



           Product p1= new Product(name:"mouse" , price:100);
            Product p2 = new Product("lamp", 100);
            Product p3 = new Product(price: 150, name: "chair");

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            if (p1.CostsBetween(50, 200))
            {
                Console.WriteLine($"{p1} , costs between 50 and 200");
            }

            p1.Price = -50;
            Console.WriteLine(p1);

           
            
            Console.WriteLine(p2);

            Console.WriteLine(p2); // output : The product 'lamp; has the price 100lei
            MyListOfProducts myListOfProducts = new MyListOfProducts(); // user-defined list
            myListOfProducts.Add(p1);
            myListOfProducts.Add(p2);
            myListOfProducts.Add(p3);
            myListOfProducts.Add(new Product("mouse", 25));

            myListOfProducts.Sort(); //interface
                                    //criteria ascending by name and two products with the same name are arranged in ascending order by price

            Console.WriteLine(myListOfProducts);
            // prints the list
            //output
            //The product 'chair' has the price 150 lei
            //The product 'lamp' has the price 100 lei
            //The product 'mouse' has the price  25 lei
            //The product 'mouse' has the price 100 lei


            Console.ReadKey();
        }
    }
}
