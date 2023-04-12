using System;

public class ConsoleApplication
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Enter number of elements in the array.");
        int num = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[num];
        Console.WriteLine(OddCount(RandomInt(arr, num), num));
        
        static int[] RandomInt(int[] arr, int num) 
		{
		    Random rnd = new Random();
            for (int i = 0; i < num; i++) {
                arr[i] = rnd.Next(-99, 100);
            }
            return arr;
		}
		
		static int OddCount(int[] arr, int num) {
		    int count = 0;
		    for (int i = 0; i < num; i+=2) {
		        count += arr[i];
		    }
		    return count;
		}
    }
}