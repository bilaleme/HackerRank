using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class AppendAndDelete
{
    static int compDiff(string a, string b)
    {
        int count = 0;
        // at this point their lengths are same
        for (int x = 0; x < a.Length; x++)
        {
            if (a[x] != b[x])
            {
                count = x; break;
            }
        }

        return a.Substring(count).Length;
    }

    static bool checkfork(string sampleString,int k)
    {
        if (k % 2 == 0)
        {
            return true;
        }
        else
        {
            if (k >= 2 * sampleString.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    static string appendAndDelete(string s, string t, int k)
    {
        if(s.Length == t.Length)
        {
            if(s.CompareTo(t) == 0)
            {
                if (k % 2 == 0) return "Yes"; else
                {
                    if (k >= 2 * s.Length) return "Yes"; else return "No";
                }

            } else
            {
                int delta = compDiff(s, t);
                if (k >= 2 * delta) return "Yes"; else return "No";
            }
        } else
        {
            int opsdiff = Math.Abs(t.Length - s.Length);
            k = k - opsdiff;
            if (k < 0) return "No"; else
            {
                string us = (s.Length > t.Length) ? s.Substring(0, t.Length) : s;
                string ut = (t.Length > s.Length) ? t.Substring(0, s.Length) : t;
                if (us.CompareTo(ut) == 0)
                {
                    if (k % 2 == 0) return "Yes";
                    else
                    {
                        if (k >= 2 * us.Length) return "Yes"; else return "No";
                    }

                }
                else
                {
                    int delta = compDiff(us, ut);
                    if (k == 2 * delta) return "Yes"; else return "No";
                }
            }
        }
    }
    static void Main1(String[] args)
    {
        string s = Console.ReadLine();
        string t = Console.ReadLine();
        int k = Convert.ToInt32(Console.ReadLine());
        string result = appendAndDelete(s, t, k);
        Console.WriteLine(result);
    }
}
