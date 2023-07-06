using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using QuadGameScore.Models;
using QuadGameScore.Data;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore.InMemory;


namespace QuadGameScore.Data
{
    public class QuadGameScoreRepository
    {
        private readonly QuadGameScoreDbContext _dbContext;

        public QuadGameScoreRepository(QuadGameScoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Metoder för spelaroperationer
        public List<Player> GetPlayers()
        {
            return _dbContext.Players.ToList();
        }

        public void AddPlayer(Player player)
        {
            _dbContext.Players.Add(player);
            _dbContext.SaveChanges();
        }

        public void UpdatePlayer(Player player)
        {
            _dbContext.Players.Update(player);
            _dbContext.SaveChanges();
        }

        public void RemovePlayer(Player player)
        {
            _dbContext.Players.Remove(player);
            _dbContext.SaveChanges();
        }

        // Metoder för händelseoperationer
        public List<Game> GetGames()
        {
            return _dbContext.Games.ToList();
        }

        public void AddGame(Game newGame)
        {
            _dbContext.Games.Add(newGame);
            _dbContext.SaveChanges();
        }

        //public void UpdateEvent(Event updatedEvent)
        //{

        //        var existingEvent = _dbContext.Events.FirstOrDefault(e => e.Name == updatedEvent.Name);

        //        if (existingEvent != null)
        //        {
        //            existingEvent.Name = updatedEvent.Name;
        //            _dbContext.SaveChanges();
        //        }

        //}

        public void RemoveEvent(Game @event)
        {
            _dbContext.Games.Remove(@event);
            _dbContext.SaveChanges();
        }

        // Metoder för poängoperationer
        public void AddScore(Score score)
        {
            _dbContext.Scores.Add(score);
            _dbContext.SaveChanges();
        }

        public int GetPlayerPoints(int playerId)
        {
            return _dbContext.Scores.Where(s => s.PlayerId == playerId).Sum(s => s.Points);
        }

        public List<Player> GetWinners()
        {
            var players = GetPlayers();
            var winners = players.OrderByDescending(p => p.Points).Take(3).ToList();

            // Uppdatera poängen för varje vinnare
            foreach (var winner in winners)
            {
                winner.Points = GetPlayerPoints(winner.PlayerId);
            }

            return winners;
        }


        public void AssignPointsToPlayer(int playerId, int gameId, int points)
        {
            var score = _dbContext.Scores.FirstOrDefault(s => s.PlayerId == playerId && s.GameId == gameId);

            if (score != null)
            {
                score.Points += points; // Öka poängen istället för att tilldela direkt
            }
            else
            {
                score = new Score(playerId, gameId, points);
                _dbContext.Scores.Add(score);
            }

            _dbContext.SaveChanges();
        }


    }
}



