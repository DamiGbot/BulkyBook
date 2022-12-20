using BulkyBookWeb.Models;

namespace BulkyBookWeb.Repository
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
