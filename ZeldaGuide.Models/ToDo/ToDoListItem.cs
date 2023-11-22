using System.ComponentModel.DataAnnotations.Schema;


namespace ZeldaGuide.Models.ToDo;

public class ToDoListItem
{
    public int ToDoId {get; set;}
    public int QuestId {get; set;}
    public int AdventureId {get; set;}
}