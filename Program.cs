using Core;
using Graphql.Mutations;
using GraphQL;

using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<CreateBlogMutation>()
    .ConfigureResolverCompiler(x => x.AddService<BloggingContext>());

builder.Services.AddDbContext<BloggingContext>(opt => {
    //FIXME Reparar el enviroment
    string db = Environment.GetEnvironmentVariable("DB_CONNECTION") ?? "";   
    opt.UseSqlite("Data Source=My.db2");
}, ServiceLifetime.Scoped);

builder.Services.AddDbContextFactory<BloggingContext>(opt => {
    string db = Environment.GetEnvironmentVariable("DB_CONNECTION") ?? "";   
    opt.UseSqlite("Data Source=My.db2");
}, ServiceLifetime.Scoped);

builder.Services.AddScoped<BloggingContext>(opt => opt.GetRequiredService<IDbContextFactory<BloggingContext>>()
.CreateDbContext());


var app = builder.Build();

app.MapGraphQL();
app.MapGet("/", () => "Hello World!");
app.Run();