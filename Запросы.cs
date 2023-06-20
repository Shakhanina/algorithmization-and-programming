using System;
using System.Linq;
class SimpQuery
{
    static void Main()
    {
        int[] mas = { 15, 0, 14, -43, -4, 1 };
        var more = from i in mas
                      where i > 0
                      select i;
        var nozero = from i in mas
                         where i != 0
                         select i;
        var even = from i in mas
                       where i % 2 == 0
                       select i;
        int sum = 0, proiz = 1, count = 0;
        foreach (int i in more) sum += i;
        foreach (int i in nozero) proiz *= i;
        foreach (int i in even) count += 1;
        Console.WriteLine("Сумма " + sum);
        Console.WriteLine("Произведение " + proiz);
        Console.WriteLine("Количество четных " + count);

        sum = 0;
        proiz = 1;
        count = 0;

        mas = (from num in mas
                where num % 2 == 0
                select num).ToArray();

        var more_1 = from i in mas
                       where i > 0
                       select i;
        var nozero_1 = from i in mas
                          where i != 0
                          select i;
        var even_1 = from i in mas
                        where i % 2 == 0
                        select i;

        foreach (int i in more_1)
        {
            sum += i;
        }
        foreach (int i in nozero_1)
        {
            proiz *= i;
        }
        foreach (int i in even_1)
        {
            count += 1;
        }
        Console.WriteLine("Сумма " + sum);
        Console.WriteLine("Произведение " + proiz);
        Console.WriteLine("Количество четных " + count);

    }
}
