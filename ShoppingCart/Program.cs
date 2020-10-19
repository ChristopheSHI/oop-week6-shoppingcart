using System;
using System.Collections.Generic;

namespace ShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ListOfItems = new List<string>();
            double priceTotal = 0;

            string decision = "";

            while (decision != "STOP")
            {
                Console.WriteLine("Give article to add to the list of items: Apple or Orange");
                string article = Console.ReadLine();
                ListOfItems.Add(article);
                Console.WriteLine("Continue or STOP");
                decision = Console.ReadLine();
                
            }
         

            for(int i=0; i < ListOfItems.Count; i++)
            {
              if (ListOfItems[i] == "Apple")
                {
                    priceTotal += 0.60;
                }   
              if (ListOfItems[i] == "Orange")
                {
                    priceTotal += 0.25;
                }
            }

            Console.WriteLine("The total price is " + priceTotal + " cents");
        }
    }
}
