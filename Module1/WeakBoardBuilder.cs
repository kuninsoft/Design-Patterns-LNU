namespace Module1
{
    public class WeakBoardBuilder : BoardBuilder
    {
        private Board _board = new Board();
        
        public override void AddPieces(int count)
        {
            for (var i = 0; i < count; i++)
            {
                _board.Pieces.Add(PieceFactory.CreateWeak());
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