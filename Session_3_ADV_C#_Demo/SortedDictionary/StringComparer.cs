namespace Session_3_ADV_C__Demo.SortedDictionary
{
    internal class StringComparer : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            return String.Compare(y, x);
        }

    }
}
