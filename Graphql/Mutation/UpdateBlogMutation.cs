using Blogging.Entities;

namespace Graphql.Mutations;
public class UpdateBlogMutation
{
    [UseMutationConvention]
    public void CreateBlog([ID] Guid id)
    {
    } 
}