using System;


namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = DBConn.GetInstance();
            Console.WriteLine(db.ToString());
            Console.ReadKey();
        }
    }
}
