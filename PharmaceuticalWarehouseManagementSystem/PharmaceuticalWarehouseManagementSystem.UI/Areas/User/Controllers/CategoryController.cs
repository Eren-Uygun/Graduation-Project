﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PharmaceuticalWarehouseManagementSystem.ENTITY.Entity;
using PharmaceuticalWarehouseManagementSystem.INFRASTRUCTURE.Repository.Abstract;

namespace PharmaceuticalWarehouseManagementSystem.UI.Areas.User.Controllers
{
    [Area("User")]
    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
    public class CategoryController : Controller
    {
        private ICategoryRepository _repository;
        public CategoryController(ICategoryRepository repository)
        {
            this._repository = repository;
        }
        public IActionResult List()
        {
          
            return View(  _repository.GetActive());
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Category category)
        {
            if (ModelState.IsValid)
            { 
                bool result = _repository.Add(category);
                
                
                if (result == true)
                {
                    _repository.Save();
                    return RedirectToAction("List");
                }
                else
                {
                    TempData["Message"] = $"Kayıt işlemi sırasında bir hata oluştu. Lütfen tüm alanları kontrol edip tekrar deneyin..!";
                    return View(category);
                }
            }
            else
            {
                TempData["Message"] = $"Kayıt işlemi sırasında bir hata oluştu. Lütfen tüm alanları kontrol edip tekrar deneyin..!";
                return View(category);
            }
            
        }
        [HttpGet]
        public IActionResult Edit(Guid ID)
        {
            return View(_repository.GetById(ID));
        }
        [HttpPost]
        public IActionResult Edit(Category item)
        {
            if (ModelState.IsValid)
            {
                Category updated = _repository.GetById(item.ID);
                updated.CategoryName = item.CategoryName;
                updated.CategoryDescription = item.CategoryDescription;

                bool result = _repository.Update(updated);
                if (result)
                {
                    _repository.Save();
                    return RedirectToAction("List");
                }
                else
                {
                    TempData["Message"] = $"Güncelleme işlemi sırasında bir hata oluştu. Lütfen tekrar deneyin..!";
                    return View(updated);
                }
            }
            else
            {
                TempData["Message"] = $"Güncelleme işlemi sırasında bir hata oluştu. Lütfen tekrar deneyin..!";
                return View();
            }
            
        }

        public IActionResult Delete(Guid id)
        {
            _repository.Remove(_repository.GetById(id));
            return RedirectToAction("List");
        }
    }
}