using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace small_business_management_API.Models
{
    public class FinancialReport
    {
        public int ReportId { get; set; }
        public DateTime Month { get; set; }
        public int Year { get; set; }
        public decimal TotalIncome { get; set; }
        public decimal TotalExpenses { get; set; }
        public decimal ProfitLoss
        {
            get { return TotalIncome - TotalExpenses; }
        }
    }
}
