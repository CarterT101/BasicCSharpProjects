﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneGame : Game //INHERITANCE 
    {
        public override void Play()
        {
            throw new NotImplementedException();
        }
        public override void ListPlayers() //virtual method testing
        {
            Console.WriteLine("21 Players: ");
            base.ListPlayers();
        }
    }
}
