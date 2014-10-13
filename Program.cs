using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace epan_training_laba_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Company aeroflot = new Company("aeroflot");
            Random rnd = new Random();
            for (int i = 0; i < rnd.Next(2,5); i++)
            {
                Console.WriteLine("Введите имя самолета");
                string name = Console.ReadLine();

                CargoPlane s = new CargoPlane(name, rnd.Next(100,2000), rnd.Next(100,500), rnd.Next(500,1000));
                aeroflot.cargo_planes.Add(s);
            }

            for (int i = 0; i < rnd.Next(3,5); i++)
            {
                Console.WriteLine("Введите имя самолета");
                string name = Console.ReadLine();

                PassengerPlane s = new PassengerPlane(name, rnd.Next(100, 2000), rnd.Next(100,500), rnd.Next(10,300));
                aeroflot.passenger_planes.Add(s);             
            }

            aeroflot.FuelConsumption(300, 500);
            Console.WriteLine();
            aeroflot.SumOfCapasity();
            aeroflot.SumOfWeigth();
            Console.WriteLine();

            aeroflot.passenger_planes.Sort(delegate(PassengerPlane plane1, PassengerPlane plane2)
            { return plane1.GetFlyLength().CompareTo(plane2.GetFlyLength()); });
            Console.WriteLine("Отсортированные самолеты(по дальности полета)");
            Console.WriteLine("Пассажирские:");
            foreach (PassengerPlane r in aeroflot.passenger_planes)
            {
                r.Print();
            }
            aeroflot.cargo_planes.Sort(delegate(CargoPlane plane1, CargoPlane plane2)
            { return plane1.GetFlyLength().CompareTo(plane2.GetFlyLength()); });
            Console.WriteLine("Грузовые");
            foreach (CargoPlane r in aeroflot.cargo_planes)
            {
                r.Print();
            }
            Console.WriteLine();
            aeroflot.FuelConsumption(250, 350);
        }
    }
}
