namespace ConsoleApp.Problems.LeetCode.LRUCache;

public class LRUCacheSolution
{
    private readonly int _capacity;
    private readonly IDictionary<int, LRUCacheItem> _data;
    private LRUCacheItem? _leastRecent;
    private LRUCacheItem? _mostRecent;

    public LRUCacheSolution(int capacity) {
        _capacity = capacity;
        _data = new Dictionary<int, LRUCacheItem>();
    }
    
    public int Get(int key) {
        if (!_data.TryGetValue(key, out var item))
        {
            return -1;
        }

        Remove(item);
        
        Add(item);

        return item.Value;
    }
    
    public void Put(int key, int value)
    {
        LRUCacheItem newItem;
        if (_data.TryGetValue(key, out var item))
        {
            Remove(item);
            newItem = item;
            item.Value = value;
        }
        else
        {
            newItem = new LRUCacheItem()
            {
                Key = key,
                Value = value
            };
        }

        if (_data.Count >= _capacity)
        {
            Remove(_leastRecent!);
        }
        
        Add(newItem);
    }

    private void Add(LRUCacheItem item)
    {
        _data.Add(item.Key, item);

        if (_mostRecent != null)
        {
            _mostRecent.Next = item;
            item.Prev = _mostRecent;
        }

        if (_leastRecent == null)
        {
            _leastRecent = item;
        }
        
        _mostRecent = item;
    }
    
    private void Remove(LRUCacheItem item)
    {
        _data.Remove(item.Key);

        if (item.Next != null)
        {
            item.Next.Prev = item.Prev;
        }
        
        if (item.Prev != null)
        {
            item.Prev.Next = item.Next;
        }

        if (item == _leastRecent)
        {
            _leastRecent = item.Next;
        }

        if (item == _mostRecent)
        {
            _mostRecent = item.Prev;
        }
        
        item.Next = null;
        item.Prev = null;
    }

    public class LRUCacheItem
    {
        public int Key { get; set; }
        public int Value { get; set; }
        public LRUCacheItem? Prev { get; set; }
        public LRUCacheItem? Next { get; set; }
    }
}