using System.Diagnostics.CodeAnalysis;

namespace Session_3_ADV_C__Demo.Dictionary
{
    internal class IdEqualityComparerForEmployeeGenericDictionary : IEqualityComparer<Employee>
    {
        public bool Equals(Employee? x, Employee? y)
        {
            //return x?.Id.Equals(y?.Id)?? false ;
            
            //or

            if(x == null || y == null ) return false ;
            return x.Id.Equals(y.Id);
        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
            return obj.Id.GetHashCode() ;

            //or

            //return HashCode.Combine(obj.Id);
        }
    }
}
