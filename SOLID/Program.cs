// See https://aka.ms/new-console-template for more information

using SOLID.Assignment.Helpers;
using SOLID.Assignment.Interfaces;
using SOLID.Assignment.Shapes;

var circle = new Circle(Random.Shared.Next(10) + 1);
var triangle = new RightAngledTriangle(Random.Shared.Next(10) + 1, Random.Shared.Next(10) + 1);
var square = new Square(Random.Shared.Next(10) + 1);

var shapes = new List<IShape> { circle, triangle, square };
var shapeComparator = new ShapeComparator();

IShape largestShape = shapeComparator.FindLargestShape(shapes);

foreach (var shape in shapes)
{
    Console.WriteLine($"The area of the {shape.GetType().Name} is {shape.GetArea()}");
}

if (shapeComparator.AreAllShapesEqual(shapes))
{
    Console.WriteLine($"All shapes have the same area of {largestShape.GetArea()}!");
}
else
{
    Console.WriteLine($"The {largestShape.GetType().Name} is the largest with an area of {largestShape.GetArea()}");
}