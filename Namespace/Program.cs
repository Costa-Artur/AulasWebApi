using Sales;
using Inventory;

Inventory.Product productInventory = new Inventory.Product();

Sales.Product productSales = new Sales.Product();

productInventory.Quantity = 240;
productInventory.Sku = "ABCDEF123456";

productSales.Price = 10.25m;
productSales.PromotionalPrice = 8.99m;