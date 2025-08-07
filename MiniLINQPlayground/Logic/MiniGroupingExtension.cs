using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniLINQPlayground.Logic
{
    public static class MIniGroupingExtension
    {
        public static IEnumerable<IGrouping<TKey, TSource>> MiniGroupBy<TSource, TKey>(
             this IEnumerable<TSource> source,
             Func<TSource, TKey> func
        )
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            if (func == null)
                throw new ArgumentNullException(nameof(func));
            var keyValuePairs = new Dictionary<TKey, List<TSource>>();
            foreach (var element in source)
            {
                var key = func(element);
                
                if (!keyValuePairs.ContainsKey(key))
                {
                    keyValuePairs[key] = new List<TSource>();
                }
                keyValuePairs[key].Add( element );
            }
            foreach(var pair in keyValuePairs)
            {
                yield return new MiniGrouping<TKey, TSource>(pair.Key, pair.Value);
            }
        }
    }
}
