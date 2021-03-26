<Query Kind="Program" />

void Main()
{
	List<Customer> customers = GetCustomerList();
	customers.Dump();
	
	var waCustomers = customers.Where(x=>x.Region=="WA");
	
	Console.WriteLine("Customers from Washington and their orders:");
	
	foreach(var customer in waCustomers)
	{
		Console.WriteLine("Customer {0}: {1}", customer.CustomerID, customer.CompanyName);
		
		foreach(var order in customer.Orders)
		{
			Console.WriteLine(" Order {0}: {1}", order.OrderID, order.OrderDate);
		}
	}
}

List<Customer> GetCustomerList()
{
	return new List<Customer> 
	{ 
		new Customer 
		{
			Region = "WA",
			CustomerID = "LAZYK",
			CompanyName = "Lazy K Kountry Store",
			Orders = new List<Order> 
			{ 
				new Order { OrderID = 10482, OrderDate = new DateTime(1997,3,21) },
				new Order { OrderID = 10545, OrderDate = new DateTime(1997,5,22) },
			}
		},
		new Customer 
		{
			Region = "WA",
			CustomerID = "TRAIH",
			CompanyName = "Trail's Head Gourmet Provisioners",
			Orders = new List<Order> 
			{ 
				new Order { OrderID = 10574, OrderDate = new DateTime(1997,6,19) },
				new Order { OrderID = 10577, OrderDate = new DateTime(1997,6,23) },
			}
		},
		new Customer 
		{
			Region = "CA",
			CustomerID = "TARGET",
			CompanyName = "Target In USA",
			Orders = new List<Order> 
			{ 
				new Order { OrderID = 10576, OrderDate = new DateTime(1997,3,9) },
				new Order { OrderID = 10575, OrderDate = new DateTime(1997,8,3) },
			}
		},
		
		
	};
}

public class Customer
{
	public string Region;
	public string CustomerID;
	public string CompanyName;
	public List<Order> Orders;
}

public class Order
{
	public int OrderID;
	public DateTime OrderDate;
}	
