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
            GamblerGame game = new GamblerGame();
            game.GameBet();
        }
    }
}
