using System.ComponentModel.DataAnnotations;

namespace Models;
public class DotnetCLI
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required]
    public string Template { get; set; }
    [Required]
    public string ShortName { get; set; }
    [Required]
    public string Tags { get; set; }//dataset?
    public string Description { get; set; }

}