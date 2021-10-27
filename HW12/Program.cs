using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус окружности:");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты центра окружности:\nКоордината Х0:");
            double x0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Координата Y0:");
            double y0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты произвольной точки:\nКоордината Х1:");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Координата Y1:");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Circle.Sq(r);
            Circle.Len(r);
            Circle.InOut(r, x0, x1, y0, y1);
            Console.ReadKey();
        }
    }
    static class Circle
    {
        public static double r;
        public static double x0;
        public static double x1;
        public static double y0;
        public static double y1;
        public static double S;
        public static double L;
        public static void Sq(double r)
        {
            S = Math.PI * Math.Pow(r, 2) / 4;
            S = Math.Round(S, 2);
            Console.WriteLine("Площадь круга равна: {0}", S);
            //Console.ReadKey();
        }
        public static void Len(double r)
        {
            L = 2 * Math.PI * r;
            L = Math.Round(L, 2);
            Console.WriteLine("Длина круга равна: {0}", L);
            //Console.ReadKey();
        }
        public static void InOut(double r, double x0, double x1, double y0, double y1)
        {
            if (Math.Pow((x1 - x0), 2) + Math.Pow((y1 - y0), 2) <= Math.Pow(r, 2))
            {
                Console.WriteLine("Точка находится внутри круга");
            }
            else
            {
                Console.WriteLine("Точка находится за пределами круга");
            }
        }
    }
}
