
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
string greeting = "Welcome to The Classical Dream store!";

Console.WriteLine(greeting);
//implement your loop here
void Menu()
{
    string choice = null;
    while (choice != "5")
    {
        Console.WriteLine(@"Choose an option:
        1. Display all products
        2. Delete a product
        3. Add a new product
        4. Update product properties
        5. Exit");

        choice = Console.ReadLine();
        if (choice == "1")
        {
            DisplayMenu();
        }
        else if (choice == "2")
        {
            DisplayAllProducts();
        }
        else if (choice == "3")
        {
            DeleteProduct();
        }
        else if (choice == "4")
        {
            AddProduct();
        }
        else if (choice == "5")
        {
            UpdateProduct();
        }
        else
        {
            Console.WriteLine("Please enter a valid menu choice");
        }

    }
};
Menu();
void DisplayMenu()
{
   
}

void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
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

// don't move or change this!
public partial class Program { }