using System;
using System.Collections.Generic;
using System.Text;

namespace Gambler
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to gambling problem ");
            int stake = 100;
            int bet = 1;
            int betWin = 0;
            Random random = new Random();
            int bets = random.Next(0, 2);

            if (bets == 0)
            {
                betWin = 100 + 1;
            }
            else
            {
                betWin = 100 - 1;
            }
        }
    }
}
