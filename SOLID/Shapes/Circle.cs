using SOLID.Assignment.Interfaces;

namespace SOLID.Assignment.Shapes;

public record Circle(int Radius) : IShape
{
    public double GetArea() => Math.PI * Math.Pow(Radius, 2);
}
