namespace ConsoleApp.Problems.LeetCode.ReverseWords;

public class ReverseWordsSolution
{
    public string Solve(string input)
    {
        return string.Join(" ", input.Split(" ", StringSplitOptions.TrimEntries|StringSplitOptions.RemoveEmptyEntries).Reverse());
    }
}