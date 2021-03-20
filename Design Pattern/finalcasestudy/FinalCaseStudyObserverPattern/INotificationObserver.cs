using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCaseStudyObserverPattern
{
    public interface INotificationObserver
    {
        string Name { get; }

        void getNotification(Event e);

    }
}
