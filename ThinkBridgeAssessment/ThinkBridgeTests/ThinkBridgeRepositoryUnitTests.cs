using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThinkBridgeAssessment.Entity;
using ThinkBridgeAssessment.Repository;

namespace ThinkBridgeTests
{
    [TestClass]
    public class ThinkBridgeRepositoryUnitTests
    {
        #region Private Menbers
        private IInventory _inventory = new Inventory();
        #endregion

        #region Initialize
        [TestInitialize]
        public void Initialize()
        {

        }
        #endregion

        #region Mock helpers
        #endregion

        #region Tests
        [TestMethod]
        public void InventoryGet_Test()
        {
            var result = _inventory.Get();
            Assert.IsNotNull(result);
            //Assert.IsTrue(result is JsonResult);
        }

        [TestMethod]
        public void InventoryAddItem_Test()
        {
            Item i = new Item(0,"Icecream", "mango", true);
            var result = _inventory.AddItem(i);
            Assert.IsNotNull(result);
            Assert.AreEqual(result.Name, "Icecream");
        }
        [TestMethod]
        public void InventoryUpdateItem_Test()
        {
            Item i = new Item(0, "Pen", "Green", false);
            var result = _inventory.UpdateItem(i);
            Assert.IsNotNull(result);
            Assert.AreEqual(result.isAvailable, false);
        }
        [TestMethod]
        public void InventoryRemoveItem_Test()
        {
            Item i = new Item(0, "Notepad", "100 pages", true);
            var result = _inventory.RemoveItem(i);
            Assert.IsNotNull(result);
            Assert.AreEqual(result.Name, "Notepad");
        }
        #endregion
    }
}
