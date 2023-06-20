using System;
using System.Threading;

namespace деконструконструктор_и_интерфейс
{
    delegate void MyEventHandler();
    class MyEvent
    {
        public event MyEventHandler SomeEvent;
        public void OnSomeEvent()
        {
            if (SomeEvent != null) SomeEvent();
        }

    }
    delegate double StrMod(double a, double b);
    class MinCal
    {
        public double a;
        public double b;
        public MinCal(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public void Clo()
        {
            Console.WriteLine($"В результате сложения чисел {a} и {b}");
            Console.WriteLine($"Получился результат {a + b}");
        }
        public void Neclo()
        {
            Console.WriteLine($"В результате вычитание чисел {a} и {b}");
            Console.WriteLine($"Получился результат {a - b}");
        }
        public void Ymno()
        {
            Console.WriteLine($"В результате уиножении чисел {a} и {b}");
            Console.WriteLine($"Получился результат {a * b} ");
        }
        public void Delen()
        {
            if (b == 0)
            {
                Console.WriteLine("Деление на ноль не возможно");
               
            }
            else
            {
                Console.WriteLine($"В результате деления чисел {a} и {b}");
                Console.WriteLine($"Получился результат {a / b}");
            }
        }
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
                MinCal res = new MinCal(a,b);
                MyEvent evt = new MyEvent();
                string[] menu = new string[4] { "1.Сложение ", "2.Вычитание", "3.Умножение", "4.Деление" };
                Console.WriteLine($"{menu[0]}\n{menu[1]}\n{menu[2]}\n{menu[3]}");
                Console.WriteLine("Введите номер");
                int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        evt.SomeEvent += res.Clo;
                        evt.OnSomeEvent();
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 2:
                        evt.SomeEvent += res.Neclo;
                        evt.OnSomeEvent();
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 3:
                        evt.SomeEvent += res.Ymno;
                        evt.OnSomeEvent();
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 4:
                        evt.SomeEvent += res.Delen;
                        evt.OnSomeEvent();
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
