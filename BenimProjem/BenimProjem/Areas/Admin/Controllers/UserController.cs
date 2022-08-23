using BenimProjem.Areas.Admin.Models;
using BenimProjem.Business.Helpers;
using BenimProjem.Business.Services;
using Microsoft.AspNetCore.Mvc;
using BenimProjem.Entites;
using BenimProjem.Models;
using System;
using BenimProjem.Helpers;

namespace BenimProjem.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        IUserService _userService;
        IStringHelper _stringHelper;

        public UserController(IUserService userService, IStringHelper stringHelper)
        {
            _userService = userService;
            _stringHelper = stringHelper;
        }

        public IActionResult Index()
        {
            UsersListViewModel model = new();
            model.List = _userService.List();
            return View(model);
        }
        public IActionResult Delete(int id)
        {
            _userService.Delete(id);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Add(UserAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                _userService.Add(new User() 
                { 
                       Email = model.Email,
                       Password = _stringHelper.ToMd5(model.Password),
                       IsAdmin = model.IsAdmin,
                       Status = true
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            var user = _userService.GetById(id);
            UserAddViewModel userModel = new UserAddViewModel();
            userModel.Email = user.Email;
            userModel.IsAdmin = user.IsAdmin;
            userModel.UserId = AESHash.AES_Encrypt(id.ToString());
            return View(userModel);
        }
        public IActionResult Edit(UserAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = new User()
                {
                    Id = Convert.ToInt32(AESHash.AES_Decrypt(model.UserId)),//***************************************************************
                    Email = model.Email,
                    Password = _stringHelper.ToMd5(model.Password),
                    IsAdmin = model.IsAdmin,
                    Status = true //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
                };
                _userService.Update(user);
                return RedirectToAction("Index");

            }
            return View(model);
        }
    }
}
