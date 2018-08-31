using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.models
{
    public class Player
    {
   
        public string Name { get; set; }
        public string Items { get; set; }
        public string Level { get; internal set; }
        public string CargoType { get; private set; }
        public string Fortune { get; set; }
        
    }
}
