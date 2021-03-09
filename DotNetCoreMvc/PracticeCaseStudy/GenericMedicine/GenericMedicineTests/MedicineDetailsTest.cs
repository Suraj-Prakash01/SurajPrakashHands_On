using GenericMedicine;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMedicineTests
{
    [TestFixture]
    public class MedicineDetailsTest
    {
        [Test]
        [TestCase("Name1", "Gen_med_1", "Pharma1", "2022/6/3", 12)]
        [TestCase("Name2", "Gen_med_2", "Pharma2", "2023/11/13", 11.9)]
        [TestCase("Name3", "Gen_med_3", "Pharma3", "2021/11/6", 110.11)]
        public void CreateMedicineDetail_WhenCalled_ReturnMedicineObject(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {
            Program p = new Program();
            Medicine result = p.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip);

            Assert.That(result.Name, Is.EqualTo(name));
            Assert.That(result.GenericMedicineName, Is.EqualTo(genericMedicineName));
            Assert.That(result.Composition, Is.EqualTo(composition));
            Assert.That(result.ExpiryDate, Is.EqualTo(expiryDate));
            Assert.That(result.PricePerStrip, Is.EqualTo(pricePerStrip));
        }
        [Test]
        [TestCase("Name1", "", "Pharma1", "2022/6/3", 12)]
        [TestCase("Name2", null, "Pharma2", "2023/11/13", 11.9)]
        public void CreateMedicineDetail_WhenCalledWithEmptyGenericMedicineName_ThrowsException(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {
            Program p = new Program();

            var exception = Assert.Throws<Exception>(() => p.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));
            Assert.AreEqual("Generic Medicine name cannot be empty. Please provide valid value", exception.Message);
        }
        [Test]
        [TestCase("Name1", "Gen_med_1", "Pharma1", "2022/6/3", -12)]
        [TestCase("Name2", "Gen_med_2", "Pharma2", "2023/11/13", -11.9)]
        public void CreateMedicineDetail_WhenCalledWithPriceZero_ThrowsException(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {
            Program p = new Program();

            var exception = Assert.Throws<Exception>(() => p.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));
            Assert.AreEqual("Incorrect value for Medicine price per strip. Please provide valid value", exception.Message);
        }
        [Test]
        [TestCase("Name1", "Gen_med_1", "Pharma1", "2020/6/3", 12)]
        [TestCase("Name2", "Gen_med_2", "Pharma2", "2019/11/13", 11.9)]
        public void CreateMedicineDetail_WhenCalledWithDateLessThanCurrentDate_ThrowsException(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {
            Program p = new Program();

            var exception = Assert.Throws<Exception>(() => p.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));
            Assert.AreEqual("Incorrect expiry date. Please provide valid value", exception.Message);
        }
       
    }
}
