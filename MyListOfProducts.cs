using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Test_Presesiune
{
    internal class MyListOfProducts:List<Product>
    {
        public override string ToString()
        {
            Sort();
            string text = "";
            foreach (Product prod in this)
            {
                text += $"{prod} - {Environment.NewLine}";
            }
            return text;
        }


    }
}
