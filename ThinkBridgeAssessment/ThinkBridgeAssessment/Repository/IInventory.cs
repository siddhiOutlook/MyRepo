using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThinkBridgeAssessment.Entity;

namespace ThinkBridgeAssessment.Repository
{
    public interface IInventory
    {
        List<Item> Get();
        Item AddItem(Item postitem);
        Item RemoveItem(Item removeItem);
        Item UpdateItem(Item newItem);
    }
}
