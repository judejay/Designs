using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Stuctural_Patterns.Composite
{
    public class Part: Item
    {
        public Part(string description, int cost) : base(description, cost)
        {
        }

        public override void AddItem(Item item)
        {
            //Empty implementation for unit parts;
        }

        public override void RemoveItem(Item item)
        {
            //Empty implementation for unit parts;
        }

        public override Item[] Items
        {
            get
            {
                return new Item[0];
            }
        }
    }

}
