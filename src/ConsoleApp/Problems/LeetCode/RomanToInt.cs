namespace ConsoleApp.Problems.LeetCode;

public class RomanToInt
{
    private static Dictionary<char, int> Symbols = new()
    {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 },
    };
        
    public int Solve(string roman)
    {
        var result = 0;
        for (var i = 0; i < roman.Length; i++)
        {
            var currentValue = Symbols[roman[i]];

            if (i < roman.Length - 1)
            {
                var nextValue = Symbols[roman[i + 1]];
                if (nextValue > currentValue)
                {
                    result += (nextValue - currentValue);
                    i++;
                }
                else
                {
                    result += currentValue;    
                }
            }
            else
            {
                result += currentValue;
            }
        }
        
        return result;
    }
}