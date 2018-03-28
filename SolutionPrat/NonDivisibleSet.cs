using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    /*
     * Complete the nonDivisibleSubset function below.
     */
    static int nonDivisibleSubset(int k, int[] S)
    {
        /*
         * Write your code here.
         */
        List<int> outList = new List<int>();
        bool[] check = new bool[S.Length];

        for (int x=0; x<S.Length - 1; x++)
        { 
            for(int y = x + 1; y < S.Length; y++)
            {
                if((S[x] + S[y])%k != 0)
                {
                    if(!check[x])
                    {
                        check[x] = true;
                        outList.Add(S[x]);
                    }

                    if(!check[y])
                    {
                        check[y] = true;
                        outList.Add(S[y]);
                    }
                }
            }
        }
        return outList.Count;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[] S = Array.ConvertAll(Console.ReadLine().Split(' '), STemp => Convert.ToInt32(STemp))
        ;
        int result = nonDivisibleSubset(k, S);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
