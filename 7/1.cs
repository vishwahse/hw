using System;

public class ConsoleApplication
{
    public static void Main(string[] args)
    {
        int m = Convert.ToInt32(Console.ReadLine());
        int n = Convert.ToInt32(Console.ReadLine());
        Arr(m, n);
        static double[,] Arr(int m, int n) {
            var random = new Random();
            double[,] arr = new double[m, n];
            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    arr[i, j] = random.NextDouble();
                    Console.WriteLine(arr[i, j]);
                }
            }
            return arr;
        }
    }
}
