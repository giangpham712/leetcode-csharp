namespace ConsoleApp.Problems.LeetCode.LRUCache;

public class LRUCacheSolution2
{
    private readonly int _capacity;
    private readonly IDictionary<int, LRUCacheItem> _data;
    private LRUCacheItem? _leastRecent;
    private LRUCacheItem? _mostRecent;

    public LRUCacheSolution2(int capacity) {
        _capacity = capacity;
        _data = new Dictionary<int, LRUCacheItem>();
    }
    
    public int Get(int key)
    {
        return default;
    }
    
    public void Put(int key, int value)
    {
        
    }

    private void Add(LRUCacheItem item)
    {
        
    }
    
    private void Remove(LRUCacheItem item)
    {
        
    }

    public class LRUCacheItem
    {
        public int Key { get; set; }
        public int Value { get; set; }
        public LRUCacheItem? Prev { get; set; }
        public LRUCacheItem? Next { get; set; }
    }
}