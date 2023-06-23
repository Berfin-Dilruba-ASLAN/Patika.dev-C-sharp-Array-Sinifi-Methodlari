using System;

class Solution
{
    static void Main(String[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] mumlar = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        int maxHeight = 0;
        int maxHeightCandles = 0;

        for (int i = 0; i < n; i++)
        {
            if (mumlar[i] > maxHeight)
            {
                maxHeight = mumlar[i];
                maxHeightCandles = 1;
            }
            else if (mumlar[i] == maxHeight)
            {
                maxHeightCandles++;
            }
        }

        Console.WriteLine(maxHeightCandles);
    }
}
