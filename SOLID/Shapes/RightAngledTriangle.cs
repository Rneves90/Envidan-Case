using SOLID.Assignment.Interfaces;

namespace SOLID.Assignment.Shapes;

public record RightAngledTriangle(int Width, int Height) : IShape
{
    public double GetArea() => Width * Height / 2.0;
}
