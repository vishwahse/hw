using System;

public class ConsoleApplication
{
    public static void Main(string[] args)
    {
		int num = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(DigitSum(num));
		
		static int DigitSum(int num) 
		{
		    int count = 0;
		    while (num > 0) 
		    {
		        count += num % 10;
		        num /= 10;
		    }
		    return count;
		}
    }
}