﻿using System;
namespace MeuApp
{
        class Program
    {
        static void Main(string[] args)
        {
            //Null = vazio
            int? idade = 0;
            Console.WriteLine(idade);
            idade = null;
            Console.WriteLine(idade);
            idade = 25;
            Console.WriteLine(idade);


        }
    }
}