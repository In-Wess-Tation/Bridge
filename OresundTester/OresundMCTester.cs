using Bridge;
using OresundBron;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OresundTester
{
    [TestClass]
    public class OresundMCTester
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
                OresundMC mc1 = new OresundMC();
                //act
                var result = mc1.Price();
                //assert
                Assert.AreEqual(235, result);
            }

            /// <summary>
            /// Tests the VehicleType method of the MC class to ensure it returns the correct vehicle type.
            /// </summary>
            [TestMethod]
            public void TestVehicle()
            {
                //arrange 
                OresundMC mc2 = new OresundMC();
                //act 
                var result = mc2.VehicleType();
                //assert 
                Assert.AreEqual("Oresund MC", result);
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
                    OresundMC c3 = new OresundMC();
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
                OresundMC c4 = new OresundMC();
                //act
                var result = c4.BroBizzDiscount(true);
                //assert
                Assert.AreEqual(92, result);
            }
        }
    }
}
