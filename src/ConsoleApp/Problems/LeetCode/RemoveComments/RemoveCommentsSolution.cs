using System.Text;

namespace ConsoleApp.Problems.LeetCode.RemoveComments;

public class RemoveCommentsSolution
{
    public IList<string> Solve(string[] source)
    {
        var results = new List<string>();

        var isInBlockComment = false;
        var currentLine = new StringBuilder();
        var endLine = false;
        for (int i = 0; i < source.Length; i++)
        {
            var line = source[i];
            
            while (line != "")
            {
                if (isInBlockComment)
                {
                    var blockCommentEndIndex = line.IndexOf("*/");
                    if (blockCommentEndIndex != -1)
                    {
                        line = line.Substring(blockCommentEndIndex + 2);
                        isInBlockComment = false;
                    }
                    else
                    {
                        break;
                    }
                }

                var lineCommentStartIndex = line.IndexOf("//");
                var blockCommentStartIndex = line.IndexOf("/*");

                if (lineCommentStartIndex != -1 &&
                    (blockCommentStartIndex == -1 || blockCommentStartIndex > lineCommentStartIndex))
                {
                    currentLine.Append(line.Substring(0, lineCommentStartIndex));
                    line = "";
                    endLine = true;
                }
                else if (blockCommentStartIndex != -1 &&
                    (lineCommentStartIndex == -1 || lineCommentStartIndex > blockCommentStartIndex))
                {
                    currentLine.Append(line.Substring(0, blockCommentStartIndex));
                    line = line.Substring(blockCommentStartIndex + 2);
                    isInBlockComment = true;
                    
                }
                else
                {
                    currentLine.Append(line);
                    line = "";
                    endLine = true;
                }
            }

            if (endLine && currentLine.Length > 0)
            {
                results.Add(currentLine.ToString());
                currentLine = new StringBuilder();
                endLine = false;
            }
        }
        
        return results;
    }
}