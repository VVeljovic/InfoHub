using BuildingBlocks.Exceptions;

namespace CategoryAPI.Exceptions
{
    public class CategoryNotFoundException : NotFoundException
    {
        public CategoryNotFoundException() : base("Category with this Id does not exist.")
        { 
        }
    }
}
