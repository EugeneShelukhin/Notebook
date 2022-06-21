using AutoMapper;
using Notebook.DTOs;
using Notebook.Models;

namespace Notebook.Controllers.AutomapperProfiles
{
    public class Profiles : Profile
    {
        public Profiles()
        {
            CreateMap<Article, ArticleReadDTO>();
            CreateMap<ArticleCreateDTO, Article>();
            CreateMap<Topic, TopicReadDTO>();
            CreateMap<TopicCreateDTO, Topic>();
        }
    }
}