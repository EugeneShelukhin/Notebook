using AutoMapper;
using Models;
using Notebook.DTOs;

namespace Notebook.Controllers.AutomapperProfiles
{
    public class Profiles : Profile
    {
        public Profiles()
        {
            CreateMap<DotnetCLI, DotnetCLIReadDTO>();
            CreateMap<DotnetCLICreateDTO, DotnetCLI>();
        }
    }
}