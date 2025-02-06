using CategoryAPI.Exceptions;
using CategoryAPI.Models;
using Marten;
using MediatR;

namespace CategoryAPI.Architecture.GetCategoryById.BussinesLogic
{
    public sealed class GetCategoryByIdQueryHandler(IDocumentSession documentSession,
        ILogger<GetCategoryByIdQueryHandler> logger)
        : IRequestHandler<GetCategoryByIdQuery, Category>
    {
        public async Task<Category> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            logger.LogInformation("GetCategoryByIdQueryHandler.Handle called with {@Query}", request);

            var category = await documentSession.LoadAsync<Category>(request.Id, cancellationToken);

            if (category == null) 
            {
                throw new CategoryNotFoundException();
            }
            return category;
        }
    }
}
