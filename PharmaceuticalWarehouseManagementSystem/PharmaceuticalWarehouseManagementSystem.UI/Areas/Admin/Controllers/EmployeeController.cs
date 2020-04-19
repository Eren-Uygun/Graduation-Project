﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PharmaceuticalWarehouseManagementSystem.DAL.Context;
using PharmaceuticalWarehouseManagementSystem.ENTITY.Entity;
using PharmaceuticalWarehouseManagementSystem.INFRASTRUCTURE.Repository.Abstract;
using PharmaceuticalWarehouseManagementSystem.Utility;

namespace PharmaceuticalWarehouseManagementSystem.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
    [Authorize(Roles = "Admin")]
    public class EmployeeController : Controller
    {
        private IEmployeeRepository _repository;
        private ProjectContext _context;
        private IHostingEnvironment _hostingEnvironment;
        private IWebHostEnvironment _webHostEnvironment;
        


        public EmployeeController(IEmployeeRepository repository,ProjectContext context,IHostingEnvironment hostEnvironment,IWebHostEnvironment webHostEnvironment)
        {
            this._repository = repository;
            this._context = context;
            this._hostingEnvironment = hostEnvironment;
            this._webHostEnvironment = webHostEnvironment;
            
                
        }
        public IActionResult List()
        {
            
            return View(_repository.GetActive());
            
        }

        [HttpGet]
        public IActionResult Add()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Add(Employee item,List<IFormFile> Files)
        {
            if (ModelState.IsValid)
            {
                bool imgResult;

                string imgPath = Upload.ImageUpload(Files, _hostingEnvironment, out imgResult);

                imgResult = true;

                if (imgResult)
                {
                    item.imageUrl = imgPath;
                }
                else
                {
                    item.imageUrl = "NULL";
                }





                bool result = _repository.Add(item);


                if (result == true)
                {
                    _repository.Save();
                    return RedirectToAction("List","Employee","/Admin/");
                }
                else
                {
                    TempData["Message"] = $"Kayıt işlemi sırasında bir hata oluştu. Lütfen tüm alanları kontrol edip tekrar deneyin..!";
                    return View(item);
                }
            }
            else
            {
                TempData["Message"] = $"Kayıt işlemi sırasında bir hata oluştu. Lütfen tüm alanları kontrol edip tekrar deneyin..!";
                return View(item);
            }
          
        }

        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            return View(_repository.GetById(id));
        }

        [HttpPost]
        public IActionResult Edit(Employee item)
        {
            if (ModelState.IsValid)
            {
                Employee updated = _repository.GetById(item.ID);

                updated.FirstName = item.FirstName;
                updated.LastName = item.LastName;
                updated.BirthDate = item.BirthDate;
                updated.HireDate = item.HireDate;
                updated.Email = item.Email;
                updated.Password = item.Password;
                updated.PhoneNumber = item.PhoneNumber;
                updated.Address = item.Address;
                updated.Country = item.Country;
                updated.City = item.City;
                updated.imageUrl = item.imageUrl;
                updated.Role = item.Role;
                updated.PostalCode = item.PostalCode;
              



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

        public IActionResult Details(Guid id)
        {

            var employee = _repository.GetById(id);
            return View(employee);
        }







  
    }
}