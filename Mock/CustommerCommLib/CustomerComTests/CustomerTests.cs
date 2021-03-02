using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using CustommerCommLib;

namespace CustomerComTests
{
    [TestFixture]
    public class CustomerTests
    {
        Mock<IMailSender> mock;
        CustomerComm customer;
        [Test]
        [TestCase("surajp1401@gmail.com","Suraj",true)]
        public void SendMailToCustomer_WhenCalled_ReturnTrue(string toaddress,string name,bool expected)
        {
            mock = new Mock<IMailSender>();
            mock.Setup(p => p.SendMail(toaddress, name)).Returns(expected);
            customer = new CustomerComm(mock.Object);
            bool actual = customer.SendMailToCustomer(toaddress, name);
            Assert.AreEqual(expected, actual);
        }

    }
}
