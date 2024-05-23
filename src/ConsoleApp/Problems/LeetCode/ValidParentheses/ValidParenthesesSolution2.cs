namespace ConsoleApp.Problems.LeetCode.ValidParentheses;

public class ValidParenthesesSolution2
{
    private static Dictionary<char, char> Brackets = new Dictionary<char, char>()
    {
        { '[', ']' },
        { '{', '}' },
        { '(', ')' },
    };
    
    public bool Solve(string s)
    {
        var stack = new char[s.Length];

        var cursor = 0;
        foreach (var c in s)
        {
            if (!Brackets.ContainsKey(c))
            {
                if (cursor > 0 && 
                    Brackets.TryGetValue(stack[cursor - 1], out var closingBracket) && 
                    c == closingBracket)
                {
                    cursor--;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                stack[cursor] = c;
                cursor++;
            }
        }

        return cursor == 0;
    }
}