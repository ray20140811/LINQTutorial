<Query Kind="Program" />

void Main()
{
	List<Product> products = GetProductList();
	products.Dump();
	
	var soldOutProducts = products.Where(x=>x.UnitsInStock == 0);
	foreach(var product in soldOutProducts)
	{
		Console.WriteLine("{0} is sold out!", product.ProductName);
	}
}

List<Product> GetProductList()
{
		return new List<Product> { 
				new Product { UnitsInStock = 0, ProductName = "Chef Anton's Mix"},
				new Product { UnitsInStock = 0, ProductName = "Alice Mutton"},
				new Product { UnitsInStock = 0, ProductName = "Gorgonzola Telino"},
				new Product { UnitsInStock = 0, ProductName = "Perth Pasties"},
				new Product { UnitsInStock = 3, ProductName = "Mac"},
				new Product { UnitsInStock = 2, ProductName = "iPhone3"},
				new Product { UnitsInStock = 2, ProductName = "iPhone4"},
				new Product { UnitsInStock = 0, ProductName = "iPhone5"},
				new Product { UnitsInStock = 44, ProductName = "iPhone6"},
			};
}

public class Product
{
	public string ProductName;
	public int UnitsInStock;
}
