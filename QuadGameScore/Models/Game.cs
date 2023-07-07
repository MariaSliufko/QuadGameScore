using System;
using System.ComponentModel.DataAnnotations;

namespace QuadGameScore.Models
{
	public class Game
	{
      
            [Key]
            public int GameId { get; set; } // Primärnyckel (ID)

            public string Name { get; set; }

            public Game(string name)
            {
                Name = name;
            }
       

    }
}

