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
        private readonly IMapper _mapper;

        public TransactionService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<ServiceResponse<List<Transaction>>> AddTransaction(AddTransactionDto newTransaction)
    {
        var serviceResponse = new ServiceResponse<List<Transaction>>();
        var transaction = _mapper.Map<Transaction>(newTransaction);
        transaction.TransactionId = transactions.Max(t => t.TransactionId) + 1;
        transactions.Add(transaction);
        serviceResponse.Data = transactions;
        return serviceResponse;
    }

    public async Task<ServiceResponse<List<GetTransactionDto>>> GetAllTrasactions()
    {
        var serviceResponse = new ServiceResponse<List<GetTransactionDto>>();
        var dtoList = transactions.Select(c => _mapper.Map<GetTransactionDto>(c)).ToList();
        serviceResponse.Data = dtoList;
        return serviceResponse;
    }

    public async Task<ServiceResponse<GetTransactionDto>> GetTransactionById(int id)
    {
        var serviceResponse = new ServiceResponse<GetTransactionDto>();
        var transaction = transactions.FirstOrDefault(c => c.TransactionId == id);
        var dto = _mapper.Map<GetTransactionDto>(transaction);
        serviceResponse.Data = dto;
        return serviceResponse;
    }

        public Task<ServiceResponse<GetTransactionDto>> UpdateTransaction(UpdateTransactionDto updatedTransaction)
        {
            throw new NotImplementedException();
        }
    }
}