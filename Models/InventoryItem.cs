using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace small_business_management_API.Models
{
    public class InventoryItem
    {
        public int ItemId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int InitialStock { get; set; }
        public decimal Price { get; set; }
        public string? Category { get; set; }
    }
}
