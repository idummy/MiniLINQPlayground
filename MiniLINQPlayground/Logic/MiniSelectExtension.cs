namespace MiniLINQPlayground.Logic
{
    public static class MiniSelectExtension
    {
        public static IEnumerable<TResult> MiniSelect<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }
            if (selector == null)
            {
                throw new ArgumentNullException(nameof(selector));
            }
            foreach (var item in source)
            {
                yield return selector(item);
            }
        }
    }
}
