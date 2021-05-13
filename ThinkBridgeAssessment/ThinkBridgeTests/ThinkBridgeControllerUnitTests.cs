using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThinkBridgeAssessment.Controllers;
using System.Web.Http;
using System.Net.Http;

namespace ThinkBridgeTests
{
    [TestClass]
    class ThinkBridgeControllerUnitTests
    {
        #region Private members
        private ItemController _itemController = new ItemController();
        #endregion

        #region Initialize
        [TestInitialize]
        public void Initialize()
        {
            var httpResponseMessage = new HttpResponseMessage(System.Net.HttpStatusCode.OK)
            {
                Content = new StringContent("This is result")
            };
        }
        #endregion

        #region Tests
        [TestMethod]
        public void ItemContollerGetItem_Test()
        {
            IHttpActionResult result = _itemController.GetItem();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ItemContollerNewItem_Test()
        {
            HttpResponseMessage result = _itemController.NewItem("Chocolate","Dark",true);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ItemContollerRemoveItem_Test()
        {
            HttpResponseMessage result = _itemController.RemoveItem("Pen");
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ItemContollerModifyItem_Test()
        {
            HttpResponseMessage result = _itemController.ModifyItem("Chocolate", false);
            Assert.IsNotNull(result);
        }
        #endregion
    }
}
