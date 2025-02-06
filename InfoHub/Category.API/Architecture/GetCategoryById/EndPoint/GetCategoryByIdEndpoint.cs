using Carter;
using CategoryAPI.Architecture.GetCategoryById.BussinesLogic;
using CategoryAPI.Models;
using MediatR;

namespace CategoryAPI.Architecture.GetCategory.EndPoint
{
    public class GetCategoryByIdEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/getCategoryById/{Id}", async (string Id, ISender sender) =>
            {
                var response = await sender.Send(new GetCategoryByIdQuery(Id));
                return response;
            })
            .WithName("GetCategoryById")
            .WithSummary("Retrieve category by id")
            .Produces<Category>(StatusCodes.Status200OK);
        }
    }
}
