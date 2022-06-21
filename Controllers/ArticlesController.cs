using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Notebook.Data;
using Notebook.DTOs;
using Notebook.Repositories;

namespace Notebook.Controllers
{
    [Route("api/[controller]")]//как сделать шаблон по умолчанию для всех контроллеров?
    [ApiController]//для чего?
    public class ArticlesController : ControllerBase
    {
        private readonly IArticlesRepository _repo;
        private readonly IMapper _mapper;

        public ArticlesController(IArticlesRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ArticleReadDTO>>> GetAll()//Action Result- виды, что если без него?
        {
            return Ok(_mapper.Map<IEnumerable<ArticleReadDTO>>(await _repo.GetAllAsync()));
        }
    }
}