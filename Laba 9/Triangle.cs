using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_9
{
    class Triangle
    {
        double a;
        double b;
        double c;
        public static int count = 0;
        public double A
        {
            get
            {
                return a;
            }
            set
            {
                if (value < 0)
                    a = -1 * value;
                else
                    a = value;  
            }
        }
        public double B
        {
            get
            {
                return b;
            }
            set
            {
                if (value < 0)
                    b = -1 * value;
                else
                    b = value;
            }
        }
        public double C
        {
            get
            {
                return c;
            }
            set
            {
                if (value < 0)
                    c = -1 * value;
                else
                    c = value;
            }
        }
        public bool IsTriangle
        {
            get
            {
                if (a + b > c && a + c > b && b + c > a)
                {
                    return true;
                }
                return false;
            }

        }
        public Triangle()
        {
            a = 0;
            b = 0;
            c = 0;
            count++;
        }
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
            count++;
        }
        public void Show()
        {
            Console.WriteLine($"{a} сторона а, {b} сторона b, {c} сторона с");
        }
        public double CountArea(Triangle t)
        {
            double s = 0;
            s = Math.Pow(((t.A + t.B + t.C) * 0.5 * ((t.A + t.B + t.C) * 0.5 - t.A) * ((t.A + t.B + t.C) * 0.5 - t.B) * ((t.A + t.B + t.C) * 0.5 - t.C)), 0.5);
            return s;
        }
        public static double CountArea1(Triangle t)
        {
            double s = 0;
            s = Math.Pow(((t.A + t.B + t.C) * 0.5 * ((t.A + t.B + t.C) * 0.5 - t.A) * ((t.A + t.B + t.C) * 0.5 - t.B) * ((t.A + t.B + t.C) * 0.5 - t.C)), 0.5);
            return s;
        }
        public static Triangle operator ++(Triangle t)
        {
            return new Triangle(t.a + 1, t.b + 1, t.c + 1);
        }
        public static Triangle operator --(Triangle t)
        {
            return new Triangle(t.a - 1, t.b - 1, t.c - 1);
        }
        public static explicit operator double(Triangle t)
        {
            double s = Math.Pow(((t.A + t.B + t.C) * 0.5 * ((t.A + t.B + t.C) * 0.5 - t.A) * ((t.A + t.B + t.C) * 0.5 - t.B) * ((t.A + t.B + t.C) * 0.5 - t.C)), 0.5);
            return s;
        }
        public static implicit operator bool(Triangle t)
        {
            bool mark = t.IsTriangle;
            return mark;
        }
        public static bool operator >= (Triangle t1, Triangle t2)
        {
            return (double)t1 >= (double)t2;
        }


        public static bool operator <=(Triangle t1, Triangle t2)
        {
            return (double)t1 <= (double)t2;
        }




    }
}
