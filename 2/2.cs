using System;

public class ConsoleApplication
{
    public static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        if (num < 100) {
            Console.WriteLine("третьей цифры нет");
        }
        else {
            while (num > 999) {
                num /= 10;
            }
            Console.WriteLine(num % 10);
        }
    }
}
