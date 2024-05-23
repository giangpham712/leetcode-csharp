using System.Diagnostics;
using System.Text;

namespace ConsoleApp.Problems.LeetCode.MinimumRemoveToMakeValidParentheses;

public class MinimumRemoveToMakeValidParenthesesSolution
{
    public object Solve(string s)
    {
        var cursor = 0;
        var arrayStack = new int[s.Length];

        var toRemoves = new HashSet<int>();
        
        for (var i = 0; i < s.Length; i++)
        {
            var c = s[i];
            if (c != '(' && c != ')')
            {
                continue;
            }

            if (c == ')')
            {
                if (cursor > 0 && s[arrayStack[cursor - 1]] == '(')
                {
                    cursor--;
                }
                else
                {
                    toRemoves.Add(i);
                }
            }
            else
            {
                arrayStack[cursor] = i;
                cursor++;
            }
        }

        foreach (var c in arrayStack.Take(cursor))
        {
            toRemoves.Add(c);
        }

        var result = new StringBuilder();
        for (var i = 0; i < s.Length; i++)
        {
            if (!toRemoves.Contains(i))
            {
                result.Append(s[i]);
            }
        }

        return result.ToString();
    }
}