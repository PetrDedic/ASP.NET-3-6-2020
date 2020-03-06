using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using P2_6_3_2020.Model;

namespace P2_6_3_2020.Service
{
    public class RpsLogic
    {
        private readonly Random random;

        public RpsLogic(Random random)
        {
            this.random = random;
        }

        public rps userData { get; set; }

        public void GameRound(RpsMode userChoice)
        {
            userData.UserChoice = userChoice;
            bool? isWinner = null;
            RpsMode aiChoice = (RpsMode)random.Next(1, 4);

            if (aiChoice == RpsMode.Rock && userData.UserChoice == RpsMode.Paper ||

                aiChoice == RpsMode.Paper && userData.UserChoice == RpsMode.Scissors ||

                aiChoice == RpsMode.Scissors && userData.UserChoice == RpsMode.Rock)
                userData.WinCounter++;
            else if (aiChoice == userChoice)
            {
                userData.DrawCount++;
            }
            else userData.LossCount++;
        }
    }
}
