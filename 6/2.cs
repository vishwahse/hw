using System;

public class ConsoleApplication
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter element b1.");
        double b1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter element k1.");
        double k1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter element b2.");
        double b2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter element k2.");
        double k2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("The intersection is {0}, {1}.", Convert.ToString(Intersection(b1, k1, b2, k2)[0]), Convert.ToString(Intersection(b1, k1, b2, k2)[1]));
        
        static double[] Intersection(double b1, double k1, double b2, double k2) {
            double x = (b1 - b2)/(k2 - k1);
            double y = k1*x + b1;
            double[] arr = new double[2] {x, y};
            return arr;
        }
    }
}
