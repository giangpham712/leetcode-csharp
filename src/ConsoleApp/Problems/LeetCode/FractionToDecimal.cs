using System.Text;

namespace ConsoleApp.Problems.LeetCode;

/// <summary>
/// Given a fraction. Convert it into a decimal. <br/> 
/// If the fractional part is repeating, enclose the repeating part in parentheses.
/// </summary>
public class FractionToDecimal
{
    public string Solve(int numerator, int denominator)
    {
        var intPart = (numerator / denominator).ToString();
        int remainder = numerator % denominator;
        
        if (remainder == 0) {
            return intPart;
        }
        
        var result = new StringBuilder(intPart + ".");
        var remainderMap = new Dictionary<int, int>();
        
        var index = result.ToString().Length;
        while (remainder > 0) {
            if (remainderMap.ContainsKey(remainder)) {
                int lastIndex = remainderMap[remainder];
                result.Insert(lastIndex, "(");
                result.Append(")");
                break;
            } else {
                remainderMap.Add(remainder, index);
            }
            
            remainder *= 10;
            String quotient = (remainder / denominator).ToString();
            result.Append(quotient);
            remainder = remainder % denominator;
            index++;
        }
        
        return result.ToString();
    }
}