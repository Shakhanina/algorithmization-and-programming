using System;
using System.Collections.Generic;
using System.Threading;

namespace hashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>
            {
                "A",
                "B",
                "C",
                "D",
                "Q"
            };
            HashSet<string> set1 = new HashSet<string>();
            set1.Add("A");
            set1.Add("B");
            set1.Add("M");
            set1.Add("O");
            do
            {
                string[] menu = new string[11] { "1.HashSet.Contains()", "2.HashSet.Equals(Object)", "3.HashSet.Remove()",
                    "4.HashSet.GetHashCode()", "5.HashSet.Overlaps()", "6.HashSet.IsProperSubsetOf(IEnumerable)",
                    "7.HashSet.UnionWith(IEnumerable<T>)", "8.HashSet.ExceptWith(IEnumerable<T>)", "9.HashSet.Clear()", 
                    "10.Выход", "Введите цифру для выбора метода" };
                Console.WriteLine($"{menu[0]}\n{menu[1]}\n{menu[2]}\n{menu[3]}\n{menu[4]}\n{menu[5]}\n{menu[6]}\n{menu[7]}\n{menu[8]}\n{menu[9]}");
                int n = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (n)
                {
                    case 1:
                        Console.WriteLine(set.Contains("A"));
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine(set.Equals(set));
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 3:
                        set.Remove("Q");
                        foreach (string i in set)
                        {
                            Console.WriteLine(i);
                        }
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine(set.GetHashCode());
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 5:
                        Console.WriteLine(set.Overlaps(set1));
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 6:
                        Console.WriteLine(set1.IsProperSubsetOf(set));
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 7:
                        set.UnionWith(set1);
                        foreach (string i in set)
                        {
                            Console.Write(" {0}", i);
                        }
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 8:
                        set.ExceptWith(set1);
                        foreach (string i in set)
                        {
                            Console.Write(" {0}", i);
                        }
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 9:
                        set.Clear(); 
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
