using BulkyBook.Models;

namespace BulkyBook.DOA.Repository
{
    public interface ICategoryRepository
    {
        Category? GetCategory(int id);
        void Add(Category category);
        List<Category> GetCategories();
        void Update(Category category);
        void Delete(Category category);

    }
}
