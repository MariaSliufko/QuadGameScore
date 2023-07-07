using System;
using System.ComponentModel.DataAnnotations;

namespace QuadGameScore.Models
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }
        public int Age { get; set; }

        public Player(int playerId, string name, int age)
        {
            PlayerId = playerId;
            Name = name;
            Points = 0;
            Age = age;
        }
    }
}

