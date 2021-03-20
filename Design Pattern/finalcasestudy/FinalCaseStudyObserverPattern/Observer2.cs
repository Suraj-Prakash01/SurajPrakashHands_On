using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCaseStudyObserverPattern
{
    public class Observer2 : INotificationObserver
    {
        public string Name => "Observer2";

        public void getNotification(Event e)
        {
            if(e.Tickets>=100)
            Console.WriteLine("Event Details\nName :"+e.Name+"\nTicketsBooked:"+e.Tickets+"\nLocation:"+e.Location+" - recieved by "+ Name); 
        }

      
    }
}
