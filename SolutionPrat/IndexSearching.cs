using System;
using System.Collections.Generic;
using System.Text;

namespace SolutionPrat
{
    class IndexSearching
    {
        static int introTutorial(int V, int[] arr)
        {
            // Complete this function
            for(int x=0;x<arr.Length;x++)
            {
                if(arr[x] == V)
                    return x;
            }

            return -1;
        }

        static void Main1(String[] args)
        {
            int V = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            int result = introTutorial(V, arr);
            Console.WriteLine(result);
        }
    }
}
