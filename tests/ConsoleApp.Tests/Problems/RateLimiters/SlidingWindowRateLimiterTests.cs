using ConsoleApp.Problems.RateLimiters;
using Xunit.Abstractions;

namespace ConsoleApp.Tests.Problems.RateLimiters;

public class RateLimiterTests
{
    private readonly ITestOutputHelper _testOutputHelper;

    public RateLimiterTests(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Theory]
    [MemberData(nameof(TestCase1))]
    public void RateLimit(int capacity, List<Request> userRequests, List<bool> expected)
    {
        var rateLimiter = new SlidingWindowRateLimiter(capacity);
        var actual = new List<bool>();

        foreach (var request in userRequests)
        {
            var allowed = rateLimiter.RateLimit(request);
            actual.Add(allowed);
            
            _testOutputHelper.WriteLine($"{request.Time} = {allowed}");
        }

        Assert.Equal(string.Join(" ", expected), string.Join(" ", actual));
    }
    
    public static IEnumerable<object[]> TestCase1()
    {
        // Max 5 requests per minute
        {
            var capacity = 5;
            var userRequests = new List<Request>()
            {
                new Request
                {
                    UserId = 1,
                    Time = DateTime.Parse("2022-10-24 12:00:00Z")
                },
                new Request {
                    UserId = 1,
                    Time = DateTime.Parse("2022-10-24 12:00:02Z")
                },
                new Request {
                    UserId = 1,
                    Time = DateTime.Parse("2022-10-24 12:00:05Z")
                },
                new Request {
                    UserId = 1,
                    Time = DateTime.Parse("2022-10-24 12:00:07Z")
                },
                new Request {
                    UserId = 1,
                    Time = DateTime.Parse("2022-10-24 12:00:20Z")
                },
                new Request {
                    UserId = 1,
                    Time = DateTime.Parse("2022-10-24 12:00:30Z")
                },
                new Request {
                    UserId = 1,
                    Time = DateTime.Parse("2022-10-24 12:01:00Z")
                },
                new Request {
                    UserId = 1,
                    Time = DateTime.Parse("2022-10-24 12:01:01Z")
                }
            };

            var expected = new List<bool>()
            {
                true, true, true, true, true, false, true, false
            };
            
            yield return new object[] { capacity, userRequests, expected };
        }

        {
            var capacity = 5;
            var userRequests = new List<Request>()
            {

            };

            var expected = new List<bool>()
            {

            };
            
            yield return new object[] { capacity, userRequests, expected };
        }
    }
}