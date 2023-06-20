using System;
using System.Collections.Generic;

namespace мойка
{
    class Program
    {
        delegate void WashingCars(Garage cars);
        public class Car
        {
            public string name;
            public string number;
            public string statyc;
            public Car(string name, string number, string statyc)
            {
                this.name = name;
                this.number = number;
                this.statyc = statyc;
            }
        }
        public class Garage
        {
            public List<Car> Listcar = new List<Car>();
            public void Add(Car car)
            {
                Listcar.Add(car);
            }
            public void Bcegarage()
            {
                foreach (var i in Listcar)
                {
                    Console.WriteLine($"{i.name} {i.number} {i.statyc}");
                }
            }
        }
        public class Washing
        {
            public static void PomiliBce(Garage garage)
            {
                foreach (Car car in garage.Listcar)
                {
                    car.statyc = "Помыта";
                    Console.WriteLine($"{car.name} {car.number} {car.statyc}");
                }
            }
        }
        static void Main(string[] args)
        {
            Garage garage = new Garage();
            Car car1 = new Car("бибика 23", "0000", "Не помыта");
            Car car2 = new Car("би-би", "0001", "Не помыта");
            garage.Add(car1);
            garage.Add(car2);
            Console.WriteLine("В гараже находится");
            garage.Bcegarage();
            Console.WriteLine("В мойке находится");
            WashingCars wash = Washing.PomiliBce;
            wash(garage);
        }
    }
}
