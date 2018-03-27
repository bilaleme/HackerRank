using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class MyComparer : IComparer<string>
{
    public int Compare(string x, string y)
    {
        if (x.Length > y.Length)
            return 1;
        else if(x.Length == y.Length)
        {
            for (int i = 0; i < x.Length; i++)
            {
                if (y[i] > x[i])
                    return -1;
                else if (y[i] < x[i])
                    return 1;
            }

            return 0;
        }
        else
        {
            return -1;
        }
    }
}
class Solution
{ 
    static void bigSorting(string[] arr)
    {
        SortedDictionary<string, int> list = new SortedDictionary<string, int>(new MyComparer());
        
        foreach(var mstr in arr)
        {
            if(list.Keys.Contains(mstr))
            {
                list[mstr]++;
            } else
            {
                list.Add(mstr, 1);
            }
            
        }

        foreach(var item in list)
        {
            int iter = item.Value;
            while(iter-- > 0)
            {
                Console.WriteLine(item.Key);
            }
        }
        
    }

    static void Main1(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr = new string[n];
        for (int arr_i = 0; arr_i < n; arr_i++)
        {
            arr[arr_i] = Console.ReadLine();
        }
        bigSorting(arr);


    }
}
