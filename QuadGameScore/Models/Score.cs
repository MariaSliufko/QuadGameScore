using System;
using System.ComponentModel.DataAnnotations;

namespace QuadGameScore.Models
{
    public class Score
    {
        [Key]
        public int Id { get; set; }

        public int PlayerId { get; set; }
        public int GameId { get; set; }
        public int Points { get; set; }

        public Score(int playerId, int gameId, int points)
        {
            PlayerId = playerId;
            GameId = gameId;
            Points = points;
        }
    }

}

