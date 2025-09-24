using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OresundBron
{
    public class OresundMC : Vehicle
    {
        public override double Price()
        {
            return 235;
        }

        public override string VehicleType()
        {
            return "Oresund MC";
        }

        public override double BroBizzDiscount(bool broBizz)
        {
            if (broBizz)
            {
                return 92;
            }
            else return Price();
        }



    }
}
