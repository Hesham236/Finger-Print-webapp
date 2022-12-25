using AutoMapper;
using Finger_Print_WebApi.Repos.IRepo;
using Microsoft.AspNetCore.Mvc;

namespace Finger_Print_WebApi.Controllers
{
    [ApiController]
    [Route("Contract")]
    public class ContractController : Controller
    {
        private readonly IContractRepository contractRepository;
        private readonly IMapper mapper;
        public ContractController(IContractRepository contractRepository,IMapper mapper)
        {
            this.contractRepository = contractRepository;
            this.mapper = mapper;
        }

        //Routes
        [HttpGet("GetAllContracts")]
        public async Task<IActionResult> GetAllContractsAsync()
        {
            return Ok( await contractRepository.GetAllContractsAsync());
            
        }
    }
}
