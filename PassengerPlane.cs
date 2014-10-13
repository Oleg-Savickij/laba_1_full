using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace epan_training_laba_1
{
    class PassengerPlane: Plane
    {
         private string Name;
        private int FlyLength;
        private int Fuel;
        private int capasity;

        public PassengerPlane(string a, int b, int c,int Capasity)
        {
            Name = a;
            FlyLength = b;
            Fuel = c;
            capasity=Capasity;
        }

        public override int GetFuelRate()
        {
            return Fuel;
        }

        public override int GetFlyLength()
        {
            return FlyLength;
        }

        public int GetCapasity()
        {
            return capasity;
        }
        public bool FindByFuel(int min, int max)
        {
            if ((min < Fuel) && (max > Fuel)) return true;
            else return false;
        }
        public override void Print()
        {
            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7}", Name, "дальность полета-", FlyLength, "Объем бака-", Fuel,"пассажировместимость:", capasity, "чел.");
        }
    }
}
