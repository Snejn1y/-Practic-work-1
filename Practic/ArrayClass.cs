using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic
{
    internal class ArrayClass
    {
        public bool error = false;
        int[] a;
        int length = 5;

        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        public int this[int index]
        {
            get
            {
                if (0 <= index && index < length)
                    return a[index];
                else
                {
                    error = true;
                    return 0;
                }
            }
            set
            {
                if(0 <= index && index < length && value >= -100 && value <= 100)
                    a[index] = value;
                else
                {
                    error = true;
                }
            }   
        }

        public ArrayClass()
        {
            a = new int[length];
        }

        public ArrayClass(int[] arr)
        {
            a = arr;
        }

        public ArrayClass(int min, int max, int size)
        {
            Length = size;
            a = new int[length];
            Random rand = new Random();
            for(int i = 0; i < length; i++)
            {
                a[i] = rand.Next(min, max);
            }
        }

        public (int, int, int) Count(ArrayClass opadi, ArrayClass temper)
        {
            int R = 0, S = 0, RS = 0;
            for(int i = 0; i < opadi.Length; i++)
            {
                if (temper[i] > 0)
                    R += opadi[i];
                else if (temper[i] < 0)
                    S += opadi[i];
                else
                    RS += opadi[i];
            }

            return (R, S, RS);
        }
    }

}
