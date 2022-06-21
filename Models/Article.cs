using System.ComponentModel.DataAnnotations;

namespace Notebook.Models;
public class Article
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required]
    public string Title { get; set; }
    public string? Description { get; set; }
    public int TopicId { get; set; }
}