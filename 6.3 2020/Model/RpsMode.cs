using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace P2_6_3_2020
{
    public class RpsMode
    {
        public enum GameChoice
        {
            [Display(Name = "Bez volby")]
            none = 0,
            [Display(Name = "Kámen")]
            rock = 1,
            [Display(Name = "Papír")]
            paper = 2,
            [Display(Name = "Nůžky")]
            scissors = 3
        }

    }
}
