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
        public Model()
        {
            A = Properties.Settings.Default.a;
            B = Properties.Settings.Default.b;
            C = Properties.Settings.Default.c;
        }
        public void setA(int a)
        {
            if (0 <= a && a <= 100)
            {
                if (a <= B)
                {
                    this.A = a;
                }
            }
            DataChanged.Invoke(this, null);

        }
        public void setB(int b)
        {
            if (0 <= b && b <= 100)
            {
                if (b < A)
                {
                    this.A = A - (B - b);
                    this.B = b;
                    if (A < 0) A = 0;
                }
                else if (b <= C)
                {
                    this.B = b;
                }
            }
            DataChanged.Invoke(this, null);
        }
        public void setC(int c)
        {
            if (0 <= c && c <= 100)
            {
                if (c < A)
                {
                   this.B = B - (C - c);
                   this.A = A - (C - c);
                }
                else if (c < B)
                {
                    this.B = B - (C - c);
                }
                if (A>B) A = B;
                if (A<0) this.A = 0;
                if (B<0) this.B = 0;
                this.C = c;
            }
            DataChanged.Invoke(this, null);

        }
        public int getA() { return A; }
        public int getB() { return B; }
        public int getC() { return C; }
        public void save()
        {
            Properties.Settings.Default.a = A;
            Properties.Settings.Default.b = B;
            Properties.Settings.Default.c = C;
            Properties.Settings.Default.Save();
        }
    }
}
