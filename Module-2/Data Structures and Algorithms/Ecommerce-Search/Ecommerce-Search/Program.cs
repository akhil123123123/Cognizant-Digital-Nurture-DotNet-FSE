using System;

class Product
{
    public int ProductId;
    public string ProductName;

    public Product(int id, string name)
    {
        ProductId = id;
        ProductName = name;
    }
}

class Program
{
    static Product LinearSearch(Product[] products, int id)
    {
        foreach (Product p in products)
        {
            if (p.ProductId == id)
                return p;
        }
        return null;
    }

    static Product BinarySearch(Product[] products, int id)
    {
        int left = 0;
        int right = products.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (products[mid].ProductId == id)
                return products[mid];

            else if (products[mid].ProductId < id)
                left = mid + 1;

            else
                right = mid - 1;
        }

        return null;
    }

    static void Main()
    {
        Product[] products =
        {
            new Product(1,"Laptop"),
            new Product(2,"Mobile"),
            new Product(3,"Tablet"),
            new Product(4,"Watch")
        };

        Console.WriteLine("Linear Search Result:");

        Product result1 = LinearSearch(products, 3);

        if (result1 != null)
            Console.WriteLine("Product Found: " + result1.ProductName);


        Console.WriteLine("\nBinary Search Result:");

        Product result2 = BinarySearch(products, 4);

        if (result2 != null)
            Console.WriteLine("Product Found: " + result2.ProductName);
    }
}