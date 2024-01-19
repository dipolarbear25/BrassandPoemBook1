
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.
List<Product> products = new()
{
    new Product()
    {
        Name = "Trumpet",
        ProductTypeId = 1,
        Price = 5,
    },
    new Product()
    {
        Name = "French horn",
        ProductTypeId = 1,
        Price = 10,
    },
    new Product()
    {
        Name = "The Raven",
        ProductTypeId = 2,
        Price = 2,
    },
    new Product()
    {
        Name = "Alone",
        ProductTypeId = 2,
        Price = 5,
    },
    new Product()
    {
        Name = "Lenore",
        ProductTypeId = 2,
        Price = 3,
    }
};
//create a "productTypes" variable here with a List of ProductTypes, and add "Brass" and "Poem" types to the List. 
List<ProductType> productType = new()
{
    new ProductType()
    {
        Title = "Brass Instruments",
        Id = 1
    },
    new ProductType()
    {
        Title = "Poems",
        Id = 2
    }

};
//put your greeting here
void Greeting()
{
    Console.WriteLine("Welcome to The Classical Dream store!");
}
//implement your loop here
void DisplayMenu()
{
    string choice = null;
    while (choice != "5")
    {
        Console.WriteLine(@"Please select a number from the menu below
        1. Display all products
        2. Delete a product
        3. Add a new product
        4. Update product properties
        5. Exit");

        choice = (Console.ReadLine().Trim());

        if (choice == "1")
        {
            DisplayAllProducts(products, productType);
        }
        else if (choice == "2")
        {
            DeleteProduct(products, productType);
        }
        else if (choice == "3")
        {
            AddProduct(products, productType);
        }
        else if (choice == "4")
        {
            UpdateProduct(products, productType);
        }
        else if (choice == "5")
        {
            Console.WriteLine("Goodbye");
        }
        else
        {
            Console.WriteLine("Please select a valid option");
        }
    }
}

void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    for (int i = 0; i < products.Count; i++)
    {
        Console.WriteLine(productsDetails(products[i]));
    }
}

string productsDetails(Product products)
{
    string productstring = @$"A {products.Name} is available for {products.Price}";

    return productstring;
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}
Greeting();
DisplayMenu();
// don't move or change this!
public partial class Program { }