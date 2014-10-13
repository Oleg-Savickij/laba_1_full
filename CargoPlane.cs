using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace epan_training_laba_1
{
    class CargoPlane: Plane
    {
        private string Name;
        private int FlyLength;
        private int Fuel;
        private int weigth;

        public CargoPlane(string a, int flylength, int fuel,int Weigth)
        {
            Name = a;
            FlyLength = flylength;
            Fuel = fuel;
            weigth=Weigth;
        }

        public override int GetFuelRate()
        {
            return Fuel;
        }

        public override int GetFlyLength()
        {
            return FlyLength;
        }

        public int GetWeigth()
        {
            return weigth;
        }
        public bool FindByFuel(int min, int max)
        {
            if ((min < Fuel) && (max > Fuel)) return true;
            else return false;
        }

        public override void Print()
        {
            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7}",Name,"дальность полета-",FlyLength,"Объем бака-",Fuel,"грузоподъемность:",weigth,"кг");
        }


    }
}
