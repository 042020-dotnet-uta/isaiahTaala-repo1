using System.Threading.Tasks;
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
    public class RegisterController : Controller
    {
        private readonly IRepository<BusinessLogic.User> _repository;

        public RegisterController(IRepository<BusinessLogic.User> repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            HttpContext.Session.SetString("Email", string.Empty );

            var viewModel = new RegisterViewModel();
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Index(RegisterViewModel user)
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
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Password = user.Password
                };

                await _repository.AddAsync(businessUser);

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