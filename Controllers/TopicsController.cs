using AutoMapper;
//using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Notebook.DTOs;
using Notebook.Repositories;

namespace Notebook.Controllers
{
    [Route("api/[controller]")]//как сделать шаблон по умолчанию для всех контроллеров?
    [ApiController]//для чего?
    public class TopicsController : ControllerBase
    {
        private readonly ITopicsRepository _repo;
        private readonly IMapper _mapper;

        public TopicsController(ITopicsRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TopicReadDTO>>> GetAll()//Action Result- виды, что если без него?
        {
            return Ok(_mapper.Map<IEnumerable<TopicReadDTO>>(await _repo.GetAllAsync()));
        }
    }
}