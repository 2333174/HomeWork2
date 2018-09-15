using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[101];
            int len = 0;
            for (int i = 0; i < 99; i++)
            {
                a[i] = i + 2;
                len++;
            }
            int k = 2;
            while (k < 11)
            {
                int m = 0;
                for (int i = 0; i < len; i++)
                {
                    if ((a[i]%k!=0)||((a[i] % k == 0)&&(a[i]/k==1))) { a[m] = a[i];m++; }
                }
                k++;
                len = m;
            }
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
