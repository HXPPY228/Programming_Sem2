using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _353504_Стецурин_7
{
    public class Vector
    {
        private int _a; 
        private int _b; 
        private int _c;
        public Vector()
        {
            A = 0;
            B = 0;
            C = 0;
        }
        public Vector(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }
        public int A { 
            get { return _a; }
            set { _a = value; }
        }
        public int B { 
            get { return _b; } 
            set {  _b = value; } 
        }
        public int C
        {
            get { return _c; }
            set { _c = value; }
        }
        public override string ToString()
        {
            return $"({A}, {B}, {C})";
        }
        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector(a.A + b.A, a.B + b.B, a.C + b.C);
        }
        public static Vector operator -(Vector a, Vector b)
        {
            return new Vector(a.A - b.A, a.B - b.B, a.C - b.C);
        }
        public static Vector operator ++(Vector a)
        {
            return new Vector(a.A + 1, a.B + 1, a.C + 1);
        }
        public static Vector operator --(Vector a)
        {
            return new Vector(a.A - 1, a.B - 1, a.C - 1);
        }
        public static Vector operator *(Vector a, int b)
        {
            return new Vector(a.A * b, a.B * b, a.C * b);
        }
        public static Vector operator /(Vector a, int b)
        {
            if (b == 0) throw new DivideByZeroException("Деление на ноль!");
            return new Vector(a.A / b, a.B / b, a.C / b);
        }
        public static bool operator ==(Vector a, Vector b)
        {
            return a.A == b.A && a.B == b.B && a.C == b.C;
        }
        public static bool operator !=(Vector a, Vector b)
        {
            return !(a==b);
        }
        public double Module()
        {
            return Math.Sqrt(A * A + B * B + C * C);
        }
        public static bool operator <(Vector a, Vector b)
        {
            return a.Module() < b.Module();
        }
        public static bool operator >(Vector a, Vector b)
        {
            return a.Module() > b.Module();
        }
        public static explicit operator Vector(int x)
        {
            return new Vector(x, x, x);
        }
        public static explicit operator double(Vector a)
        {
            return (double)a.Module();
        }
        public static explicit operator bool(Vector a)
        {
            return a.A != 0 || a.B != 0 || a.C != 0;
        }
        public int this[int i]
        {
            get
            {
                switch (i)
                {
                    case 0: return _a;
                    case 1: return _b;
                    case 2: return _c;
                    default: throw new IndexOutOfRangeException();
                }
            }
            set
            {
                switch (i)
                {
                    case 0: A = value; break;
                    case 1: B = value; break;
                    case 2: C = value; break;
                    default: throw new IndexOutOfRangeException();
                }
            }
        }
    }
}
