using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using JessicaHenry_S00214115_Practical; 
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange 
            Car c1 = new Car()
            {
                Price = 20000,
                Name = "ix35",
            };

            //Act
            decimal expectedResult = 18000;
            decimal resultOfNewPrice = c1.DecreasePrice(10); 

            //Assert 
            Assert.AreEqual(expectedResult, resultOfNewPrice); 
        }
    }
}
