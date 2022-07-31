namespace Blogging.Entities;

public class Category : BaseModel
{
    public Guid? UserId { get; set; }
    public string Name { get; set; } = "";
    public string? Description { get; set; }
    public virtual ICollection<BlogCategory> BlogCategories { get; set; } = new List<BlogCategory>();
}