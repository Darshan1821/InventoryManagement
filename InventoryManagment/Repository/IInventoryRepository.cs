using InventoryManagment.Models;
using System.Collections.Generic;

namespace InventoryManagment.Repository
{
    public interface IInventoryRepository
    {
        List<InventoryModel> GetAllProduct();
        void AddProduct(int id, string name, double price, int quantity, string type);
        void DeleteProduct(int id);
        void UpdateProduct(int id, string name, double price, int quantity, string type);
    }
}
