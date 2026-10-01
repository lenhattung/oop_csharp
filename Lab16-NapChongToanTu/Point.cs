namespace Lab16_NapChongToanTu
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Point operator +(Point a, Point b)
        {
            return new Point(a.X + b.X, a.Y + b.Y);
        }

        public static Point operator -(Point p1, Point p2)
        {
            return new Point(
                p1.X - p2.X,
                p1.Y - p2.Y
            );
        }
        public static bool operator !=(Point p1, Point p2)
        {
            return !(p1 == p2);
        }
        public static bool operator ==(Point p1, Point p2)
        {
            return p1.X == p2.X && p1.Y == p2.Y;
        }

        public void Show()
        {
            Console.WriteLine($"({X}, {Y})");
        }
    }
}
