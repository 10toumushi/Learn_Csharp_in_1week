using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace Learn_Csharp_in_1week {
    /// <summary>
    /// Vector2Dサンプルクラス
    /// </summary>
    class Vector2D {
        public double X { get; set; }
        public double Y { get; set; }
        
        public Vector2D() {}
        public Vector2D(double x, double y) {
            X = x; Y = y;
        }
        public Vector2D(Vector2D v) {
            X = v.X; Y = v.Y;
        }


        public static void Show(string vector_name, Vector2D v) {
            Console.WriteLine("{0} = ({1}, {2})", vector_name, v.X, v.Y);
        }


        public void Add(Vector2D v) {
            X = X + v.X;
            Y = Y + v.Y;
        }
        public void Sub(Vector2D v) {
            X = X - v.X;
            Y = Y - v.Y;
        }
        public void Mul(double k) {
            X = X * k;
            Y = Y * k;
        }
        public double DotProduct(Vector2D v) {
            return X * v.X + Y * v.Y;
        }

    }


    /// <summary>
    /// Point2Dサンプルクラス
    /// </summary>
    class Point2D : Vector2D {

        public Point2D() { 
            X = 0;
            Y = 0;
        }
        public Point2D(double x, double y) {
            X = x;
            Y = y;
        }
        public Point2D(Point2D p) {
            X = p.X;
            Y = p.Y;
        }

        public double Distance(Point2D p) {
            double d = Math.Pow((X-p.X), 2) + Math.Pow((Y-p.Y), 2);
            return Numeric.GetSqurNum(d);
        }

        public override bool Equals(object o) {
            Point2D p = o as Point2D;
            if (X == p.X && Y == p.Y) {
                return true;
            } else {
                return false;
            }
        }
        
        public override string ToString() {
            string s = "(" + X.ToString() + ", " + Y.ToString() + ")";
            return s;
        }

    }


    /// <summary>
    /// Numericサンプルクラス
    /// </summary>
    class Numeric {
        public static int Max(int a, int b) {
            if (a > b) {
                return a;
            } else {
                return b;
            }
        }

        public static double GetSqurNum(double d) {
            if (d >= 0) {
                return Math.Sqrt(d);
            } else {
                Console.WriteLine("Please enter positive real number.");
                throw new ArgumentOutOfRangeException();
            }

        }

    }

} // Learn_Csharp_in_1week
