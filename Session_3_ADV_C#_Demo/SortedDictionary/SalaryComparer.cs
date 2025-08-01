using Session_3_ADV_C__Demo.Dictionary;

namespace Session_3_ADV_C__Demo.SortedDictionary
{
    internal class SalaryComparer : IComparer<Employee>
    {
        public int Compare(Empolyee? x, Empolyee? y)
        {
            return x?.Salary.CompareTo(y?.Salary) ?? -1;
        }

    }
}
