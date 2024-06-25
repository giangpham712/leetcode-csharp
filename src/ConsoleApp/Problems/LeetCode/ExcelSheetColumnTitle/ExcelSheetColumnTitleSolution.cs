using System.Text;

namespace ConsoleApp.Problems.LeetCode.ExcelSheetColumnTitle;

public class ExcelSheetColumnTitleSolution
{
    const string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    public string Solve(int columnNumber)
    {
        var str = "";
        var remainder = columnNumber;
        while (columnNumber > letters.Length)
        {
            remainder = columnNumber % letters.Length;
            columnNumber = columnNumber / letters.Length;

            var letter = letters[(remainder - 1 + letters.Length) % letters.Length];
            str = letter + str;

            if (remainder == 0) {
                columnNumber--;
            }
        }

        if (columnNumber > 0)
        {
            
            var letter = letters[(columnNumber - 1 + letters.Length) % letters.Length];
            str = letter + str;
        }
        
        return str;
    }
}