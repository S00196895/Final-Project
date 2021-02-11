﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public abstract class Games
    {
        //properties
        public string Name { get; set; }
        public double Score { get; set; }
        public int RealeaseYear{ get; set; }
         
        //default constructor 
        public Games()
        {

        }
        public Games(string name, double score, int realeaseYear)
        {
            name = Name;
            score = Score;
            realeaseYear = RealeaseYear; 
        }

    }
    public class Platformer : Games
    {
        public override string ToString()
        {
            return base.ToString() + " - Platformer";
        }
    }
    public class RolePlayingGame: Games
    {
        public override string ToString()
        {
            return base.ToString() + " - RolePlayingGame";
        }
    }
    public class Horror: Games
    {
        public override string ToString()
        {
            return base.ToString() + " - Horror";
        }
    }
    public class Puzzle: Games
    {
        public override string ToString()
        {
            return base.ToString() + " - Puzzle";
        }
    }
}
