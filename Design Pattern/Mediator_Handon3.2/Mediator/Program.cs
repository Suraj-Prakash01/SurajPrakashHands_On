using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var mediator = new ChatMediator();

            var user1 = new BasicUser(mediator, "user1");
            var user2 = new BasicUser(mediator, "user2");
        

            mediator.AddUser(user1);
            mediator.AddUser(user2);

            user1.SendMessage("Hello");

            Console.ReadKey();
        }
    }
}
