using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace P2_6_3_2020
{
    public class rps
    {
        public rps(int winCounter = 0, int lossCount = 0, int drawCount = 0)
        {
            WinCounter = winCounter;
            LossCount = lossCount;
            DrawCount = drawCount;
            isWinner = 0;
        }

        public RpsMode UserChoice { get; set; }

        public int WinCounter { get; set; }

        public int LossCount { get; set; }

        public int DrawCount { get; set; }


    }

}

