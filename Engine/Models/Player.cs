using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Engine.models;

namespace Engine.models
{
    public class Player
    {

        public string Name { get; set; }

        public static void Player()
        {
            throw new NotImplementedException();
        }

        public string Items { get; set; }
        public string Level { get; internal set; }
        public string CargoType { get; private set; }
        public string Fortune { get; set; }
    

        
        internal ObservableCollection<GameItem> Inventory { get; private set; }

        public Player()
        {
            Inventory = new ObservableCollection<GameItem>();
        }

    }


   
    
}
