using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ThinkBridgeAssessment.Entity;

//using server explorer add a connection to server
//from add new item add new entity data model, 
//this will connect to DB select necessary tables
//this will add edmx files to Model 
//We can use similar linq along with DB with using DB context
//using (var db = new DBContext())

namespace ThinkBridgeAssessment.Repository
{
    public class Inventory : IInventory
    {
        public static readonly List<Item> item = new List<Item>();
        static Inventory()
        {
            //using local list so initalizing it in constructor
            Inventory.item = new List<Item>()
            {
                new Item(1,"Pen", "Green", true),
                new Item(2, "Book", "C#", true),
                new Item(3, "Mango", "Summer treat", true),
                new Item(4, "Notepad", "100 pages", true)
            };
        }

        public List<Item> Get()
        {
            var result = item.Where(a => a.itemId > 0).ToList();
            return result;
        }

        public Item AddItem(Item postitem)
        {
            int newitemId = item.Max(a => a.itemId);
            newitemId++;
            postitem.itemId = newitemId;
            Inventory.item.Add(postitem);
            return postitem;
        }

        public Item RemoveItem(Item removeItem)
        {
            var remove = item.Where(a => a.Name == removeItem.Name);
            item.RemoveAll(a => a.Name == removeItem.Name);
            return removeItem;
        }

        public Item UpdateItem(Item newItem)
        {
            foreach(var i in item.Where(a => a.Name == newItem.Name))
            {
                //i.Description = newItem.Description;
                //change availability, to remove item use delete
                i.isAvailable = newItem.isAvailable;
            }
            return newItem;
        }
    }
}