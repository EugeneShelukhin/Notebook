namespace Notebook.DTOs
{
    public class ArticleReadDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public int TopicId { get; set; }
    }
}