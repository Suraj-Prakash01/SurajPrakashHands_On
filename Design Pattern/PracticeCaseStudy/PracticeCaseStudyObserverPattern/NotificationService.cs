using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCaseStudyObserverPattern
{
    public class NotificationService: INotificationService
    {
        List<INotificationObserver> observers = new List<INotificationObserver>();

        public void AddSubscriber(INotificationObserver observer)
        {
            observers.Add(observer);
                Console.WriteLine(observer.Name+ " is added\n\n List of Subscribers");
            foreach(var ob in observers)
            {
                Console.WriteLine(ob.Name);
            }
            Console.WriteLine("--------------------------------------------------------");
        }

        public void NotifySubscriber()
        {
            foreach (var ob in observers)
            {
                ob.OnServerDown();
            }
            Console.WriteLine("--------------------------------------------------------");

        }

        public void RemoveSubscriber(INotificationObserver observer)
        {
            
            observers.Remove(observer);
                Console.WriteLine(observer.Name+ " is removed\n\n List of Subscribers");
            foreach (var ob in observers)
            {
                Console.WriteLine(ob.Name);
            }
            Console.WriteLine("---------------------------------------");
        }
    }
}
