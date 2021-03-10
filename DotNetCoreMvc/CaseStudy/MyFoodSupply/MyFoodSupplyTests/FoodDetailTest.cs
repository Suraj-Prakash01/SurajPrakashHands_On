using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFoodSupply;

namespace MyFoodSupplyTests
{
    [TestFixture]
    public class FoodDetailTest
    {
        Program p;
        [OneTimeSetUp]
        public void init()
        {
            p = new Program();
        }
       
        [Test]
        [TestCase("Name1",1,"2022/6/3",500.00)]
        public void CreateFoodDetail_WhenCalled_ReturnFoodDetailObject(string name, int dishType, DateTime expiryDate, double price)
        {
            
            FoodDetail result = p.CreateFoodDetail(name, dishType, expiryDate, price);

            Assert.That(result.Name, Is.EqualTo(name));
            Assert.That(result.DishType, Is.EqualTo((FoodDetail.Category)dishType));
            Assert.That(result.ExpiryDate, Is.EqualTo(expiryDate));
            Assert.That(result.Price, Is.EqualTo(price));
        }

        [Test]
        [TestCase(null, 1, "2022/6/3", 500.00)]
        [TestCase("", 1, "2022/6/3", 500.00)]
        public void CreateFoodDetail_WhenFoodItemNameIsNull_ThrowsException(string name, int dishType, DateTime expiryDate, double price)
        {
            var exception= Assert.Throws<Exception>(() => p.CreateFoodDetail(name, dishType, expiryDate, price));
            Assert.AreEqual("Dish name cannot be empty. Please provide valid value", exception.Message);
        }

        [Test]
        [TestCase("Name1", 1, "2022/6/3", -500.00)]
        public void CreateFoodDetail_WhenPriceIsLessThanZero_ThrowsException(string name, int dishType, DateTime expiryDate, double price)
        {
            var exception = Assert.Throws<Exception>(() => p.CreateFoodDetail(name, dishType, expiryDate, price));
            Assert.AreEqual("Incorrect value for dish price. Please provide valid value", exception.Message);
        }
        [Test]
        [TestCase("Name1", 1, "2019/6/3", 500.00)]
        public void CreateFoodDetail_WhenExpiryDateIsLessThanCurrentDate_ThrowsException(string name, int dishType, DateTime expiryDate, double price)
        {
            var exception = Assert.Throws<Exception>(() => p.CreateFoodDetail(name, dishType, expiryDate, price));
            Assert.AreEqual("Incorrect expiry date. Please provide valid value", exception.Message);
        }
    }
}
