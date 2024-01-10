using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Inheritance
{
    internal class ItalianChef : Chef //this class inherit all the Chef class atributes(Extends Chef Class)
    {
      
        public void MakesPasta()
        {
            Console.WriteLine("Italian Chef Made Pasta");
        }

        //Lets override the function in the SuperClass(Chef)
        public override void MakeSpecialDish()
        {
            // base.MakeSpecialDish();
            Console.WriteLine("Italian Chef Made a special italian dish");
        }
    }
}
