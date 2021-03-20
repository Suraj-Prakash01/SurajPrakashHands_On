using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCaseStudyObserverPattern
{
    public class Observer1 : INotificationObserver
    {
        public string Name => "Observer1";

        public void getNotification(Event e)
        {

            Console.WriteLine("Event Details\nName :" + e.Name + "\nTicketsBooked:" + e.Tickets + "\nLocation:" + e.Location + " - recieved by " + Name);
        }
    }
}
