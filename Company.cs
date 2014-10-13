using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace epan_training_laba_1
{
    class Company
    {
        private string name;

        public Company(string name)
        {
            name = this.name;
        }
        public string GetCompanyName()
        {
            return name;
        }

        public List<CargoPlane> cargo_planes = new List<CargoPlane>();

        public void AddCargoPlane(CargoPlane plane)
        {
            cargo_planes.Add(plane);
        }

        public void SumOfWeigth()
        {
            int sum = 0;
            foreach (CargoPlane s in cargo_planes)
            {
                sum += s.GetWeigth();
            }
            Console.WriteLine("{0} {1}","Общая грузоподъемность ", sum);
        }
        public List<PassengerPlane> passenger_planes = new List<PassengerPlane>();

        public void AddPassengerPlane(PassengerPlane plane)
        {
            passenger_planes.Add(plane);
        }

        public void SumOfCapasity()
        {
            int sum = 0;
            foreach (PassengerPlane s in passenger_planes)
            {
                sum += s.GetCapasity();
            }
            Console.WriteLine("{0} {1}","Общая вместимость ", sum);
        }
        public void FuelConsumption(int min,int max)
        {
            int k=0;
            Console.WriteLine("Самолеты, отвечающие заданному диапазону потребления горючего");
            foreach (CargoPlane s in cargo_planes)
            {
                if (s.FindByFuel(min, max)) { s.Print(); k++; }
            }
            foreach (PassengerPlane s in passenger_planes)
            {
                if (s.FindByFuel(min, max)) { s.Print(); k++; }
            }
            if (k == 0) Console.WriteLine("К сожалению, таких самолетов нет в наличии");
        }
        
    }
}
