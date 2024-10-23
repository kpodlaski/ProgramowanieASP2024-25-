using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaj1
{
    internal class BrandCarComparer : IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            return x.Brand.CompareTo(y.Brand);
        }
    }
}
