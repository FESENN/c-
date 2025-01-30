using System;
using System.Collections.Generic;

public class Sayilar
{
    public List<int> CiftSayilariBul(List<int> sayilar)
    {
        List<int> ciftSayilar = new List<int>();

        foreach (int sayi in sayilar)
        {
            if (sayi % 2 == 0)
            {
                ciftSayilar.Add(sayi);
            }
        }

        return ciftSayilar;
    }
}