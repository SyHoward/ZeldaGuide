using System.ComponentModel.DataAnnotations;

namespace ZeldaGuide.Models.ToDo;

public class ToDoUpdate
{
    [Required]
    public int ToDoId { get; set; }

    [Required]
    public int NewQuestId { get; set; }

    [Required]
    public int NewAdventureId {get; set;}
}
