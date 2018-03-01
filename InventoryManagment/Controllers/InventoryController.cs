using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryManagment.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagment.Controllers
{
    public class InventoryController : Controller
    {

        public IInventoryRepository IInventoryRepository { get; set; }

        public InventoryController(IInventoryRepository inventoryRepostiory)
        {
            IInventoryRepository = inventoryRepostiory;
        }

        public IActionResult Index()
        {
            var products = IInventoryRepository.GetAllProduct();

            return View(products);
        }

        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProductToDatabase(IFormCollection form)
        {
            string Name = form["productName"].ToString();
            double Price = Double.Parse(form["productPrice"].ToString());
            int Quantity = int.Parse(form["productQuantity"].ToString());
            string Type = form["productType"].ToString();

            IInventoryRepository.AddProduct(11,Name,Price,Quantity,Type);

            return RedirectToAction(nameof(Index));
        }
    }
}