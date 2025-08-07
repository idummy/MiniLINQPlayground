using System.Collections;

public class MiniGrouping<TKey, TElement> : IGrouping<TKey, TElement>
{
    public TKey Key { get; }

    private readonly IEnumerable<TElement> _elements;

    public MiniGrouping(TKey key, IEnumerable<TElement> elements)
    {
        Key = key;
        _elements = elements;
    }

    public IEnumerator<TElement> GetEnumerator() => _elements.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
