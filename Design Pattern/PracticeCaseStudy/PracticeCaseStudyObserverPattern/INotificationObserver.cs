using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCaseStudyObserverPattern
{
    public interface INotificationObserver
    {
         string Name { get; }

        void OnServerDown();
    }
}
