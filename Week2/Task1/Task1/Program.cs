using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int a = 1;
            int b = s.Length;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != s[b - i - 1])
                {
                    a++;
                }

            }
            if (a == 1)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            Console.ReadKey();
        }
    }
}
