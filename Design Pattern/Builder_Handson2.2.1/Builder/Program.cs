using System;

namespace Builder
{
    public class Program
    {
        public static void Main()
        {
            var shop = new Director_Shop();

            var childBuilder = new childBuilder();
            var adultBuilder = new AdultBuilder();

            shop.Construct(childBuilder);
            Product childPackage = childBuilder.GetResult();
            Console.WriteLine("ChildPackage");
            childPackage.Show();

            Console.WriteLine("AdultPackage");
            shop.Construct(adultBuilder);
            Product adultPackage = adultBuilder.GetResult();
            adultPackage.Show();

            Console.ReadLine();
        }
    }
}