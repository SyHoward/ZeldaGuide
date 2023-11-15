using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace ZeldaGuide.Data.Entities;

public class LocationsEntity
{
    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }

    public string? Location { get; set; }
}