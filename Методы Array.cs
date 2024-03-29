using System;
using System.Collections;
using System.Threading;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
        Array myArr = Array.CreateInstance(typeof(Int32), 6);
        for (int i = 0; i < myArr.Length; i++)
        {
            myArr.SetValue((5 * (i + 1)) , i);

        }
        Array myArr1 = Array.CreateInstance(typeof(Int32), 3);
        for (int i = 0; i < myArr1.Length; i++)
        {
            myArr1.SetValue((2 * i ), i);

        }
            do
            {
                string[] menu = new string[11] { "1.void Reverse (Array array)", "2.void Sort()", "3.int IndexOf (Array array, object? value)", "4.int LastIndexOf (Array array, object? value)", "5.Array.TrueForAll<T>(T[], Predicate<T>)", "6.int BinarySearch (Array array, object? value)", "7.void Copy (Array array, Array array, int length)", "8.T? Find<T> (T[] array, Predicate<T> match)", "9.void Clear (Array array, int index, int length)", "10.Выход", "Введите цифру для выбора метода" };
                Console.WriteLine($"{menu[0]}\n{menu[1]}\n{menu[2]}\n{menu[3]}\n{menu[4]}\n{menu[5]}\n{menu[6]}\n{menu[7]}\n{menu[8]}\n{menu[9]}");
                int n = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (n)
                {
                    case 1://
                        Array.Reverse(myArr); //переворачивает список
                        foreach (var p in myArr)
                            Console.Write($"{p} ");
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 2://
                        Array.Sort(myArr); // сортирует коллекцию (поискать новый)
                        foreach (var p in myArr)
                            Console.Write($"{p} ");
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 3://
                        Console.WriteLine(Array.IndexOf(myArr, 30)); //Возвращает индекс первого вхождения элемента в массиве
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 4://
                        Console.WriteLine(Array.LastIndexOf(myArr, 20)); // возвращает индекс последнего вхождения элемента в массиве
                        foreach (var p in myArr)
                            Console.Write($"{p} ");
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 5:
                        Console.WriteLine(Array.TrueForAll<int>((int[])myArr, (y => y % 2 == 1))); // все ли элементы массива удовлетворяют условиям указанного предиката.
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 6://
                        Console.WriteLine(Array.BinarySearch(myArr, 10)); //Выполняет поиск элемента в массиве.                  
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 7://
                        Array.Copy(myArr1, myArr, 3);
                        foreach (var p in myArr)
                            Console.Write($"{p} ");
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 8: //
                        Console.WriteLine(Array.Find<int>((int[])myArr, (y => y % 2 == 1))); //поиск элемента, удовлетворяющего условиям указанного предиката, и возвращает первое найденное
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 9://
                        Array.Clear(myArr, 3, 2); // Очищает содержимое массива, Начальный индекс диапазона элементов, Число элементов, подлежащих очистке
                        foreach (var p in myArr)
                            Console.Write($"{p} ");
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
