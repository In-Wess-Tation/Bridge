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
        /// <summary>
        /// Calculates the weekend discount for the car.
        /// </summary>
        /// <returns></returns>
        public double WeekendDiscount(DateTime date)
        {
            if (date.DayOfWeek == DayOfWeek.Sunday || date.DayOfWeek == DayOfWeek.Saturday)
            {
                return Price() * 0.85;
            }
            else return Price();
        }

        /// <summary>
        /// Calculates the combined weekend and BroBizz discount for the car.
        /// </summary>
        /// <returns></returns>
        public double WeekendDiscountBroBizz(bool broBizz, DateTime date)
        {
            double TotalPrice = 0;
            if (date.DayOfWeek == DayOfWeek.Sunday && broBizz || date.DayOfWeek == DayOfWeek.Saturday && broBizz)
            {
                return TotalPrice += (Price() * 0.85) * 0.90;
            }
            else return Price();
        }





    }
}
