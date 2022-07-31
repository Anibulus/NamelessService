using Graphql.Mutations;
using GraphQL;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<CreateBlogMutation>();

var app = builder.Build();

app.MapGraphQL();
app.MapGet("/", () => "Hello World!");
app.Run();