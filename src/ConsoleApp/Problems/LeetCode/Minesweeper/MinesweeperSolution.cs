namespace ConsoleApp.Problems.LeetCode.Minesweeper;

public class MinesweeperSolution
{
    public char[][] Solve(char[][] board, int[] click)
    {
        Expand(board, (click[0], click[1]), new HashSet<(int, int)>(), true);
        return board;
    }

    private void Expand(char[][] board, (int, int) cell, HashSet<(int, int)> seen, bool isClick)
    {
        var (x, y) = cell;
        if (x < 0 || x >= board.Length || y < 0 || y >= board[0].Length)
        {
            return;
        }
        
        if (!seen.Add((x, y)))
        {
            return;
        }
        
        if (board[x][y] == 'M')
        {
            if (isClick)
            {
                board[x][y] = 'X';
            }
        }
        else
        {
            var count = 0;
            if (x > 0)
            {
                if (board[x - 1][y] == 'M')
                {
                    count++;
                }
                
                if (y > 0 && board[x - 1][y - 1] == 'M')
                {
                    count++;
                }
                if (y < board[0].Length - 1 && board[x - 1][y + 1] == 'M')
                {
                    count++;
                }
            }

            if (x < board.Length - 1)
            {
                if (board[x + 1][y] == 'M')
                {
                    count++;
                }
                
                if (y > 0 && board[x + 1][y - 1] == 'M')
                {
                    count++;
                }
                if (y < board[0].Length - 1 && board[x + 1][y + 1] == 'M')
                {
                    count++;
                }
            }
            
            if (y > 0 && board[x][y - 1] == 'M')
            {
                count++;
            }
            if (y < board[0].Length - 1 && board[x][y + 1] == 'M')
            {
                count++;
            }
            
            if (count == 0)
            {
                Expand(board, (x - 1, y - 1), seen, false);
                Expand(board, (x - 1, y + 1), seen, false);
                Expand(board, (x + 1, y - 1), seen, false);
                Expand(board, (x + 1, y + 1), seen, false);
                Expand(board, (x, y - 1), seen, false);
                Expand(board, (x, y + 1), seen, false);
                Expand(board, (x - 1, y), seen, false);
                Expand(board, (x + 1, y), seen, false);
                board[x][y] = 'B';
            }
            else
            {
                board[x][y] = (char)('0' + count);
            }
        }
    }
}