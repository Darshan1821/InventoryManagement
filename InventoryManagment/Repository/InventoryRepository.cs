using System.Collections.Generic;
using InventoryManagment.Models;

namespace InventoryManagment.Repository
{
    public class InventoryRepository : IInventoryRepository
    {
        public void AddProduct(int id, string name, double price, int quantity, string type)
        {
            Database.AddProduct(new InventoryModel() { Id = id, Name = name, Price = price, Quantity = quantity, Type = type });   
        }

        public void DeleteProduct(int id)
        {
            Database.DeleteProduct(id);
        }

        public void UpdateProduct(int id, string name, double price, int quantity, string type)
        {
            Database.UpdateProduct(id,name,price,quantity,type);
        }

        public List<InventoryModel> GetAllProduct()
        {
            return Database.GetAllProducts();
        }
    }
}
