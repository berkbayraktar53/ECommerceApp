using ECommerceApp.Business.Abstract;
using ECommerceApp.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceApp.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index(int category)
        {
            var model = new ProductListViewModel
            {
                Products = category > 0 ? _productService.GetByCategory(category) : _productService.GetAll(),
            };
            return View(model);
        }

        public IActionResult Search(string q)
        {
            var productViewModel = new ProductListViewModel
            {
                Products = _productService.GetSearchResult(q)
            };
            return View(productViewModel);
        }
    }
}