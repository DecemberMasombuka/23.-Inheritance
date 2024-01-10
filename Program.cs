using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Chef chef = new Chef();
            chef.MakeChicken();
            Console.WriteLine();

            ItalianChef italianChef = new ItalianChef();

            italianChef.MakeChicken(); //Calls the method in Chef
            italianChef.MakeSpecialDish(); //Overriden method
            italianChef.MakesPasta();
            italianChef.MakeSalad();



            Console.Read();


        }
    }
}
