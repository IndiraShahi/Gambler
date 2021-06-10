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
            int win = 0;
            int loss = 0;
            int cash = Stake;
            
            while (cash >= 50 && cash <= 150)
            {
                Random random = new Random();
                int bets = random.Next(0, 2);
                if (bets == 0)
                {
                    cash += 1;
                    win += 1;
                }
                else
                {
                    cash -= 1;
                    loss += 1;
                }
            }
            Console.WriteLine("No of wins =" + win);
            Console.WriteLine("No of Loss =" + loss);
        }   
    }
}