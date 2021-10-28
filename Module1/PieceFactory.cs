namespace Module1
{
    public class PieceFactory
    {
        public static WeakPiece CreateWeak()
        {
            return new WeakPiece();
        }

        public static StrongPiece CreateStrong()
        {
            return new StrongPiece();
        }
    }
}