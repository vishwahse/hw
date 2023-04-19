using System;

public class ConsoleApplication
{
    public static void Main(string[] args)
    {
        int[,] arr = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
        int num = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < arr.GetLength(0); i++) {
            for (int j = 0; j < arr.GetLength(1); j++) {
                if (arr[i, j] == num) {
                    Console.WriteLine("The indexes are {0} and {1}.", i, j);
                    num = -1;
                    break;
                }
            }
        }
        if (num != -1) {
            Console.WriteLine("The number is not in the array.");
        }
    }
}
