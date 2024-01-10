using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Inheritance
{
    internal class Chef
    {
        

        public void MakeChicken()
        {
            Console.WriteLine("Chef Made Chicken ");
            
        }

        public void MakeSalad()
        {
            Console.WriteLine("Chef made a Salad");
        }

        public virtual void MakeSpecialDish()  //This method can be overriden(modified) by the subclass(ItalianChef)
        {
            Console.WriteLine("Chef made a special dish");
        }




    }
}
