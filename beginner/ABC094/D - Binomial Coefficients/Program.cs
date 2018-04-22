using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ret = new int[2];
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();

            uint N = uint.Parse(s1);
            string[] ss = s2.Split(' ');

            int[] num = new int[N];

            for (int i = 0; i < N; i++)
            {
                num[i] = int.Parse(ss[i]);
            }

            Array.Sort(num);
            int max = num[N - 1];
            int cen = max / 2;
            if (max % 2 > 0)
            {
                cen++;
            }
            int tmp = max;

            for (int i = 0; i < N; i++)
            {
                if (num[i] >= cen)
                {
                    if ((cen - tmp) <= (num[i] - cen))
                    {
                        ret[1] = tmp;
                    }
                    else
                    {
                        ret[1] = num[i];
                    }
                    break;
                }
                tmp = num[i];
            }

            ret[0] = max;
            Console.WriteLine(ret[0] + " " + ret[1]);
            Console.ReadLine();
        }
    }
}
