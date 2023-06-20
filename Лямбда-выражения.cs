using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace лямбда_выражения
{
    class Program
    {
        delegate double StrMod(double a, double b, double c);
        static void Main(string[] args)
        {
            StrMod cr = (double a, double b, double c) =>  {
                double result = a + b + c;
                return result / 3;
            };
            StrMod pro = (double a, double b, double c) => {
                return a * b *c;
            };
            StrMod Min = (double a, double b, double c) => {
                double[] p = {a,b,c};
                double min = p.Min();
                return min;
            };
            StrMod Max = (double a, double b, double c) => {
                double[] p = { a, b, c };
                double mak = p.Max();
                return mak;
            };
            StrMod Cym = (double a, double b, double c) => {
                return a + b + c;
            };
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("среднее арифметическое \t" + cr(a, b, c));
            Console.WriteLine("Произведение \t " + pro(a,b,c));
            Console.WriteLine("Mинимального \t" + Min(a, b, c));
            Console.WriteLine("Mаксимального \t" + Max(a, b, c));
            Console.WriteLine("Сумма \t" + Cym(a, b, c));
        }
    }
}
