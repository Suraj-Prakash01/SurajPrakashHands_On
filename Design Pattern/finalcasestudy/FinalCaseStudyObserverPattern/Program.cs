using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCaseStudyObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Observer1 ob1 = new Observer1();

            Observer2 ob2 = new Observer2();
            INotificationService service = new NotificationService();

            service.AddSubscriber(ob1);
            service.AddSubscriber(ob2);
          
            Console.WriteLine("___________________________________________________");

            List<Event> elist = new List<Event>()
            {
                new Event(){Name="Independence Day", Tickets=80, Location="Hyderabad"},
                new Event(){Name="Mens Day", Tickets=20, Location="Chennai"},
                new Event(){Name="Freshers Party", Tickets=120, Location="Pune"},
            };

            service.ChangeTicketsToAboveHundred(elist[0]);
          

            Console.ReadLine();
        }
    }
}
