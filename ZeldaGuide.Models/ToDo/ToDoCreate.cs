using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ZeldaGuide.Models.ToDo;

public class ToDoCreate
{
    [Required]
    public int NewQuestId {get; set;}

    public int NewAdventureId {get; set;}
}
