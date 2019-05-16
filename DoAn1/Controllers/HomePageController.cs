using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoAn1.Data.Interfaces;
using DoAn1.Data.Models;
using DoAn1.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DoAn1.Controllers
{
    public class HomePageController : Controller
    {
        private readonly IProductRepository _productRepository;

        public HomePageController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public IActionResult Index(int ProductTypeId)
        {
            if (ProductTypeId == 1)
            {
                List<Product> listHoodieProducts = new List<Product>();
                listHoodieProducts = _productRepository.GetAllWithType().Where(p => p.ProductType.Name == "Hoodie").ToList();
                return View(listHoodieProducts);
            }

            else if (ProductTypeId == 2)
            {
                List<Product> listLongSleeveProducts = new List<Product>();
                listLongSleeveProducts = _productRepository.GetAllWithType().Where(p => p.ProductType.Name == "LongSleeve").ToList();
                return View(listLongSleeveProducts);
            }

            else if (ProductTypeId == 3)
            {
                List<Product> listJacketProducts = new List<Product>();
                listJacketProducts = _productRepository.GetAllWithType().Where(p => p.ProductType.Name == "Jacket").ToList();
                return View(listJacketProducts);
            }

            else if (ProductTypeId == 4)
            {
                List<Product> listShirtProducts = new List<Product>();
                listShirtProducts = _productRepository.GetAllWithType().Where(p => p.ProductType.Name == "Shirt").ToList();
                return View(listShirtProducts);
            }
            else
            {
                List<Product> listProducts = new List<Product>();
                listProducts = _productRepository.GetAll().ToList();
                return View(listProducts);
            }           
        }

        public IActionResult Details(int id)
        {
            var pVM = new ProductViewModel
            {
                Product = _productRepository.GetProductByIDWithType(id),
                Size = ""
            };
            return View(pVM);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Search(string searchString)
        {
            List<Product> ListSearchProduct = new List<Product>();
            ListSearchProduct = _productRepository.GetAllWithType().ToList();
            if (!String.IsNullOrEmpty(searchString))
            {
                ListSearchProduct = ListSearchProduct.Where(s => s.ProductName.ToLower().Contains(searchString.ToLower())).ToList();
            }
            return View("Index", ListSearchProduct);
        }
    }
}