namespace ConsoleApp.Problems.LeetCode.ThreeDivisors;

public class ProblemSolution
{
    public bool Solve(int n)
    {
        var total = 2;

        for (var i = 2; i < n; i++) {
            if (n % i == 0) {
                total++;
            }

            if (total > 3) {
                return false;
            }
        }

        return total == 3;
    }
}