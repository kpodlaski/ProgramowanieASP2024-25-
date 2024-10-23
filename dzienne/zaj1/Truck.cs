using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaj1
{
    class Truck:Car
    {
        public float Tonnage { get; set; }

        public Truck(float tonnage, int id, string brand, int year, string color)
            :base(id,brand,year,color)
        {
            Tonnage = tonnage;
        }

        public override string ToString()
        {
            return base.ToString()+" "+Tonnage+"ton";
        }

        override public object Clone()
        {
            return new Truck(this.Tonnage, this.Id, this.Brand, this.Year, this.Color);
        }
    }
}
