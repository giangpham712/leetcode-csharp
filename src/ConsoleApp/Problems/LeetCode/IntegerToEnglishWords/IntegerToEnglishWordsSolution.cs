using System.Text;

namespace ConsoleApp.Problems.LeetCode.IntegerToEnglishWords;

public class IntegerToEnglishWordsSolution
{
    private Dictionary<int, string> OneToNineteen = new Dictionary<int, string>()
    {
        { 1, "One" },
        { 2, "Two" },
        { 3, "Three" },
        { 4, "Four" },
        { 5, "Five" },
        { 6, "Six" },
        { 7, "Seven" },
        { 8, "Eight" },
        { 9, "Nine" },
        { 10, "Ten" },
        { 11, "Eleven" },
        { 12, "Twelve" },
        { 13, "Thirteen" },
        { 14, "Fourteen" },
        { 15, "Fifteen" },
        { 16, "Sixteen" },
        { 17, "Seventeen" },
        { 18, "Eighteen" },
        { 19, "Nineteen" },
    };
    
    private Dictionary<int, string> TwentyToNinety = new Dictionary<int, string>()
    {
        { 20, "Twenty" },
        { 30, "Thirty" },
        { 40, "Forty" },
        { 50, "Fifty" },
        { 60, "Sixty" },
        { 70, "Seventy" },
        { 80, "Eighty" },
        { 90, "Ninety" }
    };
    
    public string NumberToWords(int num)
    {
        if (num == 0)
        {
            return "Zero";
        }
        
        var belowThousand = num % 1000;
        var thousands = (num / 1000) % 1000;
        var millions = (num / 1000000) % 1000;
        var billions = (num / 1000000000);

        var stringBuilder = new StringBuilder();

        if (billions > 0)
        {
            stringBuilder.Append($"{IntToString(billions)} Billion ");
        }
        
        if (millions > 0)
        {
            stringBuilder.Append($"{IntToString(millions)} Million ");
        }
        
        if (thousands > 0)
        {
            stringBuilder.Append($"{IntToString(thousands)} Thousand ");
        }
        
        if (belowThousand > 0)
        {
            stringBuilder.Append($"{IntToString(belowThousand)}");
        }

        return stringBuilder.ToString().TrimEnd();
    }

    private string IntToString(int input)
    {
        var belowHundred = input % 100;
        var hundreds = input / 100;

        var parts = new List<string>();
        if (hundreds > 0)
        {
            parts.Add($"{OneToNineteen[hundreds]} Hundred");
        }
        
        if (belowHundred > 0)
        {
            if (belowHundred < 20)
            {
                parts.Add($"{OneToNineteen[belowHundred]}");
            }
            else
            {
                parts.Add($"{TwentyToNinety[belowHundred / 10 * 10]}");

                if (belowHundred % 10 != 0)
                {
                    parts.Add($"{OneToNineteen[belowHundred % 10]}");
                }
            }
        }

        return string.Join(" ", parts);
    }
}