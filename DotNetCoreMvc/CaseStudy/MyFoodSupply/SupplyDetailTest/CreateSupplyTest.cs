using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFoodSupply;

namespace SupplyDetailTest
{
    [TestFixture]
    public class CreateSupplyTest
    {
        Program p;
        FoodDetail f= new FoodDetail()
        {
            Name = "name1",
            DishType = (FoodDetail.Category)1,
            Price = 500,
            ExpiryDate = new DateTime(2022,6,3)
        };
        [OneTimeSetUp]
        public void init()
        {
            p = new Program();
        }
        [Test]
        [TestCase(1,"2021/6/3","Rohit",50.0)]
        public void CreateSupplyDetail_WhenCalled_ReturnSupplyDetailObject(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
        {
            SupplyDetail result = p.CreateSupplyDetail(foodItemCount, requestDate, sellerName,packingCharge,f);
            
            Assert.That(result.Count, Is.EqualTo(foodItemCount));
            Assert.That(result.RequestDate, Is.EqualTo(requestDate));
            Assert.That(result.SellerName, Is.EqualTo(sellerName));
            //Assert.That(result.PackingCharge, Is.EqualTo(packingCharge));
            Assert.That(result.FoodItem, Is.EqualTo(f));
        }
        [Test]
        [TestCase(-1, "2021/6/3", "Rohit", 50.0)]
        public void CreateSupplyDetail_WhenFoodCountLessThanZero_ThrowsException(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
        {
            var exception = Assert.Throws<Exception>(() => p.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, f));
            Assert.AreEqual("Incorrect food item count. Please check",exception.Message);
        }

        [Test]
        [TestCase(1, "2020/6/3", "Rohit", 50.0)]
        public void CreateSupplyDetail_WhenRequestDateLessThanCurrentDate_ThrowsException(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
        {
            var exception = Assert.Throws<Exception>(() => p.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, f));
            Assert.AreEqual("Incorrect food request date. Please provide valid value", exception.Message);
        }

        [Test]
        [TestCase(1, "2021/6/3", "Rohit", 50.0)]
        public void CreateSupplyDetail_WhenFoodItemObjectIsNull_ReturnNull(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
        {
            var result =  p.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, null);
            Assert.AreEqual(null,result) ;
        }
    }
}
