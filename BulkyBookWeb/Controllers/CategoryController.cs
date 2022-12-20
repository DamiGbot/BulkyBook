using BulkyBookWeb.Data;
using BulkyBookWeb.Models;
using BulkyBookWeb.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBookWeb.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository= categoryRepository;
        }

        public IActionResult Index()
        {
            var objCategoryList = _categoryRepository.GetCategories();
            return View(objCategoryList);
        }

        //GET 
        public IActionResult Create()
        {   
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken] //helps to prevent cross site request forgery
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                _categoryRepository.Add(category);
                TempData["success"] = "Category Created Successfully";
                return RedirectToAction("Index", "Category");
            }
            return View(category);
        }

        //GET 
        public IActionResult Edit(int id)
        {
            var category = _categoryRepository.GetCategory(id);
            if (category == null) { return NotFound(); }

            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken] //helps to prevent cross site request forgery
        public IActionResult Edit(Category category)
        {

            if (ModelState.IsValid)
            {
                _categoryRepository.Update(category);
                TempData["success"] = "Category Updated Successfully";
                return RedirectToAction("Index", "Category");
            }
            return View(category);
        }

        //GET 
        public IActionResult Delete(int id)
        {
            var category = _categoryRepository.GetCategory(id);
            if (category == null) { return NotFound(); }

            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken] //helps to prevent cross site request forgery
        public IActionResult Delete(Category category)
        {
            _categoryRepository.Delete(category);
            TempData["success"] = "Category Deleted Successfully";
            return RedirectToAction("Index", "Category");
        }
    }
}
