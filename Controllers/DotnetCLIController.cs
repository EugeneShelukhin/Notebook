using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Notebook.Data;
using Notebook.DTOs;

namespace Notebook.Controllers
{
    [Route("api/[controller]")]//как сделать для всех контроллеров?
    [ApiController]//для чего?
    public class DotnetCLIController : ControllerBase
    {
        private readonly IDotnetCLIRepository _repo;
        private readonly IMapper _mapper;

        public DotnetCLIController(IDotnetCLIRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<DotnetCLIReadDTO>> GetAll()//Action Result- виды, что если без него?
        {
            return Ok(_mapper.Map<IEnumerable<DotnetCLIReadDTO>>(_repo.GetAll()));
        }
    }
}