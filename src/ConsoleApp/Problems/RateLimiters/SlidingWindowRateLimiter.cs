using System.Collections.Concurrent;
using Common;

namespace ConsoleApp.Problems.RateLimiters;

/// <summary>
/// 
/// </summary>
public class SlidingWindowRateLimiter : IRateLimiter
{
    private int _capacity;
    private readonly IDictionary<int, LinkedList<Counter>> _countersByUserId;

    public SlidingWindowRateLimiter(int capacity)
    {
        _capacity = capacity;
        _countersByUserId = new ConcurrentDictionary<int, LinkedList<Counter>>();
    }

    public bool RateLimit(Request request)
    {
        var window = GetTimeWindow(request.Time.ToUnixTimestamp());
        if (!_countersByUserId.TryGetValue(request.UserId, out var counters))
        {
            counters = new LinkedList<Counter>();
            counters.AddFirst(new Counter() { RequestCount = 1, TimeWindow = window });
            _countersByUserId.Add(request.UserId, counters);

            return true;
        }

        var totalRequestCount = counters.Where(x => x.TimeWindow > window - 60).Sum(x => x.RequestCount);
        if (totalRequestCount >= _capacity)
        {
            return false;
        }
        
        var windowCounter = counters.Last;
        if (windowCounter?.Value != null && windowCounter?.Value.TimeWindow == window)
        {
            windowCounter.Value.RequestCount++;
            return true;
        }
        else
        {
            counters.AddFirst(new Counter() { RequestCount = 1, TimeWindow = window });
            return true;
        }
    }

    private long GetTimeWindow(long timestamp)
    {
        return timestamp;
    }

    internal class UserRequestCounters
    {
        
    }
    
    internal class Counter
    {
        public long TimeWindow { get; set; }
        public int RequestCount { get; set; }
    }
}

