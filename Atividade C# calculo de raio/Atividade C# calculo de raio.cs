﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula1
{
    class Program
    {
        static void Main(string[] args)
        {
           double area, raio, total;

            Console.Write("Digite raio: ");
            raio = double.Parse(Console.ReadLine());
            area = raio * raio * 3.14;
            Console.Write(+ area);
            Console.ReadKey();
        }
    }
}
