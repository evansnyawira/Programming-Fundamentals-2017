﻿using System;
class Program
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int secound = int.Parse(Console.ReadLine());
        int third = int.Parse(Console.ReadLine());
        int four = int.Parse(Console.ReadLine());

        Console.WriteLine("{0} {1} {2} {3}",
            first.ToString().PadLeft(4, '0'),
            secound.ToString().PadLeft(4, '0'),
            third.ToString().PadLeft(4, '0'),
            four.ToString().PadLeft(4, '0'));



    }
}