
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
    Console.WriteLine("Please select an item to remove form the inventory.");

    for (int i = 0; i < products.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {products[i].Name}");
    }

    Product chosenProduct = null;
    string userResponse = "";

    while (chosenProduct == null)
    {
        Console.WriteLine("please enter the product number here: ");
        try
        {
            int answer = int.Parse(Console.ReadLine().Trim());

            chosenProduct = products[answer - 1];

            Console.WriteLine(@$"Are you sure you want to remove {chosenProduct.Name}?
                1. Yes, remove it.
                2. cancel");

            try
            {
                userResponse = Console.ReadLine();
                if (userResponse == "1")
                {
                    products.RemoveAt(answer - 1);
                    Console.WriteLine($"You have removed {chosenProduct.Name}");
                    DisplayMenu();
                }
                else if (userResponse == "2")
                {
                    DisplayMenu();
                }
            }
            catch
            {
                Console.WriteLine("Please select 1 to remove and 2 to cancel.");
            }
        }
        catch
        {
            Console.WriteLine("Numbers are only accepted, please try again.");
        }
    }
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    Console.WriteLine("Please enter the products name: ");

    string responseName = Console.ReadLine();

    Console.WriteLine($@"Please select which type of product {responseName} is:
    0. Brass
    1. Poem");

    int responseType = int.Parse(Console.ReadLine());

    Console.WriteLine($"Please enter the price of {responseName}: ");

    int responsePrice = int.Parse(Console.ReadLine());

    Product newProduct = new Product
    {
        Name = responseName,
        ProductTypeId = responseType,
        Price = responsePrice,
    };

    products.Add(newProduct);

    Console.WriteLine($"You've added {newProduct.Name}! it is priced at ${newProduct.Price}!");
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    Console.WriteLine("Please choose a product to update:");

    for (int i = 0; i < products.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {products[i].Name}");
    }

    int userChoice = int.Parse(Console.ReadLine().Trim());
    int productToUpdate = userChoice - 1;

    Product chosenProduct = products[productToUpdate];
    Console.WriteLine($"You chose {chosenProduct.Name}. Its type is {chosenProduct.ProductTypeId} and its price is {chosenProduct.Price}");
    Console.WriteLine("Insert New Name");
    string response1 = Console.ReadLine();
    Console.WriteLine("Insert New Type");
    string response2 = Console.ReadLine();
    Console.WriteLine("Insert New Price");
    string response3 = Console.ReadLine();

    if (!string.IsNullOrEmpty(response1))
    {
        chosenProduct.Name = response1;
    }
    else
    {
        chosenProduct.Name = chosenProduct.Name;
    }
    if (!string.IsNullOrEmpty(response2))
    {
        int productId = int.Parse(response2);
        chosenProduct.ProductTypeId = productId;
    }
    else
    {
        chosenProduct.ProductTypeId = chosenProduct.ProductTypeId;
    }
    if (!string.IsNullOrEmpty(response3))
    {
        chosenProduct.Price = int.Parse(response3);
    }
    else
    {
        chosenProduct.Price = chosenProduct.Price;
    }

    Product updatedProduct = new Product
    {
        Name = chosenProduct.Name,
        ProductTypeId = chosenProduct.ProductTypeId,
        Price = chosenProduct.Price
    };

    Console.WriteLine("The product was updated.");

}
Greeting();
DisplayMenu();
// don't move or change this!
public partial class Program { }