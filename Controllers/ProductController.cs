using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BT_Tuan1.Models;
using Microsoft.AspNetCore.Mvc;

namespace BT_Tuan1.Controllers
{
    public class ProductController : Controller
    {
        public List<ProductViewModel> ListProduct { get; set; } = new List<ProductViewModel>
            {
                new ProductViewModel
                {
                    Id = 1,
                    Name = "Iphone",
                    Color = "Red",
                    ImageUrl = "",
                    Amount = 20
                },

                new ProductViewModel
                {
                    Id = 2,
                    Name = "SamSung",
                    Color = "blue",
                    ImageUrl = "",
                    Amount = 10
                },

                new ProductViewModel
                {
                    Id = 3,
                    Name = "Oppo",
                    Color = "White",
                    ImageUrl = "",
                    Amount = 15
                }
            };
        public IActionResult Index()
        {
            // write name of view model => Ctrl + . -> Enter or choose

            return View(ListProduct);
        }
        public IActionResult Add()
        {
            var model = new ProductViewModel();
            return View(model);
        }


        [HttpPost]
        public IActionResult Add(ProductViewModel model)
        {
            ListProduct.Add(model);
            return View("Index", ListProduct);
        }
    }
}
