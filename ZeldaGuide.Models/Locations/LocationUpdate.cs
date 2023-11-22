using System.ComponentModel.DataAnnotations;
namespace ZeldaGuide.Models.Locations;
public class LocationUpdate
{
    [Required]
    public int Id {get; set;}
    [Required]
    [MinLength(5, ErrorMessage = "{0} must be at least {1} characters long.")]
    [MaxLength(200, ErrorMessage = "{0} must contain no more than {1} characters.")]
    public string Name {get; set;} = string.Empty;
    [Required]
    [MinLength(5, ErrorMessage = "{0} must be at least {1} characters long.")]
    [MaxLength(500, ErrorMessage = "{0} must contain no more than {1} characters.")]
    public string Description {get; set;} = string.Empty;
}