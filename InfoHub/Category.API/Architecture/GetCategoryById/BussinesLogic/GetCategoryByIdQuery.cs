using CategoryAPI.Models;
using MediatR;

namespace CategoryAPI.Architecture.GetCategoryById.BussinesLogic
{
    public sealed record GetCategoryByIdQuery(string Id) : IRequest<Category>;
}
