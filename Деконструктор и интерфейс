using System;
using System.Threading;

namespace деконструконструктор_и_интерфейс
{
    interface IMath
    {

        double Clo(double a, double b);
        double Neclo(double a, double b);
        double Ymno(double a, double b);
        double Delen(double a, double b);
    }
    delegate double StrMod(double a, double b);
    delegate void delg();
    class MinCal : IMath
    {

        public double Clo(double a, double b)
        {
            Console.WriteLine($"В результате сложения чисел {a} и {b}");
            Console.WriteLine($"Получился результат");
            return a + b;
        }
        public double Neclo(double a, double b)
        {
            Console.WriteLine($"В результате вычитание чисел {a} и {b}");
            Console.WriteLine($"Получился результат ");
            return a - b;
        }
        public double Ymno(double a, double b)
        {
            Console.WriteLine($"В результате уиножении чисел {a} и {b}");
            Console.WriteLine($"Получился результат ");
            return a * b;
        }
        public double Delen(double a, double b)
        {
            Console.WriteLine($"В результате деления чисел {a} и {b}");
            Console.WriteLine($"Получился результат");
            if(b==0)
            {
                Console.WriteLine("Деление на ноль не возможно");
                return double.NaN;
            }
            return a / b;
        }
        class Program
        {
            static void Main(string[] args)
            {
                do
                {
                    Console.WriteLine("Введите 1 число");
                    double a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите 2 число");
                    double b = double.Parse(Console.ReadLine());
                    MinCal res = new MinCal();
                    string[] menu = new string[4] { "1.Сложение ", "2.Вычитание", "3.Умножение", "4.Деление" };
                    Console.WriteLine($"{menu[0]}\n{menu[1]}\n{menu[2]}\n{menu[3]}");
                    Console.WriteLine("Введите номер");
                    int n = int.Parse(Console.ReadLine());
                    switch (n)
                    {
                        case 1:
                            StrMod C = res.Clo;
                            Console.WriteLine(C(a, b));
                            Thread.Sleep(3000);
                            Console.Clear();
                            break;
                        case 2:
                            StrMod N = res.Neclo;
                            Console.WriteLine(N(a, b));
                            Thread.Sleep(3000);
                            Console.Clear();
                            break;
                        case 3:
                            StrMod Y = res.Ymno;
                            Console.WriteLine(Y(a, b));
                            Thread.Sleep(3000);
                            Console.Clear();
                            break;
                        case 4:
                            StrMod D = res.Delen;
                            Console.WriteLine(D(a, b));
                            Thread.Sleep(3000);
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("Номера с таким действием нет");
                            break;
                    }
                } while (true);
            }
        }
    }
}
