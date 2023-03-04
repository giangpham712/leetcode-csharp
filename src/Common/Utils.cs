namespace Common;

public static class Utils
{
    public static void Heapify(int[] arr)
    {
        
    }

    /// <summary>
    /// Convert a number from base 10 to base b
    /// </summary>
    /// <param name="n"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static long ConvertToBase(long n, int b)
    {
        var str = "";
        while(n != 0){
            str = (n % b) + str;
            n = n / b;
        }
       
        return long.Parse(str);
    }

    public static long ToUnixTimestamp(this DateTime dateTime)
    {
        return ((DateTimeOffset)dateTime).ToUnixTimeSeconds();
    }

    public static TreeNode ConstructBinaryTree(int[] values)
    {
        return null;
    }
}