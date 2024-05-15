
using MovableClassLibrary;


namespace AdapterPattern.Ex
{
    public class MovableAdapter : IMovableTarget
    {
        private Movable luxuryCars;

        public MovableAdapter(Movable luxuryCars)
        {
            this.luxuryCars = luxuryCars;
        }

        public double GetSpeed()
        {
            double mph=luxuryCars.GetSpeed();
            return ConvertMPHtoKMPH(mph);
        }

        private double ConvertMPHtoKMPH(double mph)
        {
            return mph*1.60934;
        }
    }
}