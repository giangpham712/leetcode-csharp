namespace ConsoleApp.Problems.LeetCode.LetterCombinations;

public class LetterCombinationsSolution
{
    private static IDictionary<char, string> _map = new Dictionary<char, string>()
    {
        { '2', "abc" },
        { '3', "def" },
        { '4', "ghi" },
        { '5', "jkl" },
        { '6', "mno" },
        { '7', "pqrs" },
        { '8', "tuv" },
        { '9', "wxyz" },
    };

    public IList<string> Solve(string digits)
    {
        if (digits == "")
        {
            return new List<string>();
        }

        var results = new List<string>();
        BackTrack(digits, "", results);
        return results;
    }

    private static void BackTrack(string digits, string combination, List<string> results)
    {
        if (digits.Length == 1)
        {
            foreach (var letter in _map[digits[0]])
            {
                results.Add($"{combination}{letter}");
            }
        }
        else
        {
            foreach (var letter in _map[digits[0]])
            {
                BackTrack(digits.Substring(1), $"{combination}{letter}", results);
            }
        }
    }

}