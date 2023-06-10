namespace ChessExample;

class Program
{
    public static void Main(string[] args)
    {
        var board = new Board();
        
        board.Print();
        
        board.Move("Pe2", "Pe1");
        
        board.Print();
    }
}