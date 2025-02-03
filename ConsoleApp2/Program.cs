using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("#1");
        Console.Write("Введите значение x: ");
        double x = double.Parse(Console.ReadLine());
        double y = 7 * Math.Pow(x, 2) + 3 * x + 6;
        Console.WriteLine($"Значение функции y = 7x^2 + 3x + 6: {y}");

        Console.Write("Введите значение a: ");
        double a = double.Parse(Console.ReadLine());
        double resultX = 12 * Math.Pow(a, 2) + 7 * a + 12;
        Console.WriteLine($"Значение функции x = 12a^2 + 7a + 12: {resultX}");

        Console.Write("#2");
        Console.Write("Введите значение a (a ≠ 0): ");
        double aEq = double.Parse(Console.ReadLine());
        Console.Write("Введите значение b: ");
        double b = double.Parse(Console.ReadLine());
        double xResult = -b / aEq;
        Console.WriteLine($"Решение уравнения: x = {xResult}");

        Console.Write("#3");
        Console.Write("Введите длину первого катета: ");
        double catet1 = double.Parse(Console.ReadLine());
        Console.Write("Введите длину второго катета: ");
        double catet2 = double.Parse(Console.ReadLine());
        double hypotenuse = Math.Sqrt(Math.Pow(catet1, 2) + Math.Pow(catet2, 2));
        double perimeterTriangle = catet1 + catet2 + hypotenuse;
        Console.WriteLine($"Периметр треугольника: {perimeterTriangle}");

        Console.Write("#4");
        Console.Write("Введите основание 1 трапеции: ");
        double base1 = double.Parse(Console.ReadLine());
        Console.Write("Введите основание 2 трапеции: ");
        double base2 = double.Parse(Console.ReadLine());
        Console.Write("Введите высоту трапеции: ");
        double heightTrapezoid = double.Parse(Console.ReadLine());
        double sideLengthTrapezoid = Math.Sqrt(Math.Pow((base2 - base1) / 2, 2) + Math.Pow(heightTrapezoid, 2));
        double perimeterTrapezoid = base1 + base2 + 2 * sideLengthTrapezoid;
        Console.WriteLine($"Периметр равнобедренной трапеции: {perimeterTrapezoid}");

        Console.Write("#5");
        Console.Write("Введите координаты первой вершины (x1 y1): ");
        string[] coords1 = Console.ReadLine().Split();
        double x1 = double.Parse(coords1[0]);
        double y1 = double.Parse(coords1[1]);

        Console.Write("Введите координаты второй вершины (x2 y2): ");
        string[] coords2 = Console.ReadLine().Split();
        double x2 = double.Parse(coords2[0]);
        double y2 = double.Parse(coords2[1]);

        Console.Write("Введите координаты третьей вершины (x3 y3): ");
        string[] coords3 = Console.ReadLine().Split();
        double x3 = double.Parse(coords3[0]);
        double y3 = double.Parse(coords3[1]);

        double side1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        double side2 = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
        double side3 = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));
        double perimeterTriangleCoords = side1 + side2 + side3;

        double s = perimeterTriangleCoords / 2;
        double area = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));

        Console.WriteLine($"Периметр треугольника: {perimeterTriangleCoords}");
        Console.WriteLine($"Площадь треугольника: {area}");

        Console.Write("#6");
        for (int i = 100; i < 1000; i++)
        {
            int lastDigit = i % 10;
            int newNumber = (i - lastDigit) / 10;
            if (newNumber * 10 + lastDigit == 237)
            {
                Console.WriteLine($"Число x: {i}");
                break;
            }
        }

        Console.Write("#7");
        bool A = true;
        bool B = false;
        bool C = false;
        Console.WriteLine($"A или B: {A || B}");
        Console.WriteLine($"A и B: {A && B}");
        Console.WriteLine($"B или C: {B || C}");

        Console.Write("#8");
        Console.WriteLine($"Не A и B: {(!A && B)}");
        Console.WriteLine($"A или не B: {(A || !B)}");
        Console.WriteLine($"A и B или C: {(A && B) || C}");

        Console.Write("#9");
        Console.WriteLine($"A или B и не C: {A || (B && !C)}");
        Console.WriteLine($"A и не B или C: {(A && !B) || C}");
        Console.WriteLine($"Не A и не B: {!A && !B}");
        Console.WriteLine($"A и (не B или C): {A && (!B || C)}");
        Console.WriteLine($"Не (A и C) или B: {!(A && C) || B}");
        Console.WriteLine($"A или (не (B и C)): {A || !(B && C)}");

        Console.Write("#10");
        Console.WriteLine("Логические выражения:");
        Console.WriteLine("а) x < 2 && y < 3;");
        Console.WriteLine("б) !(x < 2);");
        Console.WriteLine("в) x < 1 || y < 2;");
        Console.WriteLine("г) !(x < 0 && x < 5);");
        Console.WriteLine("д) x < 0 && y > 5;");
        Console.WriteLine("е) 10 < x && x < 20;");
        Console.WriteLine("ж) x > 3 || x < 1;");
        Console.WriteLine("з) 0 < y && y < 4 && x < 5;");
        Console.WriteLine("и) x > 3 && x < 10;");
    }
}