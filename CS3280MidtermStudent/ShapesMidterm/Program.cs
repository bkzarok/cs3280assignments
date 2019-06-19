using System;

namespace ShapesMidterm
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Select: ");
            Console.WriteLine("1-Circle: ");
            Console.WriteLine("2-Triangle: ");
            Console.WriteLine("3-Square: ");
            int tmp = int.Parse(Console.ReadLine());
            // uncomment after implmenting Circle, Triangle, Square
            //switch (tmp)
            //{
            //    case 1:
            //        Console.Write("Enter the radius: ");
            //        var myCircle = new Circle(double.Parse(Console.ReadLine()));
            //        DisplayShape(myCircle);
            //        break;
            //    case 2:
            //        Console.Write("Enter the base: ");
            //        var b = double.Parse(Console.ReadLine());
            //        Console.Write("Enter the height: ");
            //        var h = double.Parse(Console.ReadLine());
            //        var myTriangle = new Triangle(h, b);
            //        DisplayShape(myTriangle);
            //        break;
            //    case 3:
            //        Console.Write("Enter the Side: ");
            //        var mySquare = new Square(double.Parse(Console.ReadLine()));
            //        DisplayShape(mySquare);
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Input");
            //        break;
            //}
            Console.Read();
        }

        private static void DisplayShape(Shape shape)
        {
            Console.WriteLine($"{shape.ToString()} Area = {shape.Area}");
        }
    }
}
