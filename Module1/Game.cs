namespace Module1
{
    public class Game
    {
        private static Game _instance;
        private static readonly object locker = new object(); // Used to make this singleton thread-safe

        public static Game Instance
        {
            get
            {
                lock (locker)
                {
                    if (_instance is null) _instance = new Game();
                }
                return _instance;
            }
        }

        public void StartEasyGame()
        {
            BoardBuilder boardBuilder = new StrongBoardBuilder();
            boardBuilder.AddPieces(16);

            var board = boardBuilder.GetResult();
            board.ListAllPiecesAndMoveThem();
        }
        
        
        public void StartHardGame()
        {
            BoardBuilder boardBuilder = new WeakBoardBuilder();
            boardBuilder.AddPieces(16);

            var board = boardBuilder.GetResult();
            board.ListAllPiecesAndMoveThem();
        }
        
        // Making constructor private
        private Game() {}
    }
}