using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class Vehicle
    {
        public string LicensePlate { get; set; }
        public DateTime Date { get; set; }
        public bool BroBizz { get; set; }


        public abstract double Price();

        public abstract string VehicleType();

        public string LicensePlateCheck(string licensePlate)
        {
            if (licensePlate.Length > 7)
            {
                throw new ArgumentException("License plate cannot be longer than 7 characters.");
            }
            return LicensePlate;
        }

        public abstract double BroBizzDiscount(bool broBizz);

        


    }
}
