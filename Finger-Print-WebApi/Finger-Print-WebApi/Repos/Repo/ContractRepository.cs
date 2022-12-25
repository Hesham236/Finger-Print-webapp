using AutoMapper;
using Finger_Print_WebApi.Data;
using Finger_Print_WebApi.Models.Domain;
using Finger_Print_WebApi.Repos.IRepo;
using Microsoft.EntityFrameworkCore;

namespace Finger_Print_WebApi.Repos.Repo
{
    public class ContractRepository  : IContractRepository
    {
        private readonly FingerPrintDBContext fingerPrintDBContext;
        private readonly IMapper mapper;
        public ContractRepository(FingerPrintDBContext fingerPrintDBContext,IMapper mapper)
        {
            this.fingerPrintDBContext = fingerPrintDBContext;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<Contract>> GetAllContractsAsync()
        {
            return await fingerPrintDBContext.Contracts.ToListAsync();
        }
    }
}
