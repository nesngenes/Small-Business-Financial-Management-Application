using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace small_business_management_API.Services.TransactionService
{
    public class TransactionService : ITrasactionService
    {
        private static List<Transaction> transactions = new List<Transaction>
        {
            new Transaction(),
            new Transaction { TransactionId = 1, Category = "seblak" }
        };
        public async Task<ServiceResponse<List<GetTransactionDto>>> AddTransaction(AddTransactionDto newTransaction)
        {
            var serviceResponse =new ServiceResponse<List<GetTransactionDto>>();
            transactions.Add(newTransaction);
            serviceResponse.Data = transactions;
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetTransactionDto>>> GetAllTrasactions()
        {
            var serviceResponse =new ServiceResponse<List<GetTransactionDto>>();
            serviceResponse.Data = transactions;
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetTransactionDto>> GetTransactionById(int id)
        {
            var serviceResponse =new ServiceResponse<GetTransactionDto>();
            var transaction = transactions.FirstOrDefault(c => c.TransactionId == id);
            serviceResponse.Data = transaction;
            return serviceResponse;
        }
    }
}