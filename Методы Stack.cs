using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> st = new Stack<string>();
            st.Push("один");
            st.Push("два");
            st.Push("три");
            st.Push("четыре");
            st.Push("пять");
            do
            {
                string[] menu = new string[11] { "1.Stac.Contains (object obj)", "2.Stack.Peek()", "3.Stack.Pop()",
                    "4.Stack.ToArray", "5.Stack.CopyTo()", "6.Stack.GetHashCode",
                    "7.Stack.TryPeek(out T result)", "8.Stack.ToString()", "9.Stack.Clear",
                    "10.Выход", "Введите цифру для выбора метода" };
                Console.WriteLine($"{menu[0]}\n{menu[1]}\n{menu[2]}\n{menu[3]}\n{menu[4]}\n{menu[5]}\n{menu[6]}\n{menu[7]}\n{menu[8]}\n{menu[9]}");
                int n = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (n)
                {
                    case 1:
                        Console.WriteLine(st.Contains("three"));
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine(st.Peek());
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 3:
                        string str = st.Pop();
                        Console.Write(str + " ");
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 4:
                        Stack st2 = new Stack(st.ToArray());
                        foreach (string l in st2)
                        {
                            Console.WriteLine(l);
                        }
                        Console.WriteLine();
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 5:
                        string[] arr = new string[st.Count];
                        st.CopyTo(arr, 0);
                        foreach (string s in arr)
                        {
                            Console.WriteLine(s);
                        }
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 6:
                        Console.WriteLine(st.GetHashCode());
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 7:
                        var success1 = st.TryPop(out var p); 
                        if (success1) Console.WriteLine(p);
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 8:
                        Console.WriteLine(st.ToString().GetType());
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 9:
                        st.Clear();
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
