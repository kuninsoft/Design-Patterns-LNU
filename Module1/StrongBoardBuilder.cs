namespace Module1
{
    public class StrongBoardBuilder : BoardBuilder
    {
        private Board _board = new Board();
        
        public override void AddPieces(int count)
        {
            for (var i = 0; i < count; i++)
            {
                _board.Pieces.Add(PieceFactory.CreateStrong());
            }
        }

        public override Board GetResult()
        {
            var result = _board;
            ResetProduct();
            return result;
        }

        private void ResetProduct()
        {
            _board = new Board();
        }
    }
}