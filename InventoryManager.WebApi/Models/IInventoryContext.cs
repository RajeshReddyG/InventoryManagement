using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace InventoryManager.WebApi.Models
{
    public interface IInventoryContext : IDisposable
    {
        DbSet<InventoryItem> InventoryItems { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
        void MarkAsModified(InventoryItem item);
    }
}
