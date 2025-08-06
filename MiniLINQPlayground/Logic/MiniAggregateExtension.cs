// mini aggregate which applies accumulator function on each of the element.

namespace MiniLINQPlayground.Logic
{
    public static class MiniAggregateExtension
    {
        public static TAccumulate MiniAggregate<TSource, TAccumulate>(
            this IEnumerable<TSource> source,
            TAccumulate seed,
            Func<TAccumulate, TSource, TAccumulate> func)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }
            if (func == null)
            {
                throw new ArgumentNullException(nameof(func));
            }

            TAccumulate result = seed;

            foreach (var item in source)
            {
                result = func(result, item);
            }
            return result;
        }

        // one overload 
        public static TSource MiniAggregate<TSource>(
            this IEnumerable<TSource> source,
            Func<TSource, TSource, TSource> func)
        {

            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }
            if (func == null)
            {
                throw new ArgumentNullException(nameof(func));
            }
            using var enumerator = source.GetEnumerator();

            if (!enumerator.MoveNext())
            {
                throw new InvalidOperationException("Seqence contains no elements!");
            }
            var result = enumerator.Current;
            while (enumerator.MoveNext())
            {
                result = func(result, enumerator.Current);
            }
            return result;
        }
    }
}