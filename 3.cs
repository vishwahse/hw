using System;

public class ConsoleApplication
{
    public static void Main(string[] args)
    {
        int[] arr = new int[8];
        for (int i = 0; i < 8; i++) 
        {
            Console.WriteLine("Введите {0}-й элемент",  i+1);
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
		
		for (int i = 0; i < 8; i++) 
		{
		    Console.WriteLine(arr[i]);
		}
    }
}