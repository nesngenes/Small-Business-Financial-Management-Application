using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace small_business_management_API.Services.TransactionService
{
    public interface ITrasactionService
    {
        Task<ServiceResponse<List<GetTransactionDto>>> GetAllTrasactions();
        Task<ServiceResponse<GetTransactionDto>> GetTransactionById(int id);
        Task<ServiceResponse<List<Transaction>>> AddTransaction(AddTransactionDto newTransaction);
        Task<ServiceResponse<GetTransactionDto>> UpdateTransaction(UpdateTransactionDto newTransaction);
    }
}