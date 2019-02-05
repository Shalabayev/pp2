using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Program
    {
        static int[] MakeDoubleArray(int[] a)
        {
            int[] res = new int[a.Length * 2];
            for(int i = 0; i < a.Length; ++i)
            {
                res[2 * i] = res[2 * i + 1] = a[i];
            }
            return res;
        }

        static int[] ReadData()
        {
            int x = int.Parse(Console.ReadLine());
            string line = Console.ReadLine(); 
            string[] parts = line.Split();
            int[] t = new int[x];

            for(int i = 0; i < x; i++)
            {
                t[i] = int.Parse(parts[i]);
            }
            return t;
        } 

        static void PrintAnswer(int[] ans)
        {
            foreach(var q in ans)
            {
                Console.Write(q + " ");
            }
        }

        static void Main(string[] args)
        {
            int[] t = ReadData();
            int[] ans = MakeDoubleArray(t);
            PrintAnswer(ans);
        }
    }
}
