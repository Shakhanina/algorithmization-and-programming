using System;
using System.Collections;
using System.Threading;

namespace sortedList
{
    class Program
    {
        public static void Print(SortedList myList)
        {
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine("{0}:\t{1}", myList.GetKey(i), myList.GetByIndex(i));
            }
        }
        static void Main(string[] args)
        {
            String[] tem = new String[] { "The", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog" };
            SortedList sl = new SortedList();           
            sl.Add("здание", "жилое помещение");
            sl.Add("автомашина", "транспортное средство");
            sl.Add("книга", "набор печатных слов");
            sl.Add("яблоко", "съедобный плод");
            sl.Add("5", " цифра");
            do
            {
                string[] menu = new string[11] { "1.SortedList.ContainsKey(Object)", "2.SortedList.ContainsValue(Object)", "3.SortedList.RemoveAt(Int32)",
                    "4.SortedList.SetByIndex(Int32, Object)", "5.Object.GetHashCode", "6.SortedList.GetKey(Int32)",
                    "7.SortedList.GetKey(Int32)", "8.SortedList.Remove(Object)", "9.SortedList.Clear",
                    "10.Выход", "Введите цифру для выбора метода" };
                Console.WriteLine($"{menu[0]}\n{menu[1]}\n{menu[2]}\n{menu[3]}\n{menu[4]}\n{menu[5]}\n{menu[6]}\n{menu[7]}\n{menu[8]}\n{menu[9]}");
                int n = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (n)
                {
                    case 1:
                        Console.WriteLine(sl.ContainsKey("книга"));
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine(sl.ContainsValue("чмок!"));
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 3:
                        sl.RemoveAt(2);
                        Print(sl);
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 4:
                        sl.SetByIndex(3, "Как дела?");
                        Print(sl);
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 5:
                        Console.WriteLine("Хэш-код: " + sl.GetHashCode());
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 6:
                        Console.WriteLine(sl.GetKey(2));
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 7:
                        Console.WriteLine( sl.GetKey(1));
                        Console.WriteLine(sl.GetByIndex(1));
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 8:
                        sl.Remove("яблоко");
                        Print(sl);
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 9:
                        sl.Clear();
                        Print(sl);
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
