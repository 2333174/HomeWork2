using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class P6
    {
        public bool Lone(int n)
        {
            if (n == 1) return false;
            for (int i = 2; i <= (int)Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;

        }
        static void Main(string[] args)
        {
            P6 z = new P6();
            string s = Console.ReadLine();
            int m = Int32.Parse(s);
            int t = 0;
            bool b1 = z.Lone(m);
            if (m == 1) Console.WriteLine("error");
            else
            {
                while (!z.Lone(m))
                {
                    for (int i = 2; i <= (int)Math.Sqrt(m); i++)
                    {
                        bool b = z.Lone(i);
                        if ((m % i == 0) && z.Lone(i))
                        {
                            if (t != i) { Console.WriteLine(i); t = i; }
                            m = m / i;
                            break;
                        }
                    }
                }
                if (t!=m) Console.WriteLine(m);
            }
        }
    }
}
