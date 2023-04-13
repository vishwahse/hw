using System;

public class ConsoleApplication
{
    public static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        if (num >= 6) {
            Console.WriteLine("да");
        }
        else {
            Console.WriteLine("нет");
        }
    }
}
