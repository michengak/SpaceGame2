using Engine.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    public static class ItemsFactory
    {
        private static List<GameItem> _StandardGameItems;
        private static List<GameItem> StandardGameItem;

        static ItemsFactory()
        {
            StandardGameItem = new List<GameItem>();
        }

        public static GameItem CreateGameItem (int itemTypeID)
        { 
            GameItem standardItem = StandardGameItem.FirstOrDefault(item => item.ItemTypeId == itemTypeID);

            if (standardItem != null)
            {
                return standardItem.Clone();
                        
            }

            return null;

            

        }   

    }
}
