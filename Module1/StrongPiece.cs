using System;

namespace Module1
{
    public class StrongPiece : Piece
    {
        public StrongPiece() : base("Strong Piece") {}
        
        public override void MakeAMove()
        {
            Console.Out.WriteLine("Strong Piece made 5 steps");
        }
    }
}