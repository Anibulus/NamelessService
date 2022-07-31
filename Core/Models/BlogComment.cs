using System.ComponentModel.DataAnnotations.Schema;

namespace Blogging.Entities;

public class BlogComment : BaseModel
{
    public string Text { get; set; } = "";
    public Guid? UserId { get; set; }
    public Guid BlogId { get; set; }
    [ForeignKey(nameof(BlogId))]
    public virtual Blog? Blog { get; set; }
}