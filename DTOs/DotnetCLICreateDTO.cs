using System.ComponentModel.DataAnnotations;

namespace Notebook.DTOs
{
    public class DotnetCLICreateDTO
    {
        public string? Template { get; set; }
        [Required]
        public string ShortName { get; set; }
        public string? Tags { get; set; }//dataset?
        public string Group { get; set; }//dataset?
        public string Description { get; set; }
    }
}