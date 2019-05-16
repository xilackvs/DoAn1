using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DoAn1.Data.Interfaces;
using DoAn1.Data.Models;
using DoAn1.Models;
using DoAn1.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using DoAn1.Data.Dto;
using AutoMapper;

namespace DoAn1.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ManagementController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly IProductTypeRepository _productTypeRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public ManagementController(
            IProductRepository productRepository,
            IProductTypeRepository productTypeRepository,
            IOrderRepository orderRepository,
            IMapper mapper)
        {
            _productRepository = productRepository;
            _productTypeRepository = productTypeRepository;
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public IActionResult Index(string sortOrder, string searchString, string currentFilter, int? page)
        {
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["PriceSort"] = String.IsNullOrEmpty(sortOrder) ? "price_desc" : "";
            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewData["CurrentFilter"] = searchString;
            List<Product> ListSearchProduct = new List<Product>();
            ListSearchProduct = _productRepository.GetAllWithType().ToList();
            if (!String.IsNullOrEmpty(searchString))
            {
                ListSearchProduct = ListSearchProduct.Where(s => s.ProductName.ToLower().Contains(searchString.ToLower())).ToList();
            }
            switch (sortOrder)
            {
                case "name_desc":
                    ListSearchProduct = ListSearchProduct.OrderByDescending(s => s.ProductName).ToList();
                    break;
                case "price_desc":
                    ListSearchProduct.OrderByDescending(s => s.Price).ToList();
                    break;
                    //case "year_desc":
                    //    model.Cheeses.OrderByDescending(s => s.Name);
                    //    break;
            }
            int pageSize = 3;
            return View(PaginatedListProduct<Product>.Create(ListSearchProduct.AsQueryable(), page ?? 1, pageSize));
        }
        public IActionResult Add()
        {          
            var productTypes = _productTypeRepository.GetAllWithProduct().ToList();
            ViewData["productTypes"] = new SelectList(productTypes, "Id", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult Add([FromForm]ProductDto newProduct, IFormFile photo)
        {
            if (ModelState.IsValid)
            {
                if (photo == null || photo.Length == 0)
                {
                    newProduct.Photo = "image_tb.png";
                }
                else
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/Products", photo.FileName);
                    var stream = new FileStream(path, FileMode.Create);
                    photo.CopyToAsync(stream);
                    newProduct.Photo = photo.FileName;
                }
                var addProduct = _mapper.Map<ProductDto, Product>(newProduct);
                _productRepository.Create(addProduct);
                return RedirectToAction("Index");
            }
            else
            {
                var productTypes = _productTypeRepository.GetAllWithProduct().ToList();
                ViewData["productTypes"] = new SelectList(productTypes, "Id", "Name");
                return View();
            }
        }
        public IActionResult Detail(int id)
        {
            return View(_productRepository.GetProductByIDWithType(id));
        }

        public IActionResult Edit(int id)
        {
            var productTypes = _productTypeRepository.GetAllWithProduct().ToList();
            ViewData["productTypes"] = new SelectList(productTypes, "Id", "Name");
            return View(_productRepository.GetProductByIDWithType(id));
        }
        [HttpPost]
        public IActionResult Edit(int id, Product editedProduct)
        {
            if (ModelState.IsValid)
            {
                _productRepository.Update(editedProduct);
                return RedirectToAction("Index");
            }
            var productTypes = _productTypeRepository.GetAllWithProduct().ToList();
            ViewData["productTypes"] = new SelectList(productTypes, "Id", "Name");
            return View(_productRepository.GetProductByIDWithType(id));
        }

        [HttpGet]
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var deleteProduct = _productRepository.GetProductByIDWithType(id);
            _productRepository.Delete(deleteProduct);
            return NoContent();
        }
    }
}