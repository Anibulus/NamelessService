using System.ComponentModel.DataAnnotations.Schema;

namespace Blogging.Entities;

public class BlogListItem : BaseModel
{
    public Guid BlogListId { get; set; }
    public Guid BlogId { get; set; }
    public Guid UserId { get; set; }
    [ForeignKey(nameof(BlogListId))]
    public virtual BlogList? BlogList { get; set; }
    [ForeignKey(nameof(BlogId))]
    public virtual Blog? Blog { get; set; }
}