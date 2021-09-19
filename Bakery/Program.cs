using System;
using System.Collections.Generic;
using Bakery.Models;

namespace PierresBakery
{
    public class Program 
    {
        public static List<string> userInput = new List<string>();
        public static void Main()
        {
            Bread bread = new Bread(0, 0);
            Pastry pastry = new Pastry(0,0);
            Console.WriteLine("Welcome to Pierre's|Website in French and Spanish Soon|");
            Console.WriteLine("Can I get you started with Bread (yes/no)?");
            string answerFirst = Console.ReadLine().ToLower();
            {
                if (answerFirst == "yes")
                {
                    Console.WriteLine("Here are your options: 1 loaf: $5, but if you buy 2, you get 1 free! Please enter the amount of loaves you want?");
                    string userInputBread = Console.ReadLine();
                    bread.Quant += int.Parse(userInputBread);
                    bread.Cost = Bread.BreadCost(bread.Quant);
                    Console.WriteLine("Great! Your total for this delicious bread is $" + bread.Cost);
                }
                else if (answerFirst == "no");
            }
            Console.WriteLine("Wonderful! Would you like any Pastries today? (yes/no)");
            string secondAnswer = Console.ReadLine().ToLower();
            {
                if (secondAnswer == "yes")
                {
                    Console.WriteLine("Here are the details for pastries: 1 pastry: $2, but if one buys 3, you can get them for a total of 5$! This is to your liking, non? Go on! Enter a value!");
                    string userInputPastry = Console.ReadLine();
                    pastry.Quant += int.Parse(userInputPastry);
                    pastry.Cost = Pastry.PastryCost(pastry.Quant);
                    Console.WriteLine("Excellent! The total cost of these pastries is $" + pastry.Cost);
                }
                else if (secondAnswer == "no");
            }
            Console.WriteLine("Anything else for you? If so type yes! If not, type 'done'!");
            string userAnswerFinal = Console.ReadLine().ToLower();
            if (userAnswerFinal == "yes")
            {
                Main();
            }
            else if (userAnswerFinal == "done")
            {
                int total = bread.Cost + pastry.Cost;
                Console.WriteLine(" Your total is: $" + total);
                Console.WriteLine("Thank you for your business!");
            }
            else
            {
                Console.WriteLine("Please enter a valid selection!");
            }
        }

    }
}


            