using Notebook.Models;

namespace Notebook.DTOs
{
    public class TopicReadDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public string? ParentTopicId { get; set; }
    }
}