using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic
{
    public class Calculation1
    {
        int a, b, c;
        public Calculation1(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public int Calculate()
        {
            if (a > 5 || b > 5 || c > 5)
            {
                return (int)Math.Pow(a + b + c, 3);
            }
            else
            {
                return a + b + c;
            }
        }
    }

    public class Calculation2
    {
        int a, b;
        public Calculation2(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int Calculate()
        {
            int dob = 1;
            for (int i = a; i <= b; i++)
            {
                if (i % 11 == 0 || i % 5 == 2)
                {
                    dob *= i;
                }
            }
            return dob;
        }
    }
}
