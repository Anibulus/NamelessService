using System.ComponentModel.DataAnnotations.Schema;

namespace Blogging.Entities;

public class BlogReaction : BaseModel
{
    public Guid UserId { get; set; }
    public Guid BlogId { get; set; }
    public int EnumTypeReaction { get; set; }
    [ForeignKey(nameof(BlogId))]
    public virtual Blog? Blog { get; set; }
}