using System;

public class ConsoleApplication
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter number of elements.");
        int M = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[M];
        for (int i = 0; i < M; i++) {
            Console.WriteLine("Enter element number {0}.", Convert.ToString(i + 1));
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine(CountPositive(arr, M));
        
        static int CountPositive(int[] arr, int M) {
            int count = 0;
            for (int i = 0; i < M; i++) {
                if (arr[i] > 0) {
                    count++;
                }
            }
            return count;
        }
    }
}
