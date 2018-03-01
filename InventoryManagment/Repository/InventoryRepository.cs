using System;
using System.Collections.Generic;
using InventoryManagment.Models;

namespace InventoryManagment.Repository
{
    public class InventoryRepository : IInventoryRepository
    {
        public List<InventoryModel> AddProduct(int id, string name, double price, int quantity, string type)
        {
            productList.Add(new InventoryModel() { Id = id, Name = name, Price = price, Quantity = quantity, Type = type });
            return productList;
        }

        public List<InventoryModel> DeleteProduct(string name)
        {
            throw new NotImplementedException();
        }

        public List<InventoryModel> UpdateProduct(int id, string name, double price, int quantity, string type)
        {
            throw new NotImplementedException();
        }

        public List<InventoryModel> GetAllProduct()
        {
            return productList;
        }

        List<InventoryModel> productList = Database.GetAllProducts();
    }
}
