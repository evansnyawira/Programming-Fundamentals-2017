﻿using System;
class Program
{
    static void Main() //100/100
    {
        int counter = 0;
        while (true)
        {
            string x = Console.ReadLine();

            int value;
            if (int.TryParse(x, out value))
            {
                counter++;
            }
            else
            {
                break;
            }
        }
        Console.WriteLine(counter);
    }
}