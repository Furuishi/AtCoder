using System;

namespace ABC094C
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();

            int N = int.Parse(s1);
            string[] ss = s2.Split(' ');

            int[] wrk = new int[N];
            int[] num = new int[N];

            int x = 0;
            for (int i = 0; i < N; i++)
            {
                x = int.Parse(ss[i]);
                wrk[i] = x;
                num[i] = x;
            }

            Array.Sort(num);
            Array.Reverse(num);

            int res = 0;
            for (int i = 0; i < N; i++)
            {
                int cp = N / 2 - 1;

                if (num[cp] <= wrk[i])
                {
                    res = num[cp + 1];
                }
                else
                {
                    res = num[cp];
                }

                Console.WriteLine(res);
            }

            Console.ReadLine();
        }
    }
}
