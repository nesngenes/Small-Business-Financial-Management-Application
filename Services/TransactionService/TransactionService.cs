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
        public async Task<ServiceResponse<List<Transaction>>> AddTransaction(Transaction newTransaction)
        {
            var serviceResponse =new ServiceResponse<List<Transaction>>();
            transactions.Add(newTransaction);
            serviceResponse.Data = transactions;
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Transaction>>> GetAllTrasactions()
        {
            var serviceResponse =new ServiceResponse<List<Transaction>>();
            serviceResponse.Data = transactions;
            return serviceResponse;
        }

        public async Task<ServiceResponse<Transaction>> GetTransactionById(int id)
        {
            var serviceResponse =new ServiceResponse<Transaction>();
            var transaction = transactions.FirstOrDefault(c => c.TransactionId == id);
            serviceResponse.Data = transaction;
            return serviceResponse;
        }
    }
}