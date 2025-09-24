using OresundBron;

namespace OresundTester
{
    [TestClass]
    public sealed class OresundCarTester
    {
        /// <summary>
        /// Tests the Price method of the Car class to ensure it returns the correct price.
        /// </summary>
        [TestMethod]
        public void TestPrice()
        {

            //arange
            OresundCar c1 = new OresundCar();
            //act
            var result = c1.Price();
            //assert
            Assert.AreEqual(460, result);
        }

        /// <summary>
        /// Tests the VehicleType method of the Car class to ensure it returns the correct vehicle type.
        /// </summary>
        [TestMethod]
        public void TestVehicle()
        {
            //arrange 
            OresundCar c2 = new OresundCar();
            //act 
            var result = c2.VehicleType();
            //assert 
            Assert.AreEqual("Oresund Car", result);
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
                OresundCar c3 = new OresundCar();
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
            //arange
            OresundCar c4 = new OresundCar();
            //act
            var result = c4.BroBizzDiscount(true);
            //assert
            Assert.AreEqual(178, result);
        }


    }
}
