namespace ConsoleApp.Problems.LeetCode.NumberOfStepsToReduceANumberInBinaryRepresentationToOne;

public class NumberOfStepsToReduceANumberInBinaryRepresentationToOneSolution
{
    public int Solve(string s)
    {
        var count = 0;

        var addOne = false; 
        for (var i = s.Length - 1; i >= 1; i--)
        {
            if (s[i] == '0')
            {
                if (addOne)
                {
                    count += 2;
                    addOne = true;
                }
                else
                {
                    count++;    
                }
            }
            else
            {
                if (addOne)
                {
                    count++;
                }
                else
                {
                    count += 2;
                    addOne = true;    
                }
            }
        }

        if (addOne)
        {
            count++;
        }
        
        return count;
    }
}