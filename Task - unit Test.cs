using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Input value of a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Input value of b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Input value of c: ");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine(quadraticEquation(a, b, c));
    }

    public static string quadraticEquation(int a, int b, int c)
    {
        double determinant = Math.Pow(b, 2) - 4 * a * c;
        if (determinant < 0)
        {
            return "No real roots exist";
        }
        else if (determinant == 0)
        {
            double root = (-b / (2 * a));
            return "Ezeoka the equation has one root: x = " + root;
        }
        else
        {
            double root1 = ((-b + Math.Sqrt(determinant)) / (2 * a));
            double root2 = ((-b - Math.Sqrt(determinant)) / (2 * a));
            return "Ezeoka the equation has two roots: x1 = " + root1 + " and x2 = " + root2;
        }
    }
}