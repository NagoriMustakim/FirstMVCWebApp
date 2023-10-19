﻿using FirstMVCWebApp.Data;
using FirstMVCWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCWebApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;

        }
        public IActionResult Index()
        {   
            IEnumerable<Category> objCategoryList   = _db.Categories;
            return View(objCategoryList);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category obj)
        {
            if (ModelState.IsValid)
            {


                _db.Categories.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        
    }
}
