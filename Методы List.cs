using System;
using System.Collections.Generic;
using System.Threading;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
			List<string> lst = new List<string>();			
			lst.Add("Cлон");
			lst.Add("добрый вечер");
			lst.Add("как дела?");
			lst.Add("Поставьте 5");
			lst.Add("Спасибо!");
			lst.Add("Чмок");
            lst.Add("Cлон");
            do
            {
                string[] menu = new string[11] { "1.List.Contains(T item)", "2.List.Exists(Predicate<T> match)", "3.List.RemoveRange(int index, int count)",
                    "4.List.RemoveAll((Predicate<T> match))", "5.List.IndexOf(T item)", "6.List.Reverse()",
                    "7.List.Reverse(int index, int count)", "8.List.BinarySearch(T item)", "9.List.Clear()",
                    "10.Выход", "Введите цифру для выбора метода" };
                Console.WriteLine($"{menu[0]}\n{menu[1]}\n{menu[2]}\n{menu[3]}\n{menu[4]}\n{menu[5]}\n{menu[6]}\n{menu[7]}\n{menu[8]}\n{menu[9]}");
                int n = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (n)
                {
                    case 1:
                        Console.WriteLine(lst.Contains("как дела?"));
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine(lst.Exists(p => p.Length == 4));
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 3:
                        lst.RemoveRange(1,2);
                        foreach (string item in lst)
                            Console.WriteLine(item);
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 4:
                        lst.RemoveAll(p => p.Length == 8);
                        foreach (string item in lst)
                            Console.WriteLine(item);
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 5:
                       Console.WriteLine(lst.IndexOf("Cлон")); 
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 6:
                        lst.Reverse();
                        foreach (string item in lst)
                            Console.WriteLine(item);
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 7:
                        lst.Reverse(1, 4);
                        foreach (string item in lst)
                            Console.WriteLine(item);
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 8:
                        Console.WriteLine(lst.BinarySearch("Поставьте 5"));
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 9:
                        lst.Clear();
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
