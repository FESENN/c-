using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Class tumClasslar = new Class();
        // W3Scholls w3Scholls = new W3Scholls();
        // tumClasslar.TumClasslariCagir();
        // w3Scholls.TumDenemeler();
        int sayac = SesliHarfiHarfler();
        Console.WriteLine("Sayaç:  "+ sayac);

    }

    static int SesliHarfiHarfler()
    {
        int x = 0;
        Console.WriteLine("bir cumle yada kelme giriniz : ");
        string cumle = Console.ReadLine();
        string sesliHarfler = "aeıiouAEIİOU";
        foreach (char y in cumle)
        {
            if (sesliHarfler.Contains(y))
            {
                x++;
            }
        }
        return x;
    }
}