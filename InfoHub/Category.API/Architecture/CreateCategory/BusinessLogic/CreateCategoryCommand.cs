using CategoryAPI.Models;
using MediatR;

namespace CategoryAPI.Architecture.CreateCategory.BusinessLogic
{
    public sealed record CreateCategoryCommand(string Id, string Name, string Description) : IRequest<Category>;
}
