﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T09.Fruit_or_Vegetable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string food = Console.ReadLine();

            switch(food)
            {
                case "banana":
                case "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes":
                    Console.WriteLine("fruit");
                    break;
                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot":
                    Console.WriteLine("vegetable");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
