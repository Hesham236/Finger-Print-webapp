using AutoMapper;
using Finger_Print_WebApi.Models.Domain;
using Finger_Print_WebApi.Models.DTO.ContractDto;
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
        [HttpPost("AddContract")]
        public async Task<IActionResult> AddContractAsync(ContractDto contractDto)
        {
            await contractRepository.AddContractAsync(contractDto);
            return Ok("Contract Created");
        }
        [HttpPut("UpdateContract/{id:int}")]
        public async Task<IActionResult> UpdateContractAsync([FromRoute] int id, [FromBody] ContractDto contractdto)
        {
            var con = mapper.Map<Contract>(contractdto);
            if (con == null) return NotFound();
            con = await contractRepository.UpdateContractAsync(id, con);
            var userdt = mapper.Map<ContractDto>(con);
            return Ok("User Updated");
        }
    }
}
