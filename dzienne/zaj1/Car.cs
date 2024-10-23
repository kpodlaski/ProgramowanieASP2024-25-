using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaj1
{
    class Car : IComparable<Car>
    {
        int Id;
        public String Brand { get; private set; }
        int Year;
        public String Color;

        public Car()
        {
            Id = 0;
            Brand = "No brand";
            Year = -1;
            this.Color = "NO COLOR";
        }

        public Car(int id, string brand, int year, string color)
        {
            Id = id;
            Brand = brand;
            Year = year;
            Color = color;
        }

        public override string ToString()
        {
            return Brand + " " + Color + " " + Year;      
        }

        public int CompareTo(Car other)
        {
            return this.Id - other.Id;
        }
    }
}
