using System.ComponentModel.DataAnnotations;

namespace ZeldaGuide.Data.Entities;

public class ToDoEntity
{
    [Key]
    public int Id {get; set;}

    [Required]
    public string MainQuests {get; set;} = string.Empty;
}
