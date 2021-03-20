using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var leaveRequest = new LeaveRequest() 
            { 
                Employee = "Karan",
                LeaveDays = 0
            };

            var supervisor = new Supervisor();
            supervisor.HandleRequest(leaveRequest);

            Console.ReadKey();
        }
    }
}
