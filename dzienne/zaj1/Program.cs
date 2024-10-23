using System;
using System.Collections.Generic;

namespace zaj1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Car c = new Car(1, "Syrenka", 1978, "Biały");
            //Console.WriteLine(c);
            Truck t = new Truck(25.5f, 2, "Star", 1992, "Niebieski");
            //Console.WriteLine(t);
            Car[] cars_arr;
            List<Car> cars = new List<Car>();
            cars.Add(t);
            cars.Add(c);
            t = new Truck(21.5f, 3, "Star", 1991, "Czerwony");
            cars.Add((Car)t);
            Console.WriteLine("Before Sort");
            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }
            cars.Sort();
            Console.WriteLine("After Sort");
            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }
            cars.Sort(new BrandCarComparer());
            Console.WriteLine("After Brand Sort");
            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }
            cars.Sort(new CarTonnageComparer());
            cars.Reverse();
            Console.WriteLine("After Tonnage Sort, Descedding");
            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }
            //Kolekcja Set
            HashSet<Car> carsSet = new HashSet<Car>();
            foreach (Car car in cars)
            {
                carsSet.Add(car);
            }
            Console.WriteLine("ilość elemntów w zbiorze:"+carsSet.Count);
            carsSet.Add((Car) c.Clone());
            Console.WriteLine("ilość elemntów w zbiorze:" + carsSet.Count);
        }
    }
}
