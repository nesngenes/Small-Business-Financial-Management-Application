using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace small_business_management_API.Services.TransactionService
{
    public interface ITrasactionService
    {
        Task<ServiceResponse<List<Transaction>>> GetAllTrasactions();
        Task<ServiceResponse<Transaction>> GetTransactionById(int id);
        Task<ServiceResponse<List<Transaction>>> AddTransaction(Transaction newTransaction);
    }
}