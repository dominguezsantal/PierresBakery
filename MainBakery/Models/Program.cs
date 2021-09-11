using System;
using MainBakery.Models;

namespace PierresBakery
{
    public class Program
    {
        public static void Main();
        {
            Bread bread = new Bread(0, 0);
            Pastry pastry = new Pastry(0,0);

            Console.WriteLine("Welcome to Pierre's. May I start you with some of our delicious bread?");
            string userInput = Console.ReadLine().ToLower();


        }


    }
} 
