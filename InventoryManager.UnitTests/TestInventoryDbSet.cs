using InventoryManager.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.UnitTests
{
    class TestInventoryDbSet : TestDbSet<InventoryItem>
    {
        public override InventoryItem Find(params object[] keyValues)
        {
            return this.SingleOrDefault(product => product.Id == (int)keyValues.Single());
        }
    }
}
