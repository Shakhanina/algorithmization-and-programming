using System;
using System.Collections.Generic;
using System.Threading;

namespace queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> q = new Queue<string>();
            q.Enqueue("one");
            q.Enqueue("two");
            q.Enqueue("three");
            q.Enqueue("four");
            q.Enqueue("five");
            String[] m = new String[10];
            m[0] = "10";
            m[1] = "12";
            m[2] = "15";
            m[3] = "35";
            m[4] = "7";
            m[5] = "87";
            m[6] = "48744";
            do
            {
                string[] menu = new string[11] { "1.Queue.CopyTo()", "2.Queue.TryDequeue(out T result)", "3.Queue<T>.ToArray",
                    "4.Queue<T>.Peek()", "5.Queue.GetHashCode()", "6.Queue.Equals()",
                    "7.Queue<T>.Dequeue", "8.Queue<T>.Contains(T)", "9.Queue<T>.Clear",
                    "10.Выход", "Введите цифру для выбора метода" };
                Console.WriteLine($"{menu[0]}\n{menu[1]}\n{menu[2]}\n{menu[3]}\n{menu[4]}\n{menu[5]}\n{menu[6]}\n{menu[7]}\n{menu[8]}\n{menu[9]}");
                int n = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (n)
                {
                    case 1:
                        q.CopyTo(m, 2);
                        foreach (Object b in m)
                        {
                            Console.WriteLine(b);
                        }
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 2:
                        var s = q.TryDequeue(out var p);  // s = true
                        if (s) Console.WriteLine(p); // ередает в переменную result первый элемент очереди с его удалением из очереди, возвращает true, если очередь не пуста и элемент успешно получен.
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 3:
                        Queue<string> copy = new Queue<string>(q.ToArray());
                        foreach (string num in copy)
                        {
                            Console.WriteLine(num);
                        }
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine(q.Peek());
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 5:
                        Console.WriteLine( q.GetHashCode());
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 6:
                        Console.WriteLine(q.Equals(q));
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 7:
                        Console.WriteLine(q.Dequeue());
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 8:
                        Console.WriteLine(q.Contains("one"));
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 9:
                        q.Clear();
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 10:
                        Console.Clear();
                        Console.WriteLine(" ^ ^             ");
                        Console.WriteLine("( . .)  < Чмок!!> ");
                        Console.WriteLine("<( )>            ");
                        Console.WriteLine(" ! !");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Введите еще раз");
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                }
            } while (true);
        }
    }
}
