namespace ConsoleApp.Problems.LeetCode.PascalTriangle2;

public class PascalTriangle2Solution
{
    public IList<int> Solve(int rowIndex)
    {
        var result = new List<int>()
        {
            1
        };

        for (var i = 1; i <= rowIndex; i++)
        {
            var temp = result[0];
            for (var j = 1; j < i; j++)
            {
                (temp, result[j]) = (result[j], temp + result[j]);
            }

            result.Add(1);
        }
        
        return result;
    }
}