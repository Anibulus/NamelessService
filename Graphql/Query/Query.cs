using Blogging.Entities;
using Core;

namespace GraphQL;

public class Query
{
    public IQueryable<Blog> ListBlog(BloggingContext context)
    {
        return context.Blogs;
    }
}