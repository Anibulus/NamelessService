using System.ComponentModel.DataAnnotations.Schema;

namespace Blogging.Entities;

public class BlogCategory : BaseModel
{
    public Guid? BlogId { get; set; }
    public Guid? CategoryId { get; set; }
    [ForeignKey(nameof(BlogId))]
    public virtual Blog? Blog { get; set; }
    [ForeignKey(nameof(CategoryId))]
    public virtual Category? Category { get; set; }
}