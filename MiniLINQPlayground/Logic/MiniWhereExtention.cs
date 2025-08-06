namespace MiniLINQPlayground.Logic
{
    public static class MiniWhereExtention
    {
        public static IEnumerable<T> MiniWhere<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            foreach (var item in source)
            {
                if (predicate(item))
                    yield return item;
            }
        }
    }
}
