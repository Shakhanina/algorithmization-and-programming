using System;
using System.Collections.Generic;
using System.Threading;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> dict = new Dictionary<string, double>();
            dict.Add("Иванов Иван", 20000);
            dict.Add("Петров Петр", 35000);
            dict.Add("Сидоров Ив ан", 45000);
            dict.Add("Пупкин Петр", 70000);
            do
            {
                string[] menu = new string[11] { "1.Dictionary.ContainsKey(K key)", "2.Dictionary.ContainsValue(V value)", "3.Dictionary.Remove(K key)",
                    "4.Dictionary.TryAdd(K key, V value)", "5.Dictionary.GetHashCode()", "6.Dictionary<TKey,TValue>.GetEnumerator",
                    "7.Dictionary<TKey,TValue>.TryGetValue", "8.Dictionary<TKey,TValue>.EnsureCapacity(Int32)", "9.Dictionary.Clear()",
                    "10.Выход", "Введите цифру для выбора метода" };
                Console.WriteLine($"{menu[0]}\n{menu[1]}\n{menu[2]}\n{menu[3]}\n{menu[4]}\n{menu[5]}\n{menu[6]}\n{menu[7]}\n{menu[8]}\n{menu[9]}");
                int n = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (n)
                {
                    case 1:
                        Console.WriteLine(dict.ContainsKey("Иванов Иван"));
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine(dict.ContainsValue(476578454));
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 3:
                        dict.Remove("Пупкин Петр"); 
                        foreach (KeyValuePair<string, double> k in dict)
                        {
                            Console.WriteLine("{0}  {1}",k.Key, k.Value);
                        }
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 4:
                        dict.TryAdd("Сидоров ", 344459);
                        foreach (KeyValuePair<string, double> k in dict)
                        {
                            Console.WriteLine("{0}  {1}", k.Key, k.Value);
                        }
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 5:
                        Console.WriteLine(dict.GetHashCode());
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 6:
                        dict.GetEnumerator();
                        foreach (KeyValuePair<string, double> k in dict)
                        {
                            Console.WriteLine("{0}  {1}", k.Key, k.Value);
                        }
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 7:
                        double u;
                        Console.WriteLine(dict.TryGetValue("Петров Петр",out u));
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 8:
                        dict.EnsureCapacity(10);
                        foreach (KeyValuePair<string, double> k in dict)
                        {
                            Console.WriteLine("{0}  {1}", k.Key, k.Value);
                        }
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 9:
                        dict.Clear();
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
