﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HmongTrail.Models
{
    public class Game
    {
        public Enums.CharType CharacterType { get; set; }
        public IList<Character> Party { get; set; }

        private static IList<String> StockNames = new List<String> { "Ku", "Pa", "Mee", "Xai" };

        public Game()
        {
            Party = new List<Character>();
            for (int i = 0; i < 4; i++)
            {
                Party.Add(new Character { Name = StockNames[i] });
            }
        }
    }
}
