using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class SherlockAndSquares
{
    static int squares(int a, int b)
    {
        double firstRoot = Math.Sqrt(a);
        double secondRoot = Math.Sqrt(b);
        firstRoot = Math.Ceiling(firstRoot);
        secondRoot = Math.Ceiling(secondRoot);
        int count = 0;

        while(firstRoot <= secondRoot)
        {
            if (firstRoot * firstRoot <= b)
                count++;
            firstRoot++;
        }
        return count;
    }

    static void Main1(String[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < q; a0++)
        {
            string[] tokens_a = Console.ReadLine().Split(' ');
            int a = Convert.ToInt32(tokens_a[0]);
            int b = Convert.ToInt32(tokens_a[1]);
            int result = squares(a, b);
            Console.WriteLine(result);
        }
    }
}
