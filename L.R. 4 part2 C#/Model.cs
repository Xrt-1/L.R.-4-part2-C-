using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L.R._4_part2_C_
{
    public class Model
    {
        private int A, B, C;
        public System.EventHandler DataChanged;
        public void setA(int a)
        {
            if (0 <= a && a <= 100)
            {
                if (a <= B)
                {
                    A = a;
                }
                DataChanged.Invoke(this, null);
            }
        }
        public void setB(int b)
        {
            if (0 <= b && b <= 100)
            {
                if (b < A)
                {
                    A = A - (B - b);
                    B = b;
                    if (A < 0) A = 0;
                }
                else if (b <= C)
                {
                    B = b;
                }
                DataChanged.Invoke(this, null);
            }
        }
        public void setC(int c)
        {
            if (0 <= c && c <= 100)
            {
                if (c < A)
                {
                    B = B - (C - c);
                    A = A - (C - c);
                }
                else if (c < B)
                {
                    B = B - (C - c);
                }
                if (A<0) A = 0;
                if (B<0) B = 0;
                if (A>B) A = A - B;
                C = c;
                DataChanged.Invoke(this, null);
            }
        }
        public int getA() { return A; }
        public int getB() { return B; }
        public int getC() { return C; }

    }
}
