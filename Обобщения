using System;

namespace Обобщения
{
    class Program
    {
        class NotFoundException : Exception
        {
            public NotFoundException() : base() { }
            public NotFoundException(string str) : base(str) { }
            public NotFoundException(string str, Exception inner) : base(str, inner) { }
            protected NotFoundException(
            System.Runtime.Serialization.SerializationInfo si,
            System.Runtime.Serialization.StreamingContext sc) :
            base(si, sc)
            { }
        }
        class Obob<T>
        {
            T[] mas;
            int end;
            public Obob()
            {
                mas = new T[6];
                end = 0;
            }
            public bool Add(T newEntry)
            {
                if (end == 10) return false;
                mas[end] = newEntry;
                end++;
                return true;
            }
            public void Ydalenie(T item)
            {
                int index = 0;
                for (int i = 0; i < mas.Length; i++)
                {
                    if (mas[i].Equals(item))
                    {
                        index = i;
                        break;
                    }
                }
                if (index > 0)
                {
                    T[] newmas = new T[mas.Length - 1];
                    for (int i = 0, j = 0; i < mas.Length; i++)
                    {
                        if (i == index) continue;
                        newmas[j] = mas[i];
                        j++;
                    }
                    mas = newmas;
                }
            }
            public T Poisk(int index)
            {
                if (index < mas.Length)
                {
                    return mas[index];
                }
                else
                    throw new NotFoundException();
            }
            public int Count()
            {
                return mas.Length;
            }
        }
        static void Main(string[] args)
        {
            Obob<int> massiv = new Obob<int>();
            massiv.Add(18);
            massiv.Add(56);
            massiv.Add(4);
            massiv.Add(98);
            Console.WriteLine("Массив после добавления данных");
            for (int i = 0; i < massiv.Count(); i++)
            {
                Console.WriteLine(massiv.Poisk(i));
            }
            Console.WriteLine($"Элемента из массива по индексу" + massiv.Poisk(3));
            massiv.Ydalenie(56);
            Console.WriteLine("Массив после удаления данных");
            for (int i = 0; i < massiv.Count(); i++)
            {
                Console.WriteLine(massiv.Poisk(i));
            }
        }
    }
}
