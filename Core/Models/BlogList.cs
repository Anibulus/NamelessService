namespace Blogging.Entities;

public class BlogList : BaseModel
{
    public string Title { get; set; } = "";
    public string? Description { get; set; }
    public virtual ICollection<BlogListItem> BlogListItems { get; set; } = new List<BlogListItem>();
}