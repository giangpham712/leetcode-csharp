namespace ConsoleApp.Problems.LeetCode.MyAtoi;

public class MyAtoiSolution
{
    public int Solve(string s)
    {
        const char plusSign = '+';
        const char minusSign = '-';

        long value = 0;
        var digitStarted = false;
        var signAdded = false;
        var multiplier = 1;

        foreach (var a in s.TrimStart())
        {
            if (!digitStarted)
            {
                if (a == plusSign || a == minusSign)
                {
                    if (signAdded)
                    {
                        break;
                    }

                    signAdded = true;
                    multiplier = (a == plusSign ? 1 : -1);
                    continue;
                }
            }

            if (!(a >= '0' && a <= '9'))
            {
                break;
            }

            digitStarted = true;

            value = value * 10 + (int) char.GetNumericValue(a);

            if (value * multiplier > int.MaxValue)
            {
                return int.MaxValue;
            }

            if (value * multiplier < int.MinValue)
            {
                return int.MinValue;
            }
        }

        return multiplier * (int)value;
    }
}