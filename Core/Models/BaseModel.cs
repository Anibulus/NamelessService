using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blogging.Entities;

public abstract class BaseModel
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public BaseModel()
    {
        this.Id = Guid.NewGuid();
        this.CreatedAt = DateTime.UtcNow;
        this.UpdatedAt = DateTime.UtcNow;
    }
}