using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManager.WebApi.Models
{
    public class InventoryContext : DbContext, IInventoryContext
    {
        public InventoryContext(DbContextOptions<InventoryContext> options) : base(options)
        {

        }
        public DbSet<InventoryItem> InventoryItems { get; set; }
        public void MarkAsModified(InventoryItem item)
        {
            Entry(item).State = EntityState.Modified;
        }
    }
}
