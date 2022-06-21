using System.ComponentModel.DataAnnotations;
using Notebook.Models;

namespace Notebook.DTOs
{
    public class TopicCreateDTO
    {
        [Required]
        public string Title { get; set; }
        public string? Description { get; set; }
        public string? ParentTopicId { get; set; }
        public Topic? ParentTopic { get; set; }
        public List<Topic> NestedTopics { get; set; }
    }
}