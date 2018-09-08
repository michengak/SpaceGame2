using Engine.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class World
    {
        private List<Location> location = new List<Location>();

        internal void AddLocation(double xCoordinate, double yCoordinate, string name, string description)
        {
            Location loc = new Location();
            loc.Xcoordinate = xCoordinate;
            loc.Ycoordinate = yCoordinate;
            loc.NameOfPlanet = name;
            loc.Description = description;

            this.location.Add(loc);

        }
        public Location locationAt(double Xcoordinate, double ycoordinate)
        {
            foreach (Location loc in location)

                if (loc.Xcoordinate == Xcoordinate && loc.Ycoordinate == ycoordinate)
                {
                    return loc;
                }

            return null;

        }
    }
  
    
    public class Random_generated_class
    { 

       Random rnd = new Random();

       string str = "";
     
       string[] randomPlanets = { "earth", "alphaCentauruim", "mygreatPlanet" };

       private readonly object randomnumber;

    }




}
