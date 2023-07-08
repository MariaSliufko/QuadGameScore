using System;
using System.ComponentModel.DataAnnotations;

namespace QuadGameScore.Models
{
	public class Game
	{
      
            [Key]
            public int GameId { get; set; } // Primärnyckel (ID)

            [Required(ErrorMessage = "Namnet är obligatoriskt.")]
            [MinLength(3, ErrorMessage = "Namnet måste vara minst 3 tecken långt.")]
            public string Name { get; set; }

            public Game(string name)
            {
                Name = name;
            }
       

    }
}

