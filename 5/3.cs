using System;

public class ConsoleApplication
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Enter number of elements in the array.");
        int num = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[num];
        for (int i = 0; i < num; i++) {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine(MaxMin(arr, num));
        
        static int MaxMin(int[] arr, int num) 
		{
		    int max = -10000;
		    int min = 10000;
            for (int i = 0; i < num; i++) {
                if (arr[i] > max) {
                    max = arr[i];
                }
                if (arr[i] < min) {
                    min = arr[i];
                }
            }
            return max - min;
		}
    }
}