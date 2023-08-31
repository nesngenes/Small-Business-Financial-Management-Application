using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace small_business_management_API.Dtos.Transaction
{
    public class GetTransactionDto
    {
        public int TransactionId { get; set; }       
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }
    }
}