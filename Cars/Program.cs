using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            
            List<Truck> trucks = new List<Truck>();
            List<LightCar> lightCars = new List<LightCar>();
            List<Motocycle> motocycles = new List<Motocycle>();

            for (int i = 0; i < random.Next(); i++)
            {
                Truck truck = new Truck();
                LightCar lightCar = new LightCar();
                Motocycle motocycle = new Motocycle();


                truck.Brand = string.Format("Brand_{0}", random.Next(1, 30));
                truck.IsTrailer = Convert.ToBoolean(random.Next(0,1));
                truck.Number = string.Format("Number_{0}", random.Next(1, 50));
                truck.Speed = random.Next(1,100);
                truck.Thrust = random.Next(1, 500);
                truck.Weight = random.Next(1, 10000);

                lightCar.Brand = string.Format("Brand_{0}", random.Next(1, 30));
                lightCar.Number = string.Format("Number_{0}", random.Next(1, 50));
                lightCar.Speed = random.Next(1, 150);
                lightCar.Thrust = random.Next(1, 100);
                lightCar.Weight = random.Next(1, 1000);


                motocycle.Brand = string.Format("Brand_{0}", random.Next(1, 30));
                motocycle.IsStoller = Convert.ToBoolean(random.Next(0, 1));
                motocycle.Number = string.Format("Number_{0}", random.Next(1, 50));
                motocycle.Speed = random.Next(1, 250);
                motocycle.Thrust = random.Next(1, 50);
                motocycle.Weight = random.Next(1, 500);

                trucks.Add(truck);
                lightCars.Add(lightCar);
                motocycles.Add(motocycle);
            }



            while (true)
            {
                Console.Clear();
                Console.ResetColor();
                Console.WriteLine("Введите желаемую грузоподъемность:");
                int CustomThrust = int.Parse(Console.ReadLine());
                Console.WriteLine(" -- Результат поиска -- ");
                bool isFind = false;

                Console.WriteLine("Грузовики");
                Console.WriteLine("----------------------------------");
                foreach (Truck truck in trucks)
                {
                    if (truck.Thrust == CustomThrust)
                    {
                        truck.ShowInfo();
                        isFind = true;
                        Console.WriteLine();
                    }
                }

                Console.WriteLine("----------------------------------");
                Console.WriteLine();
                Console.WriteLine("Легковые автомобили");
                Console.WriteLine("----------------------------------");

                foreach (LightCar lightCar in lightCars)
                {
                    if (lightCar.Thrust == CustomThrust)
                    {
                        lightCar.ShowInfo();
                        isFind = true;
                        Console.WriteLine();
                    }
                }

                Console.WriteLine("----------------------------------");
                Console.WriteLine();
                Console.WriteLine("Мотоциклы");
                Console.WriteLine("----------------------------------");

                foreach (Truck truck in trucks)
                {
                    if (truck.Thrust == CustomThrust)
                    {
                        truck.ShowInfo();
                        isFind = true;
                        Console.WriteLine();
                    }
                }
                Console.WriteLine("----------------------------------");
                Console.WriteLine();
                if (!isFind)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Подобных машин у нас нет!");
                }
                Console.WriteLine();
                Console.WriteLine("----------------------------------");
                Console.ReadLine();

            }

        }
    }
}
