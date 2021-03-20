using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter Mercedes or Audi");
            string type = Console.ReadLine();

            var factory = FactoryGetter(type);

            var headlight = factory.MakeHeadLight();
            Console.WriteLine(headlight);

            var tire = factory.MakeTire();
            Console.WriteLine(tire);

            Console.ReadKey();
        }

        static Factory FactoryGetter(string type)
        {
            if (type == "Mercedes")
            {
                return new MercedesFactory();
              
            }
            else if (type == "Audi")
            {
                return new AudiFactory();
            }
            else
            {
                return null;
            }
        }
    }
}
