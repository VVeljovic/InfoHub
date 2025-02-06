using Carter;
using CategoryAPI.Architecture.CreateCategory.BusinessLogic;
using CategoryAPI.Models;
using MediatR;

namespace CategoryAPI.Architecture.CreateCategory.EndPoint
{
    public sealed class CreateCategoryEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPost("/createCategory", async (CreateCategoryCommand createCategoryCommand,
                ISender sender) =>
            {
                var response = await sender.Send(createCategoryCommand);

                return Results.Created($"/category{response.Id}", response);
            })
             .WithName("CreateCategory")
             .Produces<Category>(StatusCodes.Status201Created)
             .WithSummary("Endpoint for creating new category")
             ;  
        }
    }
}
