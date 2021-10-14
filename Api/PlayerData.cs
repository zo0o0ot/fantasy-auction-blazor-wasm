using BlazorApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper;

namespace Api
{
    public interface IPlayerData
    {
        Task<Player> AddPlayer(Player Player);
        Task<bool> DeletePlayer(int ID);
        Task<IEnumerable<Player>> GetPlayers();
        Task<Player> UpdatePlayer(Player Player);
    }

    public class PlayerData : IPlayerData
    {
        private readonly List<Player> Players = new List<Player>
        {

            new Player
            {
                ID = 1,
                Name = "Alabama",
                Position = "SEC",
                PlayerSelected = false,
                Stats = new List<(string description, int stat)>()
                {
                    ("ProjectedPoints", 208),
                    ("NumberOfProspects", 21)
                }
            }
            // Use CsvReader to read the CSV file in the DefaultPlayers directory and create a list of players


            
        };

        private int GetRandomInt()
        {
            var random = new Random();
            return random.Next(100, 1000);
        }

        public Task<Player> AddPlayer(Player Player)
        {
            Player.ID = GetRandomInt();
            Players.Add(Player);
            return Task.FromResult(Player);
        }

        public Task<Player> UpdatePlayer(Player Player)
        {
            var index = Players.FindIndex(p => p.ID == Player.ID);
            Players[index] = Player;
            return Task.FromResult(Player);
        }

        public Task<bool> DeletePlayer(int ID)
        {
            var index = Players.FindIndex(p => p.ID == ID);
            Players.RemoveAt(index);
            return Task.FromResult(true);
        }

        public Task<IEnumerable<Player>> GetPlayers()
        {
            return Task.FromResult(Players.AsEnumerable());
        }
    }
}