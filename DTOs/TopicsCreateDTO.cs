using System.ComponentModel.DataAnnotations;
using Notebook.Models;

namespace Notebook.DTOs
{
    public class TopicCreateDTO
    {
        [Required]
        public string Title { get; set; }
        public string? Description { get; set; }
        public int? ParentTopicId { get; set; }
    }
}