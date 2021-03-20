using System;

namespace ChainOfResponsibility
{
    class HR : ILeaveRequestHandler
    {
        public ILeaveRequestHandler NextHandler 
        { 
            get { return null; } 
        }

        public void HandleRequest(LeaveRequest leaveRequest)
        {
            Console.WriteLine("Leave approved by HR.");
        }
    }
}
