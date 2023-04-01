using System;
using System.Collections;
using System.Threading;

namespace hashtable_
{
    class Program
    {
        public static void PrintValues(String[] myArr, char mySeparator)
        {
            for (int i = 0; i < myArr.Length; i++)
                Console.Write($"{mySeparator}{myArr[i]}");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("здание", "жилое помещение");
            ht.Add("автомашина", "транспортное средство");
            ht.Add("книга", "набор печатных слов");
            ht.Add("яблоко", "съедобный плод");
            var ht1 = new String[20];
            ht1[0] = "The";
            ht1[1] = "quick";
            ht1[2] = "brown";
            ht1[3] = "fox";
            ht1[4] = "jumps";
            ht1[5] = "over";
            ht1[6] = "the";
            ht1[7] = "lazy";
            ht1[8] = "dog";
            do
            {
                string[] menu = new string[11] { "1.Hashtable.ContainsKey(Object)", "2.Hashtable.ContainsValue(Object)", "3.Hashtable.Remove(Object)",
                    "4.Hashtable.Keys.CopyTo(Array, Int32)", "5.Hashtable.Values.CopyTo(Array, Int32)", "6.Hashtable.GetHashCode()",
                    "7.Hashtable.GetType()", "8.Hashtable.ToString", "9.Hashtable.Clear ",
                    "10.Выход", "Введите цифру для выбора метода" };
                Console.WriteLine($"{menu[0]}\n{menu[1]}\n{menu[2]}\n{menu[3]}\n{menu[4]}\n{menu[5]}\n{menu[6]}\n{menu[7]}\n{menu[8]}\n{menu[9]}");
                int n = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (n)
                {
                    case 1:
                        Console.WriteLine(ht.ContainsKey("здание"));
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine(ht.ContainsValue("жилое помещение"));
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 3:
                        ht.Remove("автомашина");
                        foreach (DictionaryEntry de in ht)
                            Console.WriteLine($"{de.Key} {de.Value}");
                        Console.WriteLine();
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 4:
                        ht.Keys.CopyTo(ht1, 6);
                        PrintValues(ht1, ' ');
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 5:
                        ht.Values.CopyTo(ht1, 3);
                        PrintValues(ht1, ' ');
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 6:
                      Console.WriteLine(ht.GetHashCode());
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 7:
                        Console.WriteLine(ht.GetType());
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 8:        
                        Console.WriteLine( ht["книга"].ToString());
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 9: 
                        ht.Clear(); 
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
