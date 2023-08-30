using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace small_business_management_API.Models
{
    public class Reminder
    {
        public int ReminderId { get; set; }
        public string? Description { get; set; }
        public DateTime DueDate { get; set; }
        public ReminderType Class { get; set; }
    }
}
