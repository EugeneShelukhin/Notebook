using System.ComponentModel.DataAnnotations;

namespace Notebook.Models
{
    public class Topic
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string? Description { get; set; }
        public int? ParentTopicId { get; set; }
        public Topic? ParentTopic { get; set; }
        public List<Topic> NestedTopics { get; set; }
    }
}