using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZeldaGuide.Data.Entities;

public class ToDoEntity
{
    [Key]
    public int ToDoId {get; set;}

    [Required]
    [ForeignKey(nameof(OwnerId))]
    public int Owner {get; set;}
    public UserEntity OwnerId {get; set;} = null!;

    [Required]
    [ForeignKey(nameof(Id))]
    public int QuestId {get; set;}
    public MainQuestEntity Id {get; set;} = null!;
    //public QuestEntity QuestItem {get; set;}

}
