namespace Blogging.Entities;

public class Blog : BaseModel
{
    public Guid? UserId { get; set; }
    public string Title { get; set; } = "";
    public string? Content { get; set; }
    public int Views { get; set; }
    public virtual ICollection<BlogCategory> BlogCategories { get; set; } = new List<BlogCategory>();
    public virtual ICollection<BlogComment> BlogComments { get; set; } = new List<BlogComment>();
    public virtual ICollection<BlogReaction> BlogReactions { get; set; } = new List<BlogReaction>();
    public virtual ICollection<BlogListItem> BlogListItem { get; set; } = new List<BlogListItem>();
}