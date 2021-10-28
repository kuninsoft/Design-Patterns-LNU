namespace Module1
{
    public abstract class Piece
    {
        public string Name { get; }
        protected Piece(string name)
        {
            Name = name;
        }

        public abstract void MakeAMove();
    }
}