using System.ComponentModel.DataAnnotations;

namespace Presentation.Data;

public class EventEntity
{
    [Key]
    public string Id { get; set; } = Guid.NewGuid().ToString();

    public string Name { get; set; } = null!;
    public string DateTime { get; set; } = null!;
    public string Location { get; set; } = null!;
    public string Availability { get; set; } = null!; 
    public string Price { get; set; } = null!;
}