using Bridge;

namespace OresundBron
{
    public class OresundCar : Vehicle
    {
        public override double Price()
        {
            return 460;
        }

        public override string VehicleType()
        {
            return "Oresund Car";
        }

        public override double BroBizzDiscount(bool broBizz)
        {
            if (broBizz)
            {
                return 178;
            }
            else return Price();
        }



    }
}
