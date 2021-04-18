using InventoryManager.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
//using System.Data.Entity;
//using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InventoryManager.UnitTests
{
    public class TestInventoryContext : IInventoryContext
    {
        public TestInventoryContext()
        {
            //this.InventoryItems = new TestInventoryDbSet();
            //this.InventoryItems = new TestInventoryDbSet();

        }
        public DbSet<InventoryItem> InventoryItems { get; set; }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await Task.Run(() =>
            {
                return 0;
            });
        }

        public void MarkAsModified(InventoryItem item) { }
        public void Dispose() { }
    }
}
