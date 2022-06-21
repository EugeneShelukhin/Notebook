using System.ComponentModel.DataAnnotations;

namespace Notebook.DTOs
{
    public class ArticleCreateDTO
    {
        [Required]
        public string Title { get; set; }
        public string? Description { get; set; }
        public int TopicId { get; set; }
    }
}