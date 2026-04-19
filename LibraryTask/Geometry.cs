namespace LibraryTask;

public static class Geometry
{
    public static double SquareArea(double a)
    {
        return a * a;
    }

    public static double RectangleArea(double a, double b)
    {
        return a * b;
    }

    public static double TriangleArea(double a, double h)
    {
        return 0.5 * a * h;
    }
}