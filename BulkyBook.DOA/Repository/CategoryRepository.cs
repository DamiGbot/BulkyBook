using BulkyBook.DOA.Data;
using BulkyBook.Models;

namespace BulkyBook.DOA.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;
        public CategoryRepository(ApplicationDbContext context)
        {
            this._context = context;
        }

        public List<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }

        public Category? GetCategory(int id)
        {
            var category = _context.Categories.Find(id);
            return category == null ? null : category;  
        }

        public void Add(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void Update(Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
        }

        public void Delete(Category category)
        {
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }
    }
}
