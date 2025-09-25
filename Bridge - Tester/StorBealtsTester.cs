using Bridge;
using StoreBaeltTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge___Tester
{
    /// <summary>
    /// Tests the StorBealtsCar class to ensure its methods function correctly.
    /// </summary>
    [TestClass]
    public sealed class StorBealtsTester
    {
        /// <summary>
        /// Tests the Price method of the Car class to ensure it returns the correct price.
        /// </summary>
        [TestMethod]
        public void TestPrice()
        {

            //arange
            StorBealtsCar c1 = new StorBealtsCar();
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
            StorBealtsCar c2 = new StorBealtsCar();
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
                StorBealtsCar c3 = new StorBealtsCar();
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
            StorBealtsCar c4 = new StorBealtsCar();
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
            StorBealtsCar c5 = new StorBealtsCar();
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
            StorBealtsCar c6 = new StorBealtsCar();
            c6.BroBizz = true;
            //act
            var result = c6.WeekendDiscountBroBizz(c6.BroBizz, new DateTime(2024, 06, 09));
            //assert
            Assert.AreEqual(175.95, result, 1.0);
        }
    }
}
