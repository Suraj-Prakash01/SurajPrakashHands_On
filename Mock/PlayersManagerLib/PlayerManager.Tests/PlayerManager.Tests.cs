using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using PlayersManagerLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PlayerManager.Tests
{
    [TestFixture]
    public class PlayerManagerTests
    {
        Mock<IPlayerMapper> _mock;

        [OneTimeSetUp]
        public void Init()
        {
            _mock = new Mock<IPlayerMapper>(MockBehavior.Loose);
        }

        [Test]
        [TestCase("abc")]

        [TestCase("abcde")]

        public void RegisterNewPlayer_whencalled_RegisterANewPlayer(string name)
        {
            _mock.Setup(p => p.IsPlayerNameExistsInDb(name)).Returns(false);
            Player result = Player.RegisterNewPlayer(name, _mock.Object);
            NUnit.Framework.Assert.AreEqual(result.Name, name);

        }
        [Test]

        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]

       
        public void RegisterNewPlayer_whencalled_ReturnsArgumentException(string name)
        {
            
            NUnit.Framework.Assert.That(() => Player.RegisterNewPlayer(name, _mock.Object), Throws.ArgumentException);
           
        }

    }

}