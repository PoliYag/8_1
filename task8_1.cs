﻿using System;

public class Program
{
    public static void PrintNumbers(int m, int n)
    {
        if (m <= n)
        {
            Console.WriteLine(m);
            PrintNumbers(m + 1, n);
        }
    }
    
    public static void Main()
    {
        int m = 1;
        int n = 10;
        
        PrintNumbers(m, n);
    }
}