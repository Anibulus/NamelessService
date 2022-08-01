using Blogging.Entities;
using Microsoft.EntityFrameworkCore;


namespace Core;

public class BloggingContext : DbContext
{
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<BlogCategory> BlogCategories { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<BlogComment> BlogComments { get; set; }
    public DbSet<BlogList> BlogLists { get; set; }
    public DbSet<BlogListItem> BlogListItems { get; set; }
    public DbSet<BlogReaction> BlogReactions { get; set; }
    //public DbSet<OpenGraph> OpenGraphs { get; set; }
    //public DbSet<SEO> SEO { get; set; }
    //public DbSet<BlogTag> BlogTags { get; set; }

    public BloggingContext() { }
    public BloggingContext(DbContextOptions<BloggingContext> options) : base (options){ }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //FIXME Reparar el enviroment
        //string db = Environment.GetEnvironmentVariable("DB_CONNECTION") ?? "";
        //Console.WriteLine(db);
        optionsBuilder.UseSqlite("Data Source=My.db");
            //@"Server=(localdb)\mssqllocaldb;Database=Blogging;Trusted_Connection=True");
    }
}