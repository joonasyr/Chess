﻿namespace ChessLogic
{
    public class PawnPromotion : Move
    {
        public override MoveType Type => MoveType.Promotion;
        public override Position FromPos { get; }
        public override Position ToPos { get; }
        private readonly PieceType newType;
        public PawnPromotion(Position fromPos, Position toPos, PieceType newType)
        {
            FromPos = fromPos;
            ToPos = toPos;
            this.newType = newType;
        }

        private Piece CreatePromotionPiece(Player color)
        {
            return newType switch
            {
                PieceType.Knight => new Knight(color),
                PieceType.Bishop => new Bishop(color),
                PieceType.Rook => new Rook(color),
                _ => new Queen(color),
            };
        }

        public override bool Execute(Board board)
        {
            Piece piece = board[FromPos];
            board[FromPos] = null;

            Piece promotionPiece = CreatePromotionPiece(piece.Color);
            promotionPiece.HasMoved = true;
            board[ToPos] = promotionPiece;

            return true;
        }
    }
}
