using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic
{
    internal class Array2D
    {
        public bool error = false;
        int x_length = 5;
        int y_length = 5;
        private int[,] a;

        public int X_length
        {
            get { return x_length; }
            set { x_length = value; }
        }

        public int Y_length
        {
            get { return y_length; }
            set { y_length = value; }
        }

        public int this[int i, int j]
        {
            get
            {
                if(0 <= i && i < x_length && 0 <= j &&  j < y_length)
                    return a[i, j];
                else
                {
                    error = true;
                    return 0;
                }
            }
            set
            {
                if(0 <= i && i < x_length && 0 <= j && j < y_length && value >= -10 && value <= 10)
                    a[i, j] = value;
                else
                {
                    error = true;
                }
            }
        }

        public Array2D(int a_length, int b_length) 
        {
            x_length = a_length;
            y_length = b_length;

            a = new int[x_length, y_length];
            Random rand = new Random();

            for(int i = 0; i < x_length; i++)
                for(int j = 0; j < y_length; j++)
                    a[i, j] = rand.Next(0, 10);
        }

        public Array2D()
        {
            a = new int[x_length, y_length];
            Random rand = new Random();

            for(int i = 0; i < x_length; i++)
                for (int j = 0; j < y_length; j++)
                    a[i, j] = rand.Next(0, 10);
        }

        public int Dob_Gol
        {
            get
            {
                int p = 1;

                for(int i = 0; i < y_length; i++)
                    for(int j = x_length - i; j < x_length; j++)
                        p *= a[i, j];

                return p;
            }
        }
    }
}
