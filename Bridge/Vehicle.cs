using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// Abstract base class representing a vehicle with common properties and methods.
    /// </summary>
    public abstract class Vehicle
    {
        /// <summary>
        /// The license plate of the vehicle, limited to a maximum of 7 characters.
        /// </summary>
        public string LicensePlate { get; set; }
        /// <summary>
        /// The date of the vehicle's passage, used for calculating date-based discounts.
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Indicates whether the vehicle has a BroBizz device for discounts.
        /// </summary>
        public bool BroBizz { get; set; }


        /// <summary>
        /// Returns the price of the vehicle toll.
        /// </summary>
        /// <returns></returns>
        public abstract double Price();

        /// <summary>
        /// Returns the type of vehicle.
        /// </summary>
        /// <returns></returns>
        public abstract string VehicleType();

        /// <summary>
        /// Checks if the license plate is valid (not longer than 7 characters).
        /// </summary>
        /// <returns></returns>
        public string LicensePlateCheck(string licensePlate)
        {
            if (licensePlate.Length > 7)
            {
                throw new ArgumentException("License plate cannot be longer than 7 characters.");
            }
            return LicensePlate;
        }

        /// <summary>
        /// Calculates the BroBizz discount for the vehicle.
        /// </summary>
        /// <returns></returns>
        public abstract double BroBizzDiscount(bool broBizz);

        


    }
}
