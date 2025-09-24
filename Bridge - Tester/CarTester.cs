using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bridge;
using System.Diagnostics.CodeAnalysis;

namespace Bridge___Tester
{
    /// <summary>
    /// Tests the Car class to ensure its methods function correctly.
    /// </summary>
    [ExcludeFromCodeCoverage]
    [TestClass]
    public sealed class CarTester
    {
        /// <summary>
        /// Tests the Price method of the Car class to ensure it returns the correct price.
        /// </summary>
        [TestMethod]
        public void TestPrice()
        {

            //arange
            Car c1 = new Car();
            //act
            var result = c1.Price();
            //assert
            Assert.AreEqual(230, result);
        }

        /// <summary>
        /// Tests the VehicleType method of the Car class to ensure it returns the correct vehicle type.
        /// </summary>
        [TestMethod]
        public void TestVehicle()
        {
            //arrange 
            Car c2 = new Car();
            //act 
            var result = c2.VehicleType();
            //assert 
            Assert.AreEqual("Car", result);
        }

        /// <summary>
        /// Tests the LicensePlateCheck method of the Car class to ensure it throws an ArgumentException for invalid license plates.
        /// </summary>
        [TestMethod]
        public void TestLicensePlate()
        {
            //assert
            Assert.ThrowsException<ArgumentException>(() =>
            {
                //arrange
                Car c3 = new Car();
                c3.LicensePlate = "12345678";
                //act
                var result = c3.LicensePlateCheck(c3.LicensePlate);
            });
        }

        /// <summary>
        /// Tests the BroBizzDiscount method of the MC class to ensure it applies the discount correctly.
        /// </summary>
        [TestMethod]
        public void TestBroBizzDiscount()
        {
            //arrange
            Car c4 = new Car();
            c4.BroBizz = true; 
            //act
            var result = c4.BroBizzDiscount(c4.BroBizz);
            //assert
            Assert.AreEqual(207, result);
        }

        /// <summary>
        /// Tests the WeekendDiscount method of the Car class to ensure it applies the weekend discount correctly.
        /// </summary>
        [TestMethod]
        public void TestWeekendDiscount()
        {
            //arrange
            Car c5 = new Car();
            //act
            var result = c5.WeekendDiscount(new DateTime(2024, 06, 09));
            //assert
            Assert.AreEqual(195.5, result);
        }

        /// <summary>
        /// Tests the WeekendDiscountBroBizz method of the Car class to ensure it applies both the weekend and then the BroBizz discounts.
        /// </summary>
        [TestMethod]
        public void TestWeekendDiscountBroBizz()
        {
            //arrange
            Car c6 = new Car();
            c6.BroBizz = true;
            //act
            var result = c6.WeekendDiscountBroBizz(c6.BroBizz, new DateTime(2024, 06, 09));
            //assert
            Assert.AreEqual(175.95, result,1.0);
        }




    }
}
