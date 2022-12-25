using AutoMapper;
using Finger_Print_WebApi.Models.Domain;
using Finger_Print_WebApi.Models.DTO.ContractDto;

namespace Finger_Print_WebApi.Models.Profiles
{
    public class ContractProfile : Profile
    {
        public ContractProfile()
        {
            CreateMap<Contract,ContractDto>();
            CreateMap<ContractDto,Contract>()
                 .ForMember(m => m.Id, e => e.Ignore());
        }
    }
}
