﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02.Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            string input = Console.ReadLine();

            while(input != password) 
            { 
                input = Console.ReadLine(); 
            }
           
            Console.WriteLine($"Welcome {username}!");
        }
    }
}
