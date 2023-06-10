namespace ChessExample;

public class Board
{
    private static char[,] _board = new char[8, 8]
    {
        { 'r', 'n', 'b', 'q', 'k', 'b', 'n', 'r' },
        { 'p', 'p', 'p', 'p', 'p', 'p', 'p', 'p' },
        { '*', '*', '*', '*', '*', '*', '*', '*' },
        { '*', '*', '*', '*', '*', '*', '*', '*' },
        { '*', '*', '*', '*', '*', '*', '*', '*' },
        { '*', '*', '*', '*', '*', '*', '*', '*' },
        { 'P', 'P', 'P', 'P', 'P', 'P', 'P', 'P' },
        { 'R', 'N', 'B', 'Q', 'K', 'B', 'N', 'R' }
    };
    private static Dictionary<char, int> _charMapper = new ()
    {
        {'a', 0},
        {'b', 1},
        {'c', 2},
        {'d', 3},
        {'e', 4},
        {'f', 5},
        {'g', 6},
        {'h', 7}
    };

    public void Print()
    {
        for (var i = 0; i < 8; i++)
        {
            for (var j = 0; j < 8; j++)
            {
                Console.Write(_board[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public void Move(string from, string to)
    {
        var figure = to[0];
        var toPosition = GetPosition(to);
        _board[toPosition.row, toPosition.column] = figure;
    }
    
    private (int row, int column) GetPosition(string move)
    {
        var intRow = int.Parse(move[2].ToString());
        var column = _charMapper[move[1]];
        var row = 8 - intRow;
        
        return (row, column);
    }
}