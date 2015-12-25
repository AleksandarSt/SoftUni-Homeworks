using System;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace Orders
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            var dataMapper = new DataMapper();
            var categories = dataMapper.GetAllCategories();
            var products = dataMapper.GetAllProducts();
            var orders = dataMapper.GetAllOrders();


            // Names of the 5 most expensive products
            var mostExpensiveProducts = products
                .OrderByDescending(p => p.UnitPrice)
                .Take(5)
                .Select(p => p.Name);

            Console.WriteLine("Most Expensive Products:");

            Console.WriteLine(string.Join(Environment.NewLine, mostExpensiveProducts));

            Console.WriteLine(new string('-', 10));


            // Number of products in each category
            var mostExpensiveByCategory = products
                .GroupBy(p => p.CategoryId)
                .Select
                (
                    grp => new 
                            { 
                                Category = categories.First(c => c.Id == grp.Key).Name, 
                                Count = grp.Count()
                            }
                )
                .ToList();

            Console.WriteLine("Number of products in each category:");

            foreach (var item in mostExpensiveByCategory)
            {
                Console.WriteLine("{0}: {1}", item.Category, item.Count);
            }

            Console.WriteLine(new string('-', 10));


            // The 5 top products (by order quantity)
            var mostOrderedProducts = orders
                .GroupBy(o => o.ProductId)
                .Select
                (
                    grp => new
                    { 
                        Product = products.First(p => p.Id == grp.Key).Name, 
                        Quantities = grp.Sum(x => x.Quantity) 
                    }
                )
                .OrderByDescending(q => q.Quantities)
                .Take(5);

            Console.WriteLine("Top products by ordered quantity:");

            foreach (var item in mostOrderedProducts)
            {
                Console.WriteLine("{0}: {1}", item.Product, item.Quantities);
            }

            Console.WriteLine(new string('-', 10));


            // The most profitable category
            var mostProfitableCategory = orders
                .GroupBy(o => o.ProductId)
                .Select
                (
                    g => new 
                    { 
                        catId = products.First(p => p.Id == g.Key).CategoryId,
                        price = products.First(p => p.Id == g.Key).UnitPrice,
                        quantity = g.Sum(p => p.Quantity) 
                    }
                 )
                .GroupBy(category => category.catId)
                .Select
                (
                    grp =>
                        new 
                        {
                            categoryName = categories.First(c => c.Id == grp.Key).Name,
                            totalQuantity = grp.Sum(g => g.quantity * g.price) 
                        }
                )
                .OrderByDescending(g => g.totalQuantity)
                .First();

            Console.WriteLine("Most profitable category:");
            Console.WriteLine("{0}: {1}", mostProfitableCategory.categoryName, mostProfitableCategory.totalQuantity);
        }
    }
}
