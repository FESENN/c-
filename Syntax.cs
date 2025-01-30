using System;
using System.Collections.Generic;

public class Syntax
{
    private void ConsoleYazdir2()
    {
        Console.WriteLine("Önder Şahin Esen");
    }
    public void ConsoleYazdir()
    {
        Console.WriteLine("Farruk Esen");
        ConsoleYazdir2();
    }
    public int Topla(int a, int b)
    {
        return a + b;
    }

}