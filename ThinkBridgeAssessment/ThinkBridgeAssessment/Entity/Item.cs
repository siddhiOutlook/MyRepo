using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThinkBridgeAssessment.Entity
{
    public class Item
    {
        public Item(int id, string name, string description, bool available)
        {
            itemId = id;
            Name = name;
            Description = description;
            isAvailable = available;
        }
        public int itemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool isAvailable { get; set; }
    }
}