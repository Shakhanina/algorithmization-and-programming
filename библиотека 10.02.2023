using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace библиотека_10._02._2023_
{
    public class Book
    {
        public string fio;  //ФИО
        public string title; //название
        public string identification; // идентификационный номер
        public int year; // год издания 
        public string publishing; // наименования издательства
        public string genre; // жанр  
        public string[] extradition;// дата выдачи
        public string[] change;//дата сдачи

        public Book(string fio, string title, string identification, int year, string publishing, string genre, string[] extradition, string[] change)
        {
            this.fio = fio;
            this.title = title;
            this.identification = identification;
            this.year = year;
            this.publishing = publishing;
            this.genre = genre;
            this.extradition = extradition;
            this.change = change;
        }
        public void Deconstruct(out string ofio, out string otitle, out string oidentification, out int oyear, out string opublishing, out string ogenre, out string[] oextradition, out string[] ochange)
        {
            ofio = fio;
            otitle = title;
            oidentification = identification;
            oyear = year;
            opublishing = publishing;
            ogenre = genre;
            oextradition = extradition;
            ochange = change;
        }
    }
    class Program
    {
        //поиск по издательству
        static void Izdatepoisk(Book[] a)
        {
            Console.WriteLine("Введите издательство");
            string search = Console.ReadLine();
            for (int i = 0; i < a.Length; i++)
            {
                (string ofio, string otitle, string oidentification, int oyear, string opublishing, string ogenre, string[] oextradition, string[] ochange) = a[i];
                if (opublishing == search)
                {
                    Console.WriteLine($" ФИО {ofio} \n Название книги  {otitle}  \n Идентификационный номер {oidentification} \n Год издания {oyear} \n Наименования издательства {opublishing} \n Жанр {ogenre}");
                }
            }
        }
        // поиск по автору 
        static void Autopoiesis(Book[] a)
        {
            Console.WriteLine("Bведите автора");
            string search = Console.ReadLine();
            for (int i = 0; i < a.Length; i++)
            {
                (string ofio, string otitle, string oidentification, int oyear, string opublishing, string ogenre, string[] oextradition, string[] ochange) = a[i];
                if (ofio == search)
                {
                    Console.WriteLine($" ФИО {ofio} \n Название книги  {otitle}  \n Идентификационный номер {oidentification} \n Год издания {oyear} \n Наименования издательства {opublishing} \n Жанр {ogenre}");
                }
            }
        }
        //поиск книг на руках
        static void Knignaruk(Book[] a)
        {
            string g = "01.01.0001";
            for (int i = 0; i < a.Length; i++)
            {
                (string ofio, string otitle, string oidentification, int oyear, string opublishing, string ogenre, string[] oextradition, string[] ochange) = a[i];
                if (ochange[^1] == g)
                {
                    Console.WriteLine($" ФИО {ofio} \n Название книги  {otitle}  \n Идентификационный номер {oidentification} \n Год издания {oyear} \n Наименования издательства {opublishing} \n Жанр {ogenre} ");
                }
            }
        }
        //поиск по жанру 
        static void Zhanrpois(Book[] a)
        {
            Console.WriteLine("Введите жанр");
            string search = Console.ReadLine();
            for (int i = 0; i < a.Length; i++)
            {
                (string ofio, string otitle, string oidentification, int oyear, string opublishing, string ogenre, string[] oextradition, string[] ochange) = a[i];
                if (ogenre == search)
                {
                    Console.WriteLine($" ФИО {ofio} \n Название книги  {otitle}  \n Идентификационный номер {oidentification} \n Год издания {oyear} \n Наименования издательства {opublishing} \n Жанр {ogenre} ");
                }
            }
        }
        // книги на руках в интервале
        static void Intervolruks(Book[] a, string x, string y)
        {
            DateTime xm = DateTime.Parse(x);
            DateTime ym = DateTime.Parse(y);

            for (int i = 1; i < a.Length; i++)
            {
                (string ofio, string otitle, string oidentification, int oyear, string opublishing, string ogenre, string[] oextradition, string[] ochange) = a[i];
                DateTime[] oextraditiony = Array.ConvertAll(oextradition, o => { DateTime d = Convert.ToDateTime(o); return (DateTime)d; }).ToArray();//выдача
                DateTime[] ochangey = Array.ConvertAll(ochange, o => { DateTime d = Convert.ToDateTime(o); return (DateTime)d; }).ToArray();//сдача
                for (int j = 0; j < oextraditiony.Length; j++)
                {
                    if (xm <= oextraditiony[j] && ym >= ochangey[j])
                    {
                        Console.WriteLine($" ФИО {ofio} \n Название книги  {otitle}  \n Идентификационный номер {oidentification} \n Год издания {oyear} \n Наименования издательства {opublishing} \n Жанр {ogenre} ");
                    }
                }
            }
        }
        // заполнение книг 
        static void Completion(int n, Book[] a)
        {
            string fio;
            string title;
            string identification;
            int year;
            string publishing;
            string genre;

            for (int i = 1; i < n + 1; i++)
            {
                Console.WriteLine($"Bвод {i} книги");
                Console.WriteLine("Введите ФИО автора");
                fio = Console.ReadLine();
                Console.WriteLine("Введите название книги");
                title = Console.ReadLine();
                Console.WriteLine("Введите индификационный номер");
                identification = Console.ReadLine();
                Console.WriteLine("Введите год издания");
                year = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите  название издательства");
                publishing = Console.ReadLine();
                Console.WriteLine("Введите жанр");
                genre = Console.ReadLine();
                Console.WriteLine("Cколько раз брали книгу ?");
                Console.WriteLine("время ММ / дд / гггг”");
                int t = int.Parse(Console.ReadLine());
                string[] extradition = new string[t];
                string[] change = new string[t];
                // набор книг
                for (int j = 0; j < t; j++)
                {
                    Console.WriteLine("Bведите дату выдачи книги  (формат **.**.****)");
                    string q = Console.ReadLine();
                    extradition[j] = q;
                    Console.WriteLine("Bведите дату сдачи книги  (формат **.**.****), если книга не сдана, то введите 01.01.0001");
                    string d = Console.ReadLine();
                    change[j] = d;
                }
                Book k = new Book(fio, title, identification, year, publishing, genre, extradition, change);
                a[i - 1] = k;
                Console.Clear();
            }
        }
        static void Main()
        {
            Console.WriteLine("Количество книг ?");
            int n = int.Parse(Console.ReadLine());
            Book[] a = new Book[n];
            Console.Clear();
            Completion(n, a);
            bool g = true;
            while (g == true)
            {
                Console.Clear();
                string[] menu = new string[6] { "Выбор по издательству", "Выбор по автору", "Книги на руках", "Выбор по жанру", "Книги на руках в интервале", "Выход" };
                Console.WriteLine($"{menu[0]}\n{menu[1]}\n{menu[2]}\n{menu[3]}\n{menu[4]}\n{menu[5]}");
                Console.SetCursorPosition(30, 0);
                bool t = true;
                for (int i = 0; t == true;)
                {
                    ConsoleKeyInfo op = Console.ReadKey(true);

                    if (op.Key == ConsoleKey.Enter && i == 0)//Выбор по издательству
                    {
                        Console.Clear();
                        Izdatepoisk(a);
                        Thread.Sleep(5000);
                        t = false;
                    }
                    else if (op.Key == ConsoleKey.Enter && i == 1)//Выбор по автору
                    {
                        Console.Clear();
                        Autopoiesis(a);
                        Thread.Sleep(5000);
                        t = false;
                    }
                    else if (op.Key == ConsoleKey.Enter && i == 2)//Книги на руках
                    {
                        Console.Clear();
                        Knignaruk(a);
                        Thread.Sleep(5000);
                        t = false;
                    }
                    else if (op.Key == ConsoleKey.Enter && i == 3)//По жанру
                    {
                        Console.Clear();
                        Zhanrpois(a);
                        Thread.Sleep(5000);
                        t = false;
                    }
                    else if (op.Key == ConsoleKey.Enter && i == 4)//Книги на руках в интервале
                    {
                        Console.Clear();
                        Console.WriteLine("Bведите интервал выдачи (формат **.**.****)");
                        string x = Console.ReadLine();
                        string y = Console.ReadLine();
                        Intervolruks(a, x, y);
                        Thread.Sleep(5000);
                        t = false;
                    }
                    else if (op.Key == ConsoleKey.Enter && i == 5)//Выход
                    {
                        Console.Clear();
                        Console.WriteLine(" ^ ^             ");
                        Console.WriteLine("( . .)  < Чмок!!> ");
                        Console.WriteLine("<( )>            ");
                        Console.WriteLine(" ! !");
                        Environment.Exit(0);
                    }
                    // управление консоли 
                    else if ((op.Key == ConsoleKey.DownArrow && i == 5) || (op.Key == ConsoleKey.UpArrow && i == 1))
                    {
                        Console.SetCursorPosition(35, 0);
                        i = 0;
                    }
                    else if ((op.Key == ConsoleKey.DownArrow && i == 0) || (op.Key == ConsoleKey.UpArrow && i == 2))
                    {
                        Console.SetCursorPosition(35, 1);
                        i = 1;
                    }
                    else if ((op.Key == ConsoleKey.DownArrow && i == 1) || (op.Key == ConsoleKey.UpArrow && i == 3))
                    {
                        Console.SetCursorPosition(35, 2);
                        i = 2;
                    }
                    else if ((op.Key == ConsoleKey.DownArrow && i == 2) || (op.Key == ConsoleKey.UpArrow && i == 4))
                    {
                        Console.SetCursorPosition(35, 3);
                        i = 3;
                    }
                    else if ((op.Key == ConsoleKey.DownArrow && i == 3) || (op.Key == ConsoleKey.UpArrow && i == 5))
                    {
                        Console.SetCursorPosition(35, 4);
                        i = 4;
                    }
                    else if ((op.Key == ConsoleKey.DownArrow && i == 4) || (op.Key == ConsoleKey.UpArrow && i == 0))
                    {
                        Console.SetCursorPosition(35, 5);
                        i = 5;
                    }
                }
            }
        }
    }
}

