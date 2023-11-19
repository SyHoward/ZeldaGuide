using System.ComponentModel.DataAnnotations;

namespace ZeldaGuide.Models.MainQuest;
public class MainQuestDetail
{
    public int Id {get; set;}
    public string Name {get; set;} = string.Empty;
    public string Description {get; set;} = string.Empty;
}