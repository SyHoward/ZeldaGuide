using System.ComponentModel.DataAnnotations.Schema;


namespace ZeldaGuide.Models.ToDo;

public class ToDoCreate
{
    
    public int QuestId {get; set;}
    
    //What to do here? Id is set by database. Owner should be be set by database? like upon create. MainQuest foreign key should just populate all quests to be checked off? 18.01
}
