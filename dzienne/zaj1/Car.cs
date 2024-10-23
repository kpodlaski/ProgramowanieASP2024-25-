using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace zaj1
{
    class Car : IComparable<Car>, ICloneable
    {
        protected int Id;
        public String Brand { get; private set; }
        protected int Year;
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

        virtual public object Clone()
        {
            return new Car(this.Id,this.Brand, this.Year, this.Color);
        }

        public override bool Equals(object obj)
        {
            if (obj is not Car) return false;
            Car other = (Car)obj;
            return (this.Id == other.Id) && (this.Brand.Equals(other.Brand));
        }

        public override int GetHashCode()
        {
            int hash = Id;
            hash += 17 * this.Brand.GetHashCode(); 
            return hash;
        }
    }
}
