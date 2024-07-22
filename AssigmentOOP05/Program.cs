using AssigmentOOP05.First_Project;
using AssigmentOOP05.Second_Project;
using AssigmentOOP05.Third_Project;

namespace AssigmentOOP05
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region First Project

            //    Point3D P1 = ReadPoint("P1");
            //    Point3D P2 = ReadPoint("P2");

            //    Console.WriteLine(P1.ToString());
            //    Console.WriteLine(P2.ToString());

            //    if (P1 == P2)
            //    {
            //        Console.WriteLine("P1 and P2 are equal.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("P1 and P2 are not equal.");
            //    }

            //    Point3D[] points = new Point3D[]
            //    {
            //    new Point3D(5, 2, 8),
            //    new Point3D(3, 4, 1),
            //    new Point3D(1, 7, 3)
            //    };

            //    Array.Sort(points);

            //    foreach (var point in points)
            //    {
            //        Console.WriteLine(point.ToString());
            //    }


            //    Point3D clone = (Point3D)P1.Clone();
            //    Console.WriteLine($"Cloned Point: {clone.ToString()}");
            //}

            //static Point3D ReadPoint(string pointName)
            //{
            //    int x, y, z;

            //    Console.WriteLine($"Enter the coordinates for {pointName}:");

            //    x = ReadCoordinate("X");
            //    y = ReadCoordinate("Y");
            //    z = ReadCoordinate("Z");

            //    return new Point3D(x, y, z);
            //}

            //static int ReadCoordinate(string coordinateName)
            //{
            //    int coordinate;

            //    while (true)
            //    {
            //        Console.Write($"{coordinateName}: ");
            //        string input = Console.ReadLine();

            //        if (int.TryParse(input, out coordinate))
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Invalid input.");
            //        }
            //    }

            //    return coordinate;



            #endregion


            #region Second Project

            //double num1 = 10;
            //double num2 = 5;

            //Console.WriteLine(Maths.Add(num1, num2));
            //Console.WriteLine(Maths.Subtract(num1, num2));
            //Console.WriteLine(Maths.Multiply(num1, num2));
            //Console.WriteLine(Maths.Divide(num1, num2));


            #endregion


            #region Third Project

            //Duration d1 = new Duration(1, 20, 30);
            //Duration d2 = new Duration(2, 05, 50);

            //Duration d3 = d1 + d2;
            //Console.WriteLine(d3); 

            //d3 = d1 + 7800;
            //Console.WriteLine(d3); 

            //d3 = 666 + d2;
            //Console.WriteLine(d3); 

            //d3 = ++d1;
            //Console.WriteLine(d1); 
            //Console.WriteLine(d3); 

            //d3 = --d2;
            //Console.WriteLine(d2); 
            //Console.WriteLine(d3); 

            //d3 = d1 - d2;
            //Console.WriteLine(d3); 

            //if (d1 > d2)
            //{
            //    Console.WriteLine("d1 is greater than d2");
            //}

            //if (d1 <= d2)
            //{
            //    Console.WriteLine("d1 is less than or equal to d2");
            //}

            //DateTime dt = (DateTime)d1;
            //Console.WriteLine(dt);

            #endregion




        }
    }
}
