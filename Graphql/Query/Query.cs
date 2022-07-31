namespace GraphQL;

public class Query
{
    public Blogging.Entities.Blog GetBlog() =>
        new Blogging.Entities.Blog
        {
            Title = "C# in depth.",
        };
}