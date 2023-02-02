namespace Game
{
    class Position
    {
        public int x;
        public int y;
        public int z;

        public Position(int x=0, int y=0, int z = 0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Position operator +(Position a, Position b) => new Position(a.x + b.x, a.y + b.y, a.z + b.z);
        public static bool operator ==(Position a, Position b) => a.x == b.x && a.y == b.y && a.z == b.z;
        public static bool operator !=(Position a, Position b) => a.x != b.x || a.y != b.y || a.z != b.z;
    }
}
