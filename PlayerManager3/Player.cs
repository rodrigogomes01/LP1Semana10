using System;
using System.Collections.Generic;

namespace PlayerManager3
{
    public class Player
    {
        public string Name { get; }
        public int Score { get; }

        public Player(string name, int score)
        {
            Name = name;
            Score = score;
        }
        public int CompareTo(Player other)
        {
            if (other == null)
                return 1;

            return Score.CompareTo(other.Score);
        }
    }
}
