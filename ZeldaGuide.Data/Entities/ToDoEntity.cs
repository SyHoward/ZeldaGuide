using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZeldaGuide.Data.Entities;

public class ToDoEntity
{
    [Key]
    public int Id {get; set;}

    [Required]
    [ForeignKey(nameof(Owner))]
    public int OwnerId {get; set;}
    public UserEntity Owner {get; set;} = null!;

    [Required]
    //[ForeignKey(nameof(QuestItem))]
    public string MainQuests {get; set;} = string.Empty;
    //public QuestEntity QuestItem {get; set;}

}
