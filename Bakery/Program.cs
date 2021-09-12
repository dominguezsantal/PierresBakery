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

            Console.WriteLine("Welcome to Pierre's.We have a delicious selection of breads and pastries.What would you like to order?For breads(press B),pastry(press P) or combination(press C) or none(Type no)?");
            string userInput = Console.ReadLine().ToLower();
            string answer = Console.ReadLine();
            if (answer == "B" || answer == "b")
            {
                Console.WriteLine("BREAD MENU: A loaf: $5. Special Offer: Buy 2, you get 1 free! Enter how many loaves you want?");
                string userInputBread = Console.ReadLine();
                bread.Quant += int.Parse(userInputBread);
                bread.Cost = Bread.BreadCost(bread.Quant);
                Console.WriteLine("Your total cost is $" + bread.Cost);
            
            }else if(answer == "P" || answer == "p")
            {
                Console.WriteLine("PASTRY MENU: One pastry: $2. Special Offer: Buy 3, get all 3 pastries for 5$!Enter how many loaves you want? ");
                    string userInputPastry = Console.ReadLine();
                    pastry.Quant += int.Parse(userInputPastry);
                    pastry.Cost = Pastry.PastryCost(pastry.Quant);
                    Console.WriteLine("Your total cost is $" + pastry.Cost);

            }else if(answer == "C" || answer == "c")
            {

            }else if( answer == "No" || answer == "no" || answer == "NO")
            {
            Console.WriteLine("Thank you for checking us out!Have a good day"); 
            }else
            {
                Console.WriteLine("To go back to the main menu(Press space)");
            }
            
            
            
        
        }  
    }

}

