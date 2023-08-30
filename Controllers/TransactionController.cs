using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using small_business_management_API.Models;

namespace small_business_management_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionController : ControllerBase
    {
        private static List<Transaction> transactions = new List<Transaction>
        {
            new Transaction(),
            new Transaction { TransactionId = 1, Category = "seblak" }
        };

        [HttpGet("GetAll")]
        public ActionResult<List<Transaction>> Get()
        {
            return Ok(transactions);
        }

        [HttpGet("{id}")]
        public ActionResult<Transaction> GetSingle(int id)
        {
            return Ok(transactions.FirstOrDefault(c => c.TransactionId == id));
        }
    }
}
