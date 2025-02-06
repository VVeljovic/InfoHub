using CategoryAPI.Models;
using Mapster;
using Marten;
using MediatR;

namespace CategoryAPI.Architecture.CreateCategory.BusinessLogic
{
    public sealed class CreateCategoryCommandHandler(IDocumentSession documentSession)
        : IRequestHandler<CreateCategoryCommand, Category>
    {
        public async Task<Category> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = request.Adapt<Category>();

            documentSession.Store(category);
            await documentSession.SaveChangesAsync(cancellationToken);

            return category;
        }
    }
}
