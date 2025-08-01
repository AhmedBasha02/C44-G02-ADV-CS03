using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_3_ADV_C__Demo.SortedList
{
    internal class CarEqualityComparer : IEqualityComparer<Car>
    {
        public bool Equals(Car? x, Car? y)
        {
            if (x is  null || y is  null) return false;
            return x.Id == y.Id && x.Model == y.Model;
        }

        public int GetHashCode([DisallowNull] Car obj)
        {
            return HashCode.Combine(obj.Id, obj.Model);
        }

    }
}
