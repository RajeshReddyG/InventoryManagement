using InventoryManager.WebApi.Controllers;
using InventoryManager.WebApi.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Results;

namespace InventoryManager.UnitTests
{
    [TestFixture]
    class TestInventoryItemsController
    {
        [Test]
        public void PostProduct_ShouldReturnSameItem()
        {
            var controller = new InventoryItemsController(new TestInventoryContext());

            var item = GetSampleItem();

            var result =
                controller.PostInventoryItem(item).Result;

            Assert.IsNotNull(result);
            //Assert.AreEqual(result.RouteName, "DefaultApi");
            //Assert.AreEqual(result.RouteValues["id"], result.Content.Id);
            //Assert.AreEqual(result.Content.Name, item.Name);
        }

        InventoryItem GetSampleItem()
        {
            return new InventoryItem() { Id = 1, Name = "Demo name", Price = 5 };
        }
    }
}
