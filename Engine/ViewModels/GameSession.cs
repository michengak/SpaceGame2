using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.models;
using Engine.Models;
using Engine.Factories;

namespace Engine.ViewModels
{
    class GameSession
    {
        public World CurrentWorld { get; set; }
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }
       

        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Noah";
            CurrentPlayer.Level = "Beginner";
            CurrentPlayer.Fortune = "10000";

            

            WorldFactory factory = new WorldFactory();
            CurrentWorld = factory.CreatedWord();

            CurrentLocation = new Location();
            

            CurrentLocation = CurrentWorld.locationAt(0, 0);

        }
    
    }
}
