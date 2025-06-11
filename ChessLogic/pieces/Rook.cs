namespace ChessLogic
{
    public class Rook(Player color) : Piece
    {
        public override PieceType Type => PieceType.Rook;
        public override Player Color { get; } = color;

        public override Piece Copy()
        {
            Rook copy = new Rook(Color);
            copy.HasMoved = HasMoved;
            return copy;
        }
        private static readonly Direction[] dirs = new Direction[]
        {
            Direction.North,
            Direction.East,
            Direction.West,
            Direction.South,
        };

        public override IEnumerable<Move> GetMoves(Position from, Board board)
        {
            return MovePositionsInDirs(from, board, dirs).Select(to => new NormalMove(from, to));
        }
    }
}
