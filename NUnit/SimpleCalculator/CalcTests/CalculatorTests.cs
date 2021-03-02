using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleCalculator;

namespace CalcTests
{
   

    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calculator;
        [SetUp]
        public void SetUp()
        {
            calculator = new Calculator();
        }

        [Test]
        [TestCase(1,2,3)]
        public void Addition_WhenCalled_ReturnSum(double a, double b, double expectedResult)
        {
            //Calculator calculator = new Calculator();
            var result = calculator.Addition(a,b);
            Assert.That(result,Is.EqualTo(expectedResult));
           
        }
        [Test]
        [TestCase(5, 2, 3)]
        [TestCase(8,4,4)]
        public void Subtraction_WhenCalled_ReturnDifference(double a,double b,double expectedResult)
        {
            //Calculator calculator = new Calculator();
            var result = calculator.Subtraction(a, b);
            Assert.AreEqual(result, expectedResult);
        }
        [Test]
        [TestCase(2,1,2)]
        [TestCase(5,0,0)]
        public void Multiplication_WhenCalled_ReturnProduct(double a, double b, double expectedResult)
        {
            //Calculator calculator = new Calculator();
            var result = calculator.Multiplication(a, b);
            Assert.AreEqual(result, expectedResult);
        }
        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(10, 2, 5)]
        [TestCase(5, 0, 0)]
        
        public void Division_WhenCalled_ReturnQuotient(double a, double b, double expectedResult)
        {
            //Calculator calculator = new Calculator();

            try
            {
                var result = calculator.Division(a, b);
                Assert.AreEqual(result, expectedResult);
            }
            catch (ArgumentException e)
            {
                Assert.Fail("Division by Zero",e);
            }
        }
        [Test]
        public void AllClear_WhenCalled_SetResultToZero()
        {
            var result=calculator.Addition(5,4);
            Assert.AreEqual(result, 9);
            calculator.AllClear();
            var result2 = calculator.GetResult;
            Assert.AreEqual(result2,0);
            
            
        }
        
    }
}
