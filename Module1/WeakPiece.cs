using System;

namespace Module1
{
    public class WeakPiece : Piece
    {
        public WeakPiece() : base("Weak Piece") {}

        public override void MakeAMove()
        {
            Console.Out.WriteLine("Weak Piece made 1 step");
        }
    }
}