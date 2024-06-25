using System.Text;

namespace ConsoleApp.Problems.LeetCode.BasicCalculator;

public class BasicCalculatorSolution
{
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
        
        var current = 0;
        var currentOperation = "+"; 
        
        var stack = new Stack<(int, string)>();
        foreach (var c in tokens)
        {
            if (c == "(")
            {
                stack.Push((current, currentOperation));
                current = 0;
                currentOperation = "+";
            }
            else if (c == ")")
            {
                var prev = stack.Pop();
                current = DoCalculation(prev.Item1, current, prev.Item2);
            }
            else if (c == "+" || c == "-")
            {
                currentOperation = c;
            }
            else
            {
                current = DoCalculation(current, int.Parse(c), currentOperation);
            }
        }
        
        return current;
    }

    private int DoCalculation(int x, int y, string operation)
    {
        return operation == "+"
            ? x + y 
            : x - y;
    }
}