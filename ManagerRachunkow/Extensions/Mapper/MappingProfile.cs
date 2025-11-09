using AutoMapper;
using ManagerRachunkow.Data.Models;

namespace ManagerRachunkow.Extensions.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<ApplicationUser, UserDTO>
        
        }

    }
}
