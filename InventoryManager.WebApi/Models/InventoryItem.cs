using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManager.WebApi.Models
{
    public class InventoryItem
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public string ItemCode { get; set; }
        public long QuantityAvailable { get; set; }
        public string Catagory { get; set; }
        public bool IsActive { get; set; }
        public string Brand { get; set; }
        public string Manufacturer { get; set; }

    }
}
