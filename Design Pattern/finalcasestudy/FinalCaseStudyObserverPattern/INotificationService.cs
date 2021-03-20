using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCaseStudyObserverPattern
{
     public interface INotificationService
    {
        void AddSubscriber(INotificationObserver member);
        void RemoveSubscriber(INotificationObserver member);

        void GetNotify(Event e);

        void ChangeTicketsToAboveHundred(Event e);
    }
}
