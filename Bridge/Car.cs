using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// Represents a car vehicle with specific toll pricing and discount methods.
    /// </summary>
    public class Car : Vehicle
    {
        /// <summary>
        /// Returns the price of the car toll.
        /// </summary>
        /// <returns></returns>
        public override double Price()
        {
            return 230;
        }

        /// <summary>
        /// Returns the type of vehicle, which is "Car".
        /// </summary>
        /// <returns></returns>
        public override string VehicleType()
        {
            return "Car";
        }

        /// <summary>
        /// Calculates the BroBizz discount for the car.
        /// </summary>
        /// <returns></returns>
        public override double BroBizzDiscount(bool broBizz)
        {
            if (broBizz)
            {
                return Price() * 0.90;
            }
            else return Price();
        }
       




    }
}
