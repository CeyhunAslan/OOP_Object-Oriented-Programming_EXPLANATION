using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Class
{
    internal class Geometry_Alan
    {
        //Tek bir amac o da alan hesaplama
        //Statik sınıflar içerisinde sabitlerimizi tanımlayabilir.
        public const double PI = 3.1414;


        public static double Kare(double a)
        { 
           return Math.Round(Math.Pow(a,2));
        }
        public static double Dikdortgen(double a, double b)
        {
            return Math.Round(a * b);
        }
        public static double Ucgen(double a , double h)
        { 
            return Math.Round(0.5 * (a * h));
        }
        public static double ParalelKenar(double b , double h)
        { 
          return Math.Round(b * h);
        }
        public static double Cember(double r)
        { 
            return Math.Round(PI * (Math.Pow(r,2)));
        }
        public static double Elips(double r , double r2)
        {
            return Math.Round(PI * r * r2);
        }
        public static double Yamuk(double h , double b , double b2)
        {
            return Math.Round(0.5 * (h * (b + b2)));
        }
    }
}
