using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// Represents a motorcycle vehicle with specific toll pricing and discount methods.
    /// </summary>
    public class MC : Vehicle
    {
        /// <summary>
        /// Returns the price of the motorcycle toll.
        /// </summary>
        /// <returns></returns>
        public override double Price()
        {
            return 120;
        }

        /// <summary>
        /// Returns the type of vehicle, which is "MC".
        /// </summary>
        /// <returns></returns>
        public override string VehicleType()
        {
            return "MC";
        }

        /// <summary>
        /// Calculates the BroBizz discount for the motorcycle.
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
