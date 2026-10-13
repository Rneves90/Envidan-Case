using SOLID.Assignment.Interfaces;

namespace SOLID.Assignment.Helpers;

public class ShapeComparator
{
    public IShape FindLargestShape(IEnumerable<IShape> shapes)
    {
        return shapes.MaxBy(s => s.GetArea())
            ?? throw new ArgumentException("Shapes cannot be empty");
    }

    public bool AreAllShapesEqual(IEnumerable<IShape> shapes)
    {
        var shapesList = shapes.ToList();

        if (shapesList.Count <= 1)
            return true;

        var firstArea = shapesList[0].GetArea();
        return shapesList.All(s => Math.Abs(s.GetArea() - firstArea) < double.Epsilon);
    }
}
