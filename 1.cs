using System;

public class ConsoleApplication
{
    public static void Main(string[] args)
    {
		int root = Convert.ToInt32(Console.ReadLine());
		int power = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(exponent(root, power));
		
		static int exponent(int root, int power) 
		{
		    int count = 1;
		    for (int i = 0; i < power; i++) {
		        count *= root;
		    }
		    return count;
		}
    }
}