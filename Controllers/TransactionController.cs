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
        private readonly ITrasactionService _transactionService;

        public TransactionController(ITrasactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<GetTransactionDto>>>> Get()
        {
            return Ok(await _transactionService.GetAllTrasactions());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetTransactionDto>>> GetSingle(int id)
        {
            return Ok(await _transactionService.GetTransactionById(id));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<GetTransactionDto>>>> AddTransaction(AddTransactionDto newTransaction)
        {
            return Ok(await _transactionService.AddTransaction(newTransaction));
        }
    }
}
