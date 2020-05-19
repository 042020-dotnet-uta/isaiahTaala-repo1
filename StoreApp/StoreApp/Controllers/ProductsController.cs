using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StoreApp.Data;
using StoreApp.BusinessLogic;
using StoreApp.WebApp.Models;

namespace StoreApp.WebApp.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IRepository<BusinessLogic.Product> _repository;

        public ProductsController(IRepository<BusinessLogic.Product> repository)
        {
            _repository = repository;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            return View(await _repository.GetAllAsync());
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var product = await _repository.GetAsync(id);

            if (product == null)
            {
                return NotFound();
            }
            // add locations to select from for drop down list on view


            var poViewModel = new ProductOrderViewModel
            {
                ProductID = product.ProductID,
                Name = product.Name,
                Price = product.Price
            };
            return View(poViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        // POST: Products/Details/5
        public async Task<IActionResult> Details(ProductOrderViewModel poViewModel)
        {
            
            //var product = await _repository.GetAsync(id);

            //if (product == null)
            //{
            //    return NotFound();
            //}

            return View(poViewModel);
        }
    }
}
