using System;

namespace Gambler
{
    class GamblerGame
    {
        public const int Stake = 100;
        public const int Bet = 1;
        public const int IS_WIN = 1;
        public void GameBet()
        {
            Random random = new Random();
            int bets = random.Next(0, 2);
            if (bets == IS_WIN)
                Console.WriteLine("Win");
            else
                Console.WriteLine("loss")
        }   
    }
}