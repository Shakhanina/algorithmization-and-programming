using System; 
using System.Collections;
using System.Threading;

namespace Arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myAL = new ArrayList();
            myAL.Add("1");
            myAL.Add("45");
            myAL.Add("-23");
            myAL.Add("0");
            myAL.Add("93302");
            myAL.Add("-56");
            myAL.Add("9");
            ArrayList myAL2 = new ArrayList() { "q", "w", "e" ,"a", "u"};
            do
            {
                string[] menu = new string[11] { "1. Arraylist.Remove(object value)", "2. Arraylist.SetRange(int index, ICollection col)", "3. Arraylist.IndexOf(object value)", "4. Arraylist.AddRange(ICollection col)", "5. Arraylist.Reverse()", "6. Arraylist.Insert(int index, object value)","7. Arraylist.Sort()", "8. Arraylist.Contains(object value):", "9. Arraylist.Clear()", "10.Выход", "Введите цифру для выбора метода" };
                Console.WriteLine($"{menu[0]}\n{menu[1]}\n{menu[2]}\n{menu[3]}\n{menu[4]}\n{menu[5]}\n{menu[6]}\n{menu[7]}\n{menu[8]}\n{menu[9]}");
                int n = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (n)
                {
                    case 1:
                        myAL.Remove("-23"); 
                        foreach (var p in myAL)
                            Console.Write($"{p} ");
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 2:
                        myAL.SetRange(1, myAL2);
                        foreach (var p in myAL)
                            Console.Write($"{p} ");
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine(myAL.IndexOf("-56"));
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 4:
                        myAL.AddRange(myAL2);
                        foreach (var p in myAL)
                            Console.Write($"{p} ");
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 5:
                        myAL.Reverse();
                        foreach (var p in myAL)
                            Console.Write($"{p} ");
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 6:
                        myAL.Insert(3,"1.5");
                        foreach (var p in myAL)
                            Console.Write($"{p} ");
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 7:
                        myAL2.Sort();
                        foreach (var p in myAL2)
                            Console.Write($"{p} ");
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 8:
                        Console.WriteLine(myAL2.Contains("5"));
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 9:
                        myAL.Clear();
                        foreach (var p in myAL)
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
