namespace Session_3_ADV_C__Demo.SortedSet
{
    internal class IntComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return y.CompareTo(x);
        }

    }
}
