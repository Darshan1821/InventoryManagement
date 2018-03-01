using InventoryManagment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagment.Repository
{
    public interface IInventoryRepository
    {
        List<InventoryModel> GetAllProduct();
        List<InventoryModel> AddProduct(int id, string name, double price, int quantity, string type);
        List<InventoryModel> DeleteProduct(string name);
        List<InventoryModel> UpdateProduct(int id, string name, double price, int quantity, string type);
    }
}
