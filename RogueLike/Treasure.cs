namespace RogueLike
{
    public class Treasure
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Treasure(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }

}
