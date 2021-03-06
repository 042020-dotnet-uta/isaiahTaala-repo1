﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StoreApp.Data;
using StoreApp.BusinessLogic;
using System;
using System.Diagnostics.Eventing.Reader;
using Microsoft.AspNetCore.Http;
using Store.WebApp.Models;

namespace StoreApp.WebApp.Controllers
{
    public class LoginController : Controller
    {
        private readonly IRepository<BusinessLogic.User> _repository;

        public LoginController(IRepository<BusinessLogic.User> repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var viewModel = new LoginViewModel();
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Index(LoginViewModel user)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }
                var businessUser = new BusinessLogic.User
                {
                    Email = user.Email,
                    Password = user.Password
                };

                var dbuser = await _repository.GetAsync(businessUser);

                HttpContext.Session.SetString("Email", businessUser.Email);

                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }
    }
}