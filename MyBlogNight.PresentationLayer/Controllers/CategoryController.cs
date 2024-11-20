﻿using Microsoft.AspNetCore.Mvc;
using MyBlogNight.BusinessLayer.Abstract;
using MyBlogNight.EntityLayer.Concrete;

namespace MyBlogNight.PresentationLayer.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult CategoryList()
        {
            var values = _categoryService.TtGetAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateCategory ()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCategory (Category category)
        {
            _categoryService.TInsert(category);
            return RedirectToAction("CategoryList");
        }
    }
}
