using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCaseStudyObserverPattern
{
    public class NotificationService: INotificationService
    {
        List<INotificationObserver> team = new List<INotificationObserver>();

        public void AddSubscriber(INotificationObserver mem)
        {
            team.Add(mem);
       
        }

        public void GetNotify(Event e)
        {
            foreach(var t in team)
            {
                t.getNotification(e);
            }
        }

        public void RemoveSubscriber(INotificationObserver mem)
        {
            team.Remove(mem);
          
        }

        public void ChangeTicketsToAboveHundred(Event e)
        {
            e.Tickets = 120;

            GetNotify(e);
        }
    }
}
