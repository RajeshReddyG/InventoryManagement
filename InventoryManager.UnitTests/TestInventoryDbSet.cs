using InventoryManager.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.UnitTests
{
    class TestInventoryDbSet : TestDbSet<InventoryItem>, IDbSet<InventoryItem>
    {
        public override async Task<InventoryItem> FindAsync(params object[] keyValues)
        {
            return await Task.Run(() =>
            {
                return this.SingleOrDefault(product => product.Id == (int)keyValues.Single());
            });
        }
    }
}
