namespace Operators;

public class Point(int x, int y)
{
    public int X { get; set; } = x;
    public int Y { get; set; } = y;

    // Überladen des + Operators
    public static Point operator +(Point p1, Point p2)
    {
        return new Point(p1.X + p2.X, p1.Y + p2.Y);
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}
