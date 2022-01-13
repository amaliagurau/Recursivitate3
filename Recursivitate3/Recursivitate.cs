using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursivitate3
{
    class Recursivitate
    {
        public static int Fibonacci(int a, int b, int n, int p)
        {
            if (n == p)
                return a;
            else
                return Fibonacci(b, a + b, n + 1, p);


        }
    }
}
