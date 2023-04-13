using System;

public class ConsoleApplication
{
    public static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine((num%100)/10);
    }
}
