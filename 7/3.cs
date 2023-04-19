using System;

public class ConsoleApplication
{
    public static void Main(string[] args)
    {
        int[,] arr = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
        double sum = 0.0;
        for (int j = 0; j < arr.GetLength(1); j++) {
            for (int i = 0; i < arr.GetLength(0); i++) {
                sum += Convert.ToDouble(arr[i, j]);
            }
            Console.WriteLine(Math.Round(sum/arr.GetLength(0), 1));
            sum = 0;
        }
    }
}
