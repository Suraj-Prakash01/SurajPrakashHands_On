using System;

namespace ChainOfResponsibility
{
    class Supervisor : ILeaveRequestHandler
    {
        public ILeaveRequestHandler NextHandler 
        { 
            get { return new ProjectManager(); } 
        }

        public void HandleRequest(LeaveRequest leaveRequest)
        {
            if (leaveRequest.LeaveDays <= 3)
            {
                Console.WriteLine("Leave approved by Superior");
            }
            else
            {
                NextHandler.HandleRequest(leaveRequest);
            }
        }
    }
}
