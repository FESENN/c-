using System;
using System.Collections.Generic;

public class Class
{
    public void TumClasslariCagir()
    {
        Sayilar sayilar = new Sayilar();
        Syntax syntax = new Syntax();
        List<int> sayiListesi = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.WriteLine("Tüm sayılar:");

        foreach (int sayi in sayiListesi)
        {
            Console.Write(sayi + " ");
        }
        Console.WriteLine();

        List<int> ciftSayilar = sayilar.CiftSayilariBul(sayiListesi);

        Console.WriteLine("\nÇift sayılar:");
        foreach (int ciftSayi in ciftSayilar)
        {
            Console.Write(ciftSayi + " ");
        }
        Console.WriteLine();
        syntax.ConsoleYazdir();
        int toplam = syntax.Topla(10, 20);
        Console.WriteLine("Toplam Sayı:  " + toplam);
    }
}