namespace ConsoleApp.Problems.LeetCode.ValidParentheses;

public class ValidParenthesesSolution
{
    public bool Solve(string s)
    {
        var stack = new char[s.Length];
        var head = 0;
        foreach (var c in s) {
            switch(c) {
                case '{':
                case '[':
                case '(':
                    stack[head++] = c;
                    break;
                case '}':
                    if(head == 0 || stack[--head] != '{') return false;
                    break;
                case ')':
                    if(head == 0 || stack[--head] != '(') return false;
                    break;
                case ']':
                    if(head == 0 || stack[--head] != '[') return false;
                    break;
            }
        }
        return head == 0;
    }
}