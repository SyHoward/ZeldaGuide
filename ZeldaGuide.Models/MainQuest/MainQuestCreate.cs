using System.ComponentModel.DataAnnotations;

namespace ZeldaGuide.Models.MainQuest;
public class MainQuestCreate
{
    [Required]
    [MinLength(5), MaxLength(200)]
    public string Name {get; set;} = string.Empty;
    [Required]
    [MinLength(5), MaxLength(500)]
    public string Description {get; set;} = string.Empty;
}