using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace small_business_management_API.Models
{
    public class TaxReminder
    {
        public int TaxReminderId { get; set; }
        public string? Description { get; set; }
        public DateTime DueDate { get; set; }
        public TaxType Class { get; set; }
        public decimal Amount { get; set; }
    }
}
