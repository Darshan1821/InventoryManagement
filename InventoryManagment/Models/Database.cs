using System.Collections.Generic;

namespace InventoryManagment.Models
{
    public class Database
    {
        static List<InventoryModel> productList = new List<InventoryModel>(){
                new InventoryModel() { Id=1, Name="Lettuce", Price=10.5, Quantity=50, Type="Leafy Green" },
                new InventoryModel() { Id=2, Name="Cabbage", Price=20, Quantity=100, Type="Cruciferous" },
                new InventoryModel() { Id=3, Name="Pumpkin", Price=30, Quantity=30, Type="Marrow" },
                new InventoryModel() { Id=4, Name="Cauliflower", Price=10, Quantity=25, Type="Cruciferous" },
                new InventoryModel() { Id=5, Name="Zucchini", Price=20.5, Quantity=50, Type="Marrow" },
                new InventoryModel() { Id=6, Name="Yam", Price=30, Quantity=50, Type="Root" },
                new InventoryModel() { Id=7, Name="Spinach", Price=10, Quantity=100, Type="Leafy Green" },
                new InventoryModel() { Id=8, Name="Broccoli", Price=20.2, Quantity=75, Type="Cruciferous" },
                new InventoryModel() { Id=9, Name="Garlic", Price=30, Quantity=20, Type="Leafy Green" },
                new InventoryModel() { Id=10, Name="Silverbeet", Price=10, Quantity=50, Type="Marrow" },
        };

        public static void UpdateProduct(int id, string name, double price, int quantity, string type)
        {
            var productIndex = productList.FindIndex(p => p.Id == id);

            productList[productIndex].Name = name;
            productList[productIndex].Price = price;
            productList[productIndex].Quantity = quantity;
            productList[productIndex].Type = type;
        }

        public static void DeleteProduct(int id)
        {
            productList.RemoveAll(p => p.Id == id);    
        }

        public static List<InventoryModel> GetAllProducts()
        {
            return productList;
        }

        public static void AddProduct(InventoryModel model)
        {
            productList.Add(model);
        }
    }
}
