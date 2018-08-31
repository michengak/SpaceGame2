using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.models;

namespace Engine.ViewModels
{
    class GameSession
    {
       public Player CurrentPlayer { get; set; }
       public Location CurrentLocation { get; set; }


        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Noah";
            CurrentPlayer.Level = "Beginner";
            CurrentPlayer.Fortune = "1000";

            CurrentLocation = new Location();
            CurrentLocation.NameOfPlanet = "Earth";
            CurrentLocation.Xcoordinate = 0;
            CurrentLocation.Xcoordinate = 0;
            CurrentLocation.Description = "welcome to the Earth Store, this is your home!";


        }
    
    }
}
