using System.ComponentModel.DataAnnotations;

namespace Models;
public class DotnetCLI
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required]
    public string ShortName { get; set; }
    public string? Template { get; set; }
    public string? Tags { get; set; }//dataset?
    public string? Group { get; set; }//dataset?
    public string? Description { get; set; }

}