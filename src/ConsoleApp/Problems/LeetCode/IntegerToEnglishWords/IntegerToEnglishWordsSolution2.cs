namespace ConsoleApp.Problems.LeetCode;

public class IntegerToEnglishWordsSolution2
{
    public string Solve(int num)
    {
        if (num == 0) return "Zero";
        
        var length = num.ToString().Length;
 
        var words = new List<string>();
        
        var skipThousand = true;
        for (var i = length - 1; i >= 0; i--) {
                       
            var divider = Convert.ToInt32(Math.Pow(10, i));

            if (num / 10 >= divider) {
                num = num % (divider * 10);
            }
            
            var current = num / divider;
            
            if (i % 3 == 2) {
                words.Add(Ones(current));
                if (current > 0)
                    words.Add("Hundred");
                
                if (current > 0) {
                    skipThousand = false;
                }
                
            } else if (i % 3 == 1) {    
                if (current >= 2) {
                    words.Add(Tens(current * 10));
                } else if (current >= 1) {
                    words.Add(Tens(num / (divider / 10)));
                    i--;
                }
                if (current > 0) {
                    skipThousand = false;
                }
            } else {
                words.Add(Ones(current));
                if (current > 0) {
                    skipThousand = false;
                }
            }
            

            if (!skipThousand) {
                if (i == 9) {
                    words.Add("Billion");
                    skipThousand = true;
                } else if (i == 6) {
                    words.Add("Million");
                    skipThousand = true;
                } else if (i == 3) {
                    words.Add("Thousand");
                    skipThousand = true;
                }
            }
        }
                              
        return string.Join(" ", words.Where(x => x != null));
    }
    
    private string Ones(int num) {
        switch(num) {
            case 1:
                return "One";
            case 2:
                return "Two";
            case 3:
                return "Three";
            case 4:
                return "Four";
            case 5:
                return "Five";
            case 6:
                return "Six";
            case 7:
                return "Seven";
            case 8:
                return "Eight";
            case 9:
                return "Nine";
            default:
                return null;
        }
    }
    
    private string Tens(int num) {

        switch(num) {
            case 10:
                return "Ten";
            case 11:
                return "Eleven";
            case 12:
                return "Twelve";
            case 13:
                return "Thirteen";
            case 14:
                return "Fourteen";
            case 15:
                return "Fifteen";
            case 16:
                return "Sixteen";
            case 17:
                return "Seventeen";
            case 18:
                return "Eighteen";
            case 19:
                return "Nineteen";
            case 20:
                return "Twenty";
            case 30:
                return "Thirty";
            case 40:
                return "Forty";
            case 50:
                return "Fifty";
            case 60:
                return "Sixty";
            case 70:
                return "Seventy";
            case 80:
                return "Eighty";
            case 90:
                return "Ninety";
            default:
                return null;

        }
    }
}