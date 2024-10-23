using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaj1
{
    internal class CarTonnageComparer : IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            if ( (x is Car) && (y is Car)) 
                return 0;
            if ( (x is Car) && (y is Truck))
                return -1;
            if ( (x is Truck) && (y is Car))
                return -Compare(y, x);
            if ( (x  is Truck) && (y is Truck))
            {
                return (int) (((Truck)x).Tonnage - ((Truck)y).Tonnage);
            }
            return 0;
        }
    }
}
