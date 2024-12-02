List<Product> products =
           [
            new Carrot(15),
            new Potato(20, 4),
            new Cucumber(14, 2)
           ];

VegetableShop shop = new ();
shop.AddProducts(products);

shop.PrintProductsInfo();

abstract class Product(decimal basePrice)
{
    protected decimal BasePrice = basePrice;

    public decimal BasePriceValue => BasePrice;

    public abstract decimal Price { get; }

    public abstract string Name { get; }
}

class Carrot(decimal basePrice) : Product(basePrice)
{
    public override decimal Price => BasePriceValue;

    public override string Name => "Carrot";
}

class Potato(decimal basePrice, decimal count) : Product(basePrice)
{
    public decimal Count { get; set; } = count;

    public override decimal Price => BasePriceValue * Count;

    public override string Name => "Potato";
}

class Cucumber(decimal basePrice, decimal count) : Product(basePrice)
{
    public decimal Count { get; set; } = count;

    public override decimal Price => BasePriceValue * Count;

    public override string Name => "Cucumber";
}

class Tomato(decimal basePrice) : Product(basePrice)
{
    public override decimal Price => BasePriceValue;

    public override string Name => "Tomato";
}

class VegetableShop
{
    private readonly List<Product> _products = [];

    public void AddProducts(List<Product> products)
    {
        _products.AddRange(products);
    }

    public void PrintProductsInfo()
    {
        decimal totalPrice = 0;

        foreach (var product in _products)
        {
            string productInfo = $"Product: {product.Name}, Price: {product.BasePriceValue}";

            if (product is Potato potato)
            {
                productInfo += $", Count: {potato.Count}, Total price: {potato.Price}";
            }
            else if (product is Cucumber cucumber)
            {
                productInfo += $", Count: {cucumber.Count}, Total price: {cucumber.Price}";
            }
            else
            {
                productInfo += $", Total price: {product.Price}";
            }

            Console.WriteLine(productInfo);
            totalPrice += product.Price;
        }

        Console.WriteLine($"Total products price: {totalPrice}");
    }
}
