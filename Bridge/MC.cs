using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class MC : Vehicle
    {
        public override double Price()
        {
            return 120;
        }

        public override string VehicleType()
        {
            return "MC";
        }

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
