namespace ConsoleApp.Problems.RateLimiters;

public interface IRateLimiter
{
    bool RateLimit(Request request);
}

public class Request
{
    public int UserId { get; set; }
    public DateTime Time { get; set; }
}