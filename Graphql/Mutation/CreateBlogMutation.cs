using Blogging.Entities;
using Core;

namespace Graphql.Mutations;

public record BlogInput(string? Title);
public record BlogPayload(Blog blog);
public class CreateBlogMutation
{
    public async Task<BlogPayload> CreateBlog(BlogInput input, BloggingContext context)
    {
        Blog blog = new()
        {
            Title = input.Title ?? ""
        };
        context.Blogs.Add(blog);
        await context.SaveChangesAsync();

        return new BlogPayload(blog);
    } 
}