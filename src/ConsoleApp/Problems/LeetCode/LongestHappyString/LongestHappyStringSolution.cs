namespace ConsoleApp.Problems.LeetCode.LongestHappyString;

public class LongestHappyStringSolution
{
    public object Solve(int a, int b, int c)
    {
        var result = "";

        // Use a priority queue to rank the letters by highest occurence
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

        // We dequeue the letter with the highest occurence
        while (queue.TryDequeue(out var letter, out var letterCount))
        {
            // Add it to the result string if that doesn't violate the rule then decrease its occurence and re-enqueue (if not 0)
            // If it violates the rule, pick the next one to add and decrease its occurence, then re-enqueue both (if not 0)
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
                    // If it's not possible to add more letter, stop here
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