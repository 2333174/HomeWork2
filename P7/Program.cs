using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a;
            a = new int[100];
            int len = 0;
            int tot = 0;
            string s = "";
            s=Console.ReadLine();
            while (s != "")
            {
                a[len] = Int32.Parse(s);
                tot = a[len] + tot;
                len++;
                s = Console.ReadLine();
            }
            double ave= tot / ((double)len);
            len = len - 1;
            int max = a[0];
            int min = a[0];
            for (int i = 0; i <= len; i++)
            {
                if (a[i] > max) max = a[i];
                if (a[i] < min) min = a[i];
            }
            Console.WriteLine("最大值："+max);
            Console.WriteLine("最小值：" + min);
            Console.WriteLine("平均值："+ave);
            Console.WriteLine("总和："+tot);
        }
    }
}
