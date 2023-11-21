using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZeldaGuide.Data.Entities;

public class ToDoEntity
{
    [Key]
    public int ToDoId {get; set;}

    [Required]
    [ForeignKey(nameof(User))]
    public int Owner {get; set;}
    public virtual UserEntity User {get; set;}

    [Required]
    [ForeignKey(nameof(Quest))]
    public int QuestId {get; set;}
    public virtual MainQuestEntity Quest {get; set;}

}
