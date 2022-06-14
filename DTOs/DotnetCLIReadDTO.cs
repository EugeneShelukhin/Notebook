namespace Notebook.DTOs
{
    public class DotnetCLIReadDTO
    {
        public int Id { get; set; }
        public string? Template { get; set; }
        public string ShortName { get; set; }
        public string? Tags { get; set; }//dataset?
        public string Group { get; set; }//dataset?
        public string Description { get; set; }
    }
}