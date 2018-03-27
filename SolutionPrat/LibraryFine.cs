using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class LibraryFine
{

    static int libraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
    {
        if (y2 - y1 == 0)
        {
            if(m2 - m1 == 0)
            {
                if (d2 - d1 == 0)
                {
                    return 0;
                } else if (d2 - d1 < 0)
                {
                    return 15 * (d2 - d1) * (-1);
                } else
                {
                    return 0;
                }

            } else if (m2 - m1 < 0)
            {
                return 500 * (m2 - m1) * (-1);
            } else
            {
                return 0;
            }
        }
        else if (y2 - y1 < 0)
        {
            return 10000;
        }
        else
        {
            return 0;
        }
    }

    static void Main1(String[] args)
    {
        string[] tokens_d1 = Console.ReadLine().Split(' ');
        int d1 = Convert.ToInt32(tokens_d1[0]);
        int m1 = Convert.ToInt32(tokens_d1[1]);
        int y1 = Convert.ToInt32(tokens_d1[2]);
        string[] tokens_d2 = Console.ReadLine().Split(' ');
        int d2 = Convert.ToInt32(tokens_d2[0]);
        int m2 = Convert.ToInt32(tokens_d2[1]);
        int y2 = Convert.ToInt32(tokens_d2[2]);
        int result = libraryFine(d1, m1, y1, d2, m2, y2);
        Console.WriteLine(result);
    }
}
