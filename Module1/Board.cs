using System;
using System.Collections.Generic;

namespace Module1
{
    public class Board
    {
        public List<Piece> Pieces { get; } = new List<Piece>();

        public void ListAllPiecesAndMoveThem()
        {
            foreach (var piece in Pieces)
            {
                Console.Out.WriteLine(piece.Name);
                piece.MakeAMove();
            }
        }
    }
}