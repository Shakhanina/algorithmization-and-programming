using System;
using System.Collections.Generic;
using System.Threading;

namespace sortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<char> ss = new SortedSet<char>();
            ss.Add('A');
            ss.Add('B');
            ss.Add('C');
            ss.Add('Z');
            SortedSet<char> ss1 = new SortedSet<char>();
            ss1.Add('V');
            ss1.Add('N');
            ss1.Add('Q');

            do
            {
                string[] menu = new string[11] { "1.SortedSet.Contains()", "2.SortedSet.Equals(Object)", "3.SortedSet.Remove()",
                    "4.SortedSet.GetHashCode()", "5.SortedSet.Reverse()", "6.SortedSet.UnionWith(IEnumerable<T>)",
                    "7.SortedSet.IsSubsetOf(IEnumerable<T>)", "8.SortedSet.IsProperSupersetOf(IEnumerable<T>)", "9.SortedSet.Clear()",
                    "10.Выход", "Введите цифру для выбора метода" };
                Console.WriteLine($"{menu[0]}\n{menu[1]}\n{menu[2]}\n{menu[3]}\n{menu[4]}\n{menu[5]}\n{menu[6]}\n{menu[7]}\n{menu[8]}\n{menu[9]}");
                int n = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (n)
                {
                    case 1:
                        Console.WriteLine(ss.Contains('C'));
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine(ss.Equals(ss));
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 3:
                        ss.Remove('Z');
                        foreach (char str in ss)
                        {
                            Console.WriteLine(str);
                        }
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine(ss.GetHashCode());
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 5:
                        ss1.Reverse();
                        foreach (char str in ss1)
                        {
                             Console.WriteLine(str);
                        }
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 6:
                        ss.UnionWith(ss1);
                        foreach (char str in ss)
                        {
                            Console.WriteLine(str);
                        }
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 7:
                        Console.WriteLine(ss1.IsSubsetOf(ss));
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 8:
                        Console.WriteLine(ss1.IsProperSupersetOf(ss));
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 9:
                        ss.Clear();
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
