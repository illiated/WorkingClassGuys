using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingClassGuys
{
    internal class Person
    {

        public string Name;
        public decimal Cash;
        public void WriteMyInfo()
        {
            Console.WriteLine(Name + " has " + Cash + " bucks.");
        }
        /// <summary>
        /// Gives some of my cash, removing it from my wallet (or printing a message to the console if I dont have enough money).
        /// </summary>
        /// <param name="amount">Amount of money to give.</param>
        /// <returns>The amount of money removed from my wallet, or 0 if there is not enough money (or if the input is invalid).</returns>
        public int GiveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine( Name + " says: " + amount + " is not a valid amount.");
                return 0;
            }
            if (amount > Cash)
            {
                Console.WriteLine("Sorry, I dont have enough money to give you " + amount + ".");
                return 0;
            }
            Cash -= amount;
            return amount;
        }
        /// <summary>
        /// Receive some money, adding it to my wallet (or printing
        /// a message to the console if the amount is invalid).
        /// </summary>
        /// <param name="amount">Amount of cash to give.</param>
        public void RecievingCash( int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine(Name + " says: this is not a valid amount that I can take.");
            }
            else
            {
                Cash += amount;
            }
            
        }   
    }
}
