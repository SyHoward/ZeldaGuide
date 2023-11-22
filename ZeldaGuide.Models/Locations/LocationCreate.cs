using System.ComponentModel.DataAnnotations;

namespace ZeldaGuide.Models.Locations;


public class LocationCreate

{
    [Required]
    [MinLength(2, ErrorMessage = "{0}must be at least {1} character(s) long.")]
    [MaxLength(100, ErrorMessage = "{0} must be no more than {1} characters. ")]
    public string Location { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;


}