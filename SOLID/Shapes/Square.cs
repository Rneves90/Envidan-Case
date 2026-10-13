using SOLID.Assignment.Interfaces;

namespace SOLID.Assignment.Shapes;

public record Square(int Side) : IShape
{
    public double GetArea() => Math.Pow(Side, 2);
}
