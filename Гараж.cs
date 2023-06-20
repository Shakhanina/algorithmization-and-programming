using System;
using System.Collections.Generic;
using System.Linq;

class Auto
{
    public string marka;
    public string color;
    public int number;

    public Auto(string marka, string color, int number)
    {
        this.marka = marka;
        this.number = number;
        this.color = color;
    }
    public void Deconstruct(out string avtomarka, out int avtonomer, out string avtocolor)
    {
        avtomarka = marka;
        avtonomer = number;
        avtocolor = color;
    }
}
class Owners
{
    public string fio;
    public int[] idi;

    public Owners(string fio, int[] idi)
    {
        this.fio = fio;
        this.idi = idi;
    }
    public void Deconstruct(out string afio, out int[] anomer)
    {
        afio = fio;
        anomer = idi;

    }
}

class Programm
{
    static void Main()
    {
        List<Auto> garag = new List<Auto>();
        garag.Add(new Auto("машинка 1", "yellow", 666));
        garag.Add(new Auto("машинка 2", "pink", 555));
        garag.Add(new Auto("машинка 3", "blue", 22));

        var marka = from avto in garag
                          where avto.marka == "машинка 1"
                          select avto;
        Console.WriteLine("автомобили марки машинка 1");
        foreach (var avto in marka)
        {
            Console.WriteLine($"{avto.marka},{avto.color}, {avto.number}");
        }

        List<Owners> avtoclub = new List<Owners>();
        avtoclub.Add(new Owners("ФИО 1", new int[] { 22, 666, 555 }));
        avtoclub.Add(new Owners("ФИО 2", new int[] { 22, 555 }));
        avtoclub.Add(new Owners("ФИО 3", new int[] { 22 }));
        foreach (var avto in garag)
        {
            int number = avto.number;
            var nomer = from vlad in avtoclub
                                     where vlad.idi.Contains(number)
                                     select vlad;
            Console.WriteLine($"владельцы машины с номером {nomer}:");
            foreach (var vlad in nomer)
            {
                Console.WriteLine($"{vlad.fio}");
            }
        }

    }
}
