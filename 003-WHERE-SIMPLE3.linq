<Query Kind="Program" />

void Main()
{
	List<Product> products = GetProductList();
	products.Dump();
	
	var expensiveInStockProducts = products.Where(x=>x.UnitsInStock > 0 && x.UnitPrice > 3);
	
	Console.WriteLine("In-stock products that cost more than 3.00:");
	foreach(var product in expensiveInStockProducts)
	{
		Console.WriteLine("{0} is in stock and costs more than 3.00", product.ProductName);
	}
}

List<Product> GetProductList()
{
		return new List<Product> { 
				new Product { UnitsInStock = 0, ProductName = "Chef Anton's Mix", UnitPrice = 4.00 },
				new Product { UnitsInStock = 0, ProductName = "Alice Mutton", UnitPrice = 1.00 },
				new Product { UnitsInStock = 0, ProductName = "Gorgonzola Telino", UnitPrice = 14.00 },
				new Product { UnitsInStock = 0, ProductName = "Perth Pasties", UnitPrice = 5.00 },
				new Product { UnitsInStock = 3, ProductName = "Mac", UnitPrice = 3.00 },
				new Product { UnitsInStock = 2, ProductName = "iPhone3", UnitPrice = 2.00 },
				new Product { UnitsInStock = 2, ProductName = "iPhone4", UnitPrice = 4.00 },
				new Product { UnitsInStock = 0, ProductName = "iPhone5", UnitPrice = 5.00 },
				new Product { UnitsInStock = 44, ProductName = "iPhone6", UnitPrice = 10.00 },
			};
}

public class Product
{
	public string ProductName;
	public int UnitsInStock;
	public double UnitPrice;
}
