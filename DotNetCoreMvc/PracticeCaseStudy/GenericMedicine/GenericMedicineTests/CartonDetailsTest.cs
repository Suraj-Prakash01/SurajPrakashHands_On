using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericMedicine;

namespace GenericMedicineTests
{
    [TestFixture]
   
    class CartonDetailsTest
    {
        Program p;
        Medicine m = new Medicine()
        {
            Name = "Name1",
                GenericMedicineName = "Gen_Med_Name",
                Composition = "Comp1",
                ExpiryDate = new DateTime(2022, 12, 1),
                PricePerStrip = 30
             };

        [OneTimeSetUp]
        public void init()
        {
            p = new Program();
            
            
        }
        [Test]
        [TestCase(1,"2022/6/3","Jehanabad")]
        public void CreateCartonDetail_WhenCalled_ReturnCartonObject(int medicineStripCount, DateTime launchDate, string retailerAddress)
        {
            CartonDetail result = p.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, m);
            Assert.That(result.MedicineStripCount, Is.EqualTo(medicineStripCount));
            Assert.That(result.LaunchDate, Is.EqualTo(launchDate));
            Assert.That(result.RetailerAddress, Is.EqualTo(retailerAddress));
            Assert.That(result.Medicine, Is.EqualTo(m));
        }
        [Test]
        [TestCase(-1, "2022/6/3", "Jehanabad")]
        public void CreateCartonDetail_WhenStripCountIsLessThanZero_ThrowsException(int medicineStripCount, DateTime launchDate, string retailerAddress)
        {
            var exception = Assert.Throws<Exception>(() => p.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress,m));
            Assert.AreEqual("Incorrect strip count. Please check", exception.Message);
        }
        [Test]
        [TestCase(1, "2020/6/3", "Jehanabad")]
        public void CreateCartonDetail_WhenLaunchDateIsLessThanCurrentDate_ThrowsException(int medicineStripCount, DateTime launchDate, string retailerAddress)
        {
           

            var exception = Assert.Throws<Exception>(() => p.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress,m));
            Assert.AreEqual("Incorrect launch date. Please provide valid value", exception.Message);

        }

        [Test]
        [TestCase(1, "2024/6/3", "Jehanabad")]
        public void CreateCartonDetail_WhenLaunchDateIsGreaterThanExpiryDate_ThrowsException(int medicineStripCount, DateTime launchDate, string retailerAddress)
        {


            var exception = Assert.Throws<Exception>(() => p.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, m));
            Assert.AreEqual("Launch date greater than expiry date. Please check", exception.Message);

        }
        [Test]
        [TestCase(1, "2020/6/3", "Jehanabad")]
        public void CreateCartonDetail_WhenMedicineObjectValueIsNull_ThrowsException(int medicineStripCount, DateTime launchDate, string retailerAddress)
        {


            CartonDetail result= p.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, null);
            Assert.That(result, Is.EqualTo(null));

        }


    }
}
