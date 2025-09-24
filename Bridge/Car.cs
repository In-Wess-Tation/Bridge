using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Car : Vehicle
    {
        public override double Price()
        {
            return 230;
        }

        public override string VehicleType()
        {
            return "Car";
        }

        public override double BroBizzDiscount(bool broBizz)
        {
            if (broBizz)
            {
                return Price() * 0.90;
            }
            else return Price();
        }
        public double WeekendDiscount(DateTime date)
        {
            if (date.DayOfWeek == DayOfWeek.Sunday || date.DayOfWeek == DayOfWeek.Saturday)
            {
                return Price() * 0.85;
            }
            else return Price();
        }

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
