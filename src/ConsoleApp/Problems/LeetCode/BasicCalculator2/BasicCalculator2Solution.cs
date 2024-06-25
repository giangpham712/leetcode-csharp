using System.Text;

namespace ConsoleApp.Problems.LeetCode.BasicCalculator2;

public class BasicCalculator2Solution
{
    private static HashSet<string> Operations = new HashSet<string>()
    {
        "+", "-", "*", "/"
    };
    
    public int Solve(string s)
    {
        var number = new StringBuilder();
        var tokens = new List<string>();
        foreach (var c in s)
        {
            if (c >= '0' && c <= '9')
            {
                number.Append(c);
            }
            else
            {
                if (number.Length > 0)
                {
                    tokens.Add(number.ToString());
                    number = new StringBuilder();
                }

                if (c == ' ')
                {
                    continue;
                }
                
                tokens.Add(c.ToString());
            }
        }
        
        if (number.Length > 0)
        {
            tokens.Add(number.ToString());
        }

        var stack = new Stack<int>();

        var operation = "+";
        for (var index = 0; index < tokens.Count; index++)
        {
            var token = tokens[index];
            if (Operations.Contains(token))
            {
                operation = token;
            }
            else
            {
                if (operation == "*")
                {
                    stack.Push(stack.Pop() * int.Parse(token));
                }
                else if (operation == "/")
                {
                    stack.Push(stack.Pop() / int.Parse(token));
                }
                else if (operation == "-")
                {
                    stack.Push(-int.Parse(token));
                }
                else
                {
                    stack.Push(int.Parse(token));
                }
            }
        }

        var result = 0;

        while (stack.TryPop(out var value))
        {
            result += value;
        }

        return result;
    }

    public int Solve2(string s)
    {
        
        
        return default;
    }
}