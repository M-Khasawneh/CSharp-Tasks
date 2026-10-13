int addProduct;
double total = 0;
do
{
    Console.Write("Enter a Product Price: ");
    double productPrice = double.Parse(Console.ReadLine());

    Console.Write("Enter a Product Quantity: ");
    int productQuantity = int.Parse(Console.ReadLine());

    total += productPrice * productQuantity;
    Console.WriteLine($"The Total Price of the Product: {total}");

    Console.Write("Add another product? 1 = Yes, 0 = No: ");
    addProduct = int.Parse(Console.ReadLine());

}
while (addProduct != 0);