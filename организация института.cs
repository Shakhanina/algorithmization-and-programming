using System;
using System.Threading;

namespace _27._02._2023
{

    public class Lecturer // преподаватели
    {
        public string fiop; // ФИО преподавателя      
        public string experience; // стаж
        public string [] leads; // дисциплины  ведет

        public Lecturer(string fiop,  string experience, string [] leads)
        {
            this.fiop = fiop;
            this.experience = experience;
            this.leads = leads;
        }
        public void Deconstruct(out string ofiop, out string oexperience, out string [] oleads)
        {
            ofiop = fiop;
            oexperience = experience;
            oleads = leads;
        }
    }

    public class Student : Lecturer  // студент
    {
        public string fios; // ФИО студента
        public string [] debts; // дисциплины долги

        public Student(string fiop, string experience, string[] leads) : base(fiop, experience, leads)
        {
        }

        public Student(string fiop, string experience, string [] leads, string fios, string [] debts) : base(fiop, experience, leads)
        {

            this.fios = fios;
            this.debts = debts;
        }
        public void Deconstruct(out string ofios, out string [] odebts )
        {
            ofios = fios;
            odebts = debts;
        }
    }
    public class Orders //приказы
    {
        public string variants; //преподаватели,персонал,студенты,для всех
        public string texst; // содержимое приказа
        public string issued; // кто выдал  
        
        public Orders( string variants, string texst, string issued)
        {
            this.variants = variants;
            this.texst = texst;
            this.issued = issued;
        }
        public void Deconstruct(out string ovariants, out string otexst, out string oissued )
        {
            ovariants = variants;
            otexst = texst;
            oissued = issued;
        }
    }
    class Program
    {
       static void Prikazprepod(Orders[] a) // приказы для преподавателей
        {
            for (int i = 0; i < a.Length; i++)
            {
                (string ovariants,  string otexst, string oissued) = a[i];
                if (ovariants == "Преподавателя" )
                {
                    Console.WriteLine($" Для {ovariants} \n Текст приказа \n {otexst} \n Выдал: \n {oissued} ");
                }
            }
       }
        static void Ordertech(Orders[] a) // приказы для персонала
        {
            for (int i = 0; i < a.Length; i++)
            {
                (string ovariants, string otexst, string oissued) = a[i];
                if ( ovariants == "персонала")
                {
                    Console.WriteLine($" Для {ovariants} \n Текст приказа \n {otexst} \n Выдал: \n {oissued} ");
                }
            }
        }
        static void Prikazstud(Orders[] a) // приказы для студентов
        {
            for (int i = 0; i < a.Length; i++)
            {
                (string ovariants, string otexst, string oissued) = a[i];
                if (ovariants == "Студентов")
                {
                    Console.WriteLine($"Для {ovariants} \n Текст приказа \n {otexst}  \n Выдал: \n {oissued} ");
                }
            }
        }
        static void Prikavs(Orders[] a) // приказы для всех
        {
            for (int i = 0; i < a.Length; i++)
            {
                (string ovariants, string otexst, string oissued) = a[i];
                if (ovariants == "Для всех")
                {
                    Console.WriteLine($" Для {ovariants} \n Текст приказа \n {otexst} \n Выдал: \n {oissued} ");
                }
            }
        }
        static void Internships(Lecturer[] b) // Стаж работы
        {
            Console.WriteLine("Bведите Фио преподавателя");
            string search = Console.ReadLine();
            for (int i = 0; i < b.Length; i++)
            {
                (string ofiop, string oexperience, string [] oleads) = b[i];
                if (ofiop == search)
                {
                    Console.WriteLine($"У преподаватель {ofiop} \n стаж работы \n {oexperience} ");
                }
            }
        }
        static void listdiscip(Lecturer[] b) // список дисциплин
        {
            Console.WriteLine("Bведите Фио преподавателя");
            string search = Console.ReadLine();
            for (int i = 0; i < b.Length; i++)
            {
                (string ofiop, string oexperience, string[] oleads) = b[i];
                if ((ofiop == search))
                {
                    Console.WriteLine($"Преподаватель {ofiop} \nВведет: ");
                    for (int j = 0; j < oleads.Length; j++)
                    {
                       Console.WriteLine($" {oleads[j]}");
                    }
                }
            }
        }
        static void Dolgistude(Student[] c) // должники студенты
        {
            Console.WriteLine("Bведите Фио преподавателя");
            string search = Console.ReadLine();
            Console.Clear();
            for (int i = 0; i < c.Length; i++)
            {
                (string ofiop, string fios, string[] odebts) = c[i];
                if (ofiop == search)
                {
                    Console.WriteLine($"Долги студентов у преподавателя {ofiop}: \n Студент {fios}:");
                    for (int j = 0; j < odebts.Length; j++)
                    {
                        Console.WriteLine($"{odebts[j]}");
                    }
                }
            }
        }
        static void Studentinput(int v, Student[] c) // ввод должников
        {
            string fiop;
            string fios;
            for (int i = 1; i < v + 1; i++)
            {
                Console.WriteLine($"Bвод {i} студенты должника");
                Console.WriteLine("Bведите Фио студентa");
                fios = Console.ReadLine();
                Console.WriteLine("У кого преподавателя");
                fiop = Console.ReadLine();
                Console.WriteLine($"Kоличество долгов студента {fios} по дисциплинам");
                int n = int.Parse(Console.ReadLine());
                string[] debts = new string[n + 1];
                
                for (int j = 1; j < n + 1; j++)
                {
                    Console.WriteLine($"{j} дисциплина");;
                    string q = Console.ReadLine();
                    debts[j] = q;
                }
                Student k = new Student(fiop,  fios, debts);
                c[i - 1] = k;
                Console.Clear();
            }
        }
        static void Teacherinput(int w, Lecturer[] b) //ввод преподавателей
        {
            string fiop;       
            string experience; 

            for (int i = 1; i < w + 1; i++)
            {
                Console.WriteLine($"Bвод {i} Преподавателя");
                Console.WriteLine("Bведите Фио преподавателя");
                fiop = Console.ReadLine();
                Console.WriteLine("введите стаж преподавателя");
                experience = Console.ReadLine();
                Console.WriteLine($"сколько дисциплин ведет  {fiop}");
                int n = int.Parse(Console.ReadLine());
                string[] leads = new string[n+1];
                for (int j = 1; j < n + 1; j++)
                {
                    Console.WriteLine($"{j} дисциплинa");
                    string q = Console.ReadLine();
                    leads[j] = q;
                }
                Lecturer k = new Lecturer(fiop, experience, leads);
                b[i - 1] = k;
                Console.Clear();
            }

        }
        static void Completion(int q, Orders[] a) //ввод приказов
        {
            string variants;
            string texst;
            string issued;
            for (int i = 1; i < q + 1; i++)
            {
                Console.WriteLine($"Bвод {i} приказа");
                Console.WriteLine("Для кого приказ (Преподавателя/Студентов/Персонала/Для всех)");
                variants = Console.ReadLine();
                Console.WriteLine("Текст приказа ");
                texst = Console.ReadLine();
                Console.WriteLine("Кто выдал ?");
                issued = Console.ReadLine();
                Orders k = new Orders(variants, texst, issued);
                a[i - 1] = k;
                Console.Clear();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько преподавателей?");
            int w = int.Parse(Console.ReadLine());
            Lecturer[] b = new Lecturer[w];

            Console.WriteLine("Сколько студентов ?");
            int v = int.Parse(Console.ReadLine());
            Student[] c = new Student[v];

            Console.WriteLine("Сколько приказов ?");
            int q = int.Parse(Console.ReadLine());

            Orders[] a = new Orders[q];
            Teacherinput(w, b);
            Studentinput(v, c);
            Completion(q, a);
            bool g = true;
            while (g == true)
            {
                Console.Clear();
                string[] menu = new string[3] { "Приказы", "Преподаватель", "Выход" };
                Console.WriteLine($"{menu[0]}\n{menu[1]}\n{menu[2]}");
                Console.SetCursorPosition(30, 0);
                bool t = true;
                bool iu = true;
                for (int i = 0; t == true;)
                {
                    ConsoleKeyInfo op = Console.ReadKey(true);
                    if (op.Key == ConsoleKey.Enter && i == 0)//Выбор по приказам 
                    {
                        Console.Clear();
                        string[] menu1 = new string[4] { "Для преподавателя", "Для тех персонала", "Для студентов ", "Для всех" };
                        Console.WriteLine($"{menu1[0]}\n{menu1[1]}\n{menu1[2]}\n{menu1[3]}");
                        Console.SetCursorPosition(30, 0);
                        t = true;
                        int j = 0;
                        while (t == true)
                        {
                            ConsoleKeyInfo po = Console.ReadKey(true);
                            if (po.Key == ConsoleKey.Enter && j == 0)// Для преподавателям
                            {
                                Console.Clear();
                                Prikazprepod(a);
                                Thread.Sleep(3000);
                                t = false;
                            }
                            else if (po.Key == ConsoleKey.Enter && j == 1)// Для тех персонала
                            {
                                Console.Clear();
                                Ordertech(a);
                                Thread.Sleep(3000);
                                t = false;
                            }
                            else if (po.Key == ConsoleKey.Enter && j == 2)// Для студентов
                            {
                                Console.Clear();
                                Prikazstud(a);
                                Thread.Sleep(3000);
                                t = false;
                            }
                            else if (po.Key == ConsoleKey.Enter && j == 3) // Для всеx
                            {
                                Console.Clear();
                                Prikavs(a);
                                Thread.Sleep(3000);
                                t = false;
                            }
                            // управление консоли 
                            else if ((po.Key == ConsoleKey.DownArrow && j == 3) || (po.Key == ConsoleKey.UpArrow && j == 1))
                            {
                                Console.SetCursorPosition(35, 0);
                                j = 0;
                            }
                            else if ((po.Key == ConsoleKey.DownArrow && j == 0) || (po.Key == ConsoleKey.UpArrow && j == 2))
                            {
                                Console.SetCursorPosition(35, 1);
                                j = 1;
                            }
                            else if ((po.Key == ConsoleKey.DownArrow && j == 1) || (po.Key == ConsoleKey.UpArrow && j == 3))
                            {
                                Console.SetCursorPosition(35, 2);
                                j = 2;
                            }
                            else if ((po.Key == ConsoleKey.DownArrow && j == 2) || (po.Key == ConsoleKey.UpArrow && j == 0))
                            {
                                Console.SetCursorPosition(35, 3);
                                j = 3;
                            }
                        }
                    }
                    else if (op.Key == ConsoleKey.Enter && i == 1)//Выбор по преподавателям 
                    {
                        Console.Clear();
                        string[] menu2 = new string[3] { "Долги студентов", "Стаж работы", "Дисциплина" };
                        Console.WriteLine($"{menu2[0]}\n{menu2[1]}\n{menu2[2]}");
                        Console.SetCursorPosition(30, 0);
                        int k = 0;
                        t = true;
                        while (t == true)
                        {
                            ConsoleKeyInfo to = Console.ReadKey(true);
                            if (to.Key == ConsoleKey.Enter && k == 0) // Долги студентов
                            {
                                Console.Clear();
                                Dolgistude(c);
                                Thread.Sleep(3000);
                                t = false;
                            }
                            if (to.Key == ConsoleKey.Enter && k == 1) //Стаж работы
                            {
                                Console.Clear();
                                Internships(b);
                                Thread.Sleep(3000);
                                t = false;
                            }
                            if (to.Key == ConsoleKey.Enter && k == 2) // Дисциплина
                            {
                                Console.Clear();
                                listdiscip(b);
                                Thread.Sleep(3000);
                                t = false;
                            }
                            // управление консоли 
                            else if ((to.Key == ConsoleKey.DownArrow && k == 2) || (to.Key == ConsoleKey.UpArrow && k == 1))
                            {
                                Console.SetCursorPosition(20, 0);
                                k = 0;
                            }
                            else if ((to.Key == ConsoleKey.DownArrow && k == 0) || (to.Key == ConsoleKey.UpArrow && k == 2))
                            {
                                Console.SetCursorPosition(20, 1);
                                k = 1;
                            }
                            else if ((to.Key == ConsoleKey.DownArrow && k == 1) || (to.Key == ConsoleKey.UpArrow && k == 0))
                            {
                                Console.SetCursorPosition(20, 2);
                                k = 2;
                            }
                        }
                    }
                    else if (op.Key == ConsoleKey.Enter && i == 2)//выход
                    {
                        Console.Clear();
                        Console.WriteLine(" ^ ^             ");
                        Console.WriteLine("( . .)  < Чмок!!> ");
                        Console.WriteLine("<( )>            ");
                        Console.WriteLine(" ! !");
                        Environment.Exit(0);
                    }
                    //управление консоли 
                    else if ((op.Key == ConsoleKey.DownArrow && i == 2) || (op.Key == ConsoleKey.UpArrow && i == 1))
                    {
                        Console.SetCursorPosition(35, 0);
                        i = 0;
                    }
                    else if ((op.Key == ConsoleKey.DownArrow && i == 0) || (op.Key == ConsoleKey.UpArrow && i == 2))
                    {
                        Console.SetCursorPosition(35, 1);
                        i = 1;
                    }
                    else if ((op.Key == ConsoleKey.DownArrow && i == 1) || (op.Key == ConsoleKey.UpArrow && i == 0))
                    {
                        Console.SetCursorPosition(35, 2);
                        i = 2;
                    }
                }
            }
        }
    }
}
