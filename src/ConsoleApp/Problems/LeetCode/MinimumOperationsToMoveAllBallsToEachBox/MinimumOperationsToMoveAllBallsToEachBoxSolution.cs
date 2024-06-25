namespace ConsoleApp.Problems.LeetCode.MinimumOperationsToMoveAllBallsToEachBox;

public class MinimumOperationsToMoveAllBallsToEachBoxSolution
{
    public int[] Solve(string boxes)
    {
        var result = new int[boxes.Length];

        var leftBalls = new int[boxes.Length];
        var rightBalls = new int[boxes.Length];
        var currentMoves = 0;
        
        for (var i = 1; i < boxes.Length; i++)
        {
            leftBalls[i] = leftBalls[i - 1];
            if (boxes[i - 1] == '1')
            {
                leftBalls[i]++;
            }

            currentMoves = currentMoves + leftBalls[i];
            result[i] += currentMoves;
        }
        
        currentMoves = 0;
        for (var i = boxes.Length - 2; i >= 0; i--)
        {
            rightBalls[i] = rightBalls[i + 1];
            if (boxes[i + 1] == '1')
            {
                rightBalls[i]++;
            }

            currentMoves = currentMoves + rightBalls[i];
            result[i] += currentMoves;
        }
        
        return result;
    }
}