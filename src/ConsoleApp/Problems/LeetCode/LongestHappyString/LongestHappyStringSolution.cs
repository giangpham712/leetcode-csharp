namespace ConsoleApp.Problems.LeetCode.LongestHappyString;

public class LongestHappyStringSolution
{
    public object Solve(int a, int b, int c)
    {
        var result = "";

        var queue = new PriorityQueue<char, int>(new CountComparer());

        if (a > 0)
        {
            queue.Enqueue('a', a);
        }

        if (b > 0)
        {
            queue.Enqueue('b', b);
        }

        if (c > 0)
        {
            queue.Enqueue('c', c);
        }

        while (queue.TryDequeue(out var letter, out var letterCount))
        {
            if (result.Length >= 2 && 
                result[result.Length - 1] == result[result.Length - 2] &&
                result[result.Length - 1] == letter)
            {
                if (queue.TryDequeue(out var nextLetter, out var nextLetterCount))
                {
                    result += nextLetter;
                    if (nextLetterCount > 1)
                    {
                        queue.Enqueue(nextLetter, nextLetterCount - 1);
                    }
                    
                    queue.Enqueue(letter, letterCount);
                }
                else
                {
                    break;
                }
            }
            else
            {
                result += letter;
                if (letterCount > 1)
                {
                    queue.Enqueue(letter, letterCount - 1);
                }
            }
        }
        
        return result;
    }

    class CountComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return -x.CompareTo(y);
        }
    }
}