using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bridge;

namespace Bridge___Tester
{
    /// <summary>
    /// Tests the MC class to ensure its methods function correctly.
    /// </summary>
    [TestClass]
    public sealed class MCTester
    {
        /// <summary>
        /// Tests the Price method of the MC class to ensure it returns the correct price.
        /// </summary>
        [TestMethod]
        public void TestPrice()
        {
            //arange
            MC mc1 = new MC();
            //act
            var result = mc1.Price();
            //assert
            Assert.AreEqual(120, result);
        }

        /// <summary>
        /// Tests the VehicleType method of the MC class to ensure it returns the correct vehicle type.
        /// </summary>
        [TestMethod]
        public void TestVehicle()
        {
            //arrange 
            MC mc2 = new MC();
            //act 
            var result = mc2.VehicleType();
            //assert 
            Assert.AreEqual("MC", result);
        }

        /// <summary>
        /// Tests the LicensePlateCheck method of the MC class to ensure it throws an ArgumentException for invalid license plates.
        /// </summary>
        [TestMethod]
        public void TestLicensePlate()
        {
            //assert
            Assert.ThrowsException<ArgumentException>(() =>
            {
                //arrange
                MC mc3 = new MC();
                mc3.LicensePlate = "12345678";
                //act
                var result = mc3.LicensePlateCheck(mc3.LicensePlate);
            });
        }

        /// <summary>
        /// Tests the BroBizzDiscount method of the MC class to ensure it applies the discount correctly.
        /// </summary>
        [TestMethod]
        public void TestBroBizzDiscount()
        {
            //arrange
            MC mc4 = new MC();
            mc4.BroBizz = true;
            //act
            var result = mc4.BroBizzDiscount(mc4.BroBizz);
            //assert
            Assert.AreEqual(108, result);
        }
        










    }
}
