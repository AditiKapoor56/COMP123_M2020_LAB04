﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_M2020_LAB04
{
    class Program
    {
        static void Main(string[] args)
        {
            Person aditi = new Person("Aditi", age: 19);

            aditi.SaysHello();

            Console.ReadLine();
        }
    }
}
