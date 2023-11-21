using System.ComponentModel.DataAnnotations;

namespace ZeldaGuide.Data.Entities;
public class SideAdventureEntity
{
        [Key]
        public int AdventureId {get; set;}

        [Required]
        [MinLength(5), MaxLength(200)]
        public string Name {get; set;} = string.Empty;

        [Required]
        [MinLength(5), MaxLength(500)]
        public string Description {get; set;} = string.Empty;
}