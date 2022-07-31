using Blogging.Entities;

namespace Graphql.Mutations;

public record BlogInput(string? Title);
public record BlogPayload(Blog blog);
public class CreateBlogMutation
{
    public async Task<BlogPayload> CreateBlog(BlogInput input)
    {
        Blog blog = new()
        {
            Title = input.Title ?? ""
        };

        return new BlogPayload(blog);
    } 
}