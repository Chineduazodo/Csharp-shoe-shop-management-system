

// Define the shoe sizes and their prices.
int priceOfLarge = 1000;
int priceOfMedium = 500;
int priceOfSmall = 100;
string userChoice = string.Empty;
int finalPrice = 0;
// Welcome customers to the shoe shop and ask them which size they want to buy.
Console.WriteLine("Welcome to my Shoe Shop!");
Console.WriteLine("We have the following shoe sizes available:  \n1. Large - $1000\n2. Medium - $500\n3. Small - $100");
Console.WriteLine("Which Size Do you want to buy?");


// Read the customer's input and determine the price based on the size they choose.
Console.WriteLine($"please select 1-3");
int choice = Convert.ToInt32(Console.ReadLine());
if (choice == 1)
{
    userChoice = "Large";
}
else if (choice == 2)
{
    userChoice = "Medium";
}
else if (choice == 3)
{
    userChoice = "Small";
}
else
{
    Console.WriteLine("Invalid choice. Please select a valid option.");
    return;
}

Console.WriteLine($"You have selected {userChoice}");

// Calculate the final price based on the customer's choice and display it to them.

if (userChoice == "Large")
{
    finalPrice = priceOfLarge;
}
else if (userChoice == "Medium")
{
    finalPrice = priceOfMedium;
}
else if (userChoice == "Small")
{
    finalPrice = priceOfSmall;
}
Console.WriteLine($"The price of the {userChoice} shoe is ${finalPrice}");

// Allow the customwer select multiple choices
Console.WriteLine("\nhow many pairs of this shoe do you want to buy?");
int quantity = Convert.ToInt32(Console.ReadLine());

// calculate the subtotal of how many pairs chosen
int subTotal = finalPrice * quantity;
Console.WriteLine($"subtotal for {quantity} pair(s):${subTotal}");

// delivery fees and customers location
Console.WriteLine("\nWhere would you like your order delivered to?");
Console.WriteLine("1.within jos city (#5000)");
Console.WriteLine("2.Outside jos city (10000)");
Console.WriteLine("Select delivey option (1-2),");

int deliveryChoice = Convert.ToInt32(Console.ReadLine());
int deliveryFee = 0;
string deliveryLocation = string.Empty;
if (deliveryChoice == 1)
{
    deliveryFee = 5000;
    deliveryLocation = "within jos city";
}
else if(deliveryChoice == 2)
{
    deliveryFee = 10000;
    deliveryLocation = "Outside jos city";
}
else
{
    Console.WriteLine("Invalid delivery choice");
}

// If the customer has a discount code(promo code)
Console.WriteLine("\n do you have a discount code? (Type 'NO' if you do not any):");
string discountCode = Console.ReadLine();

int discountAmount = 0;

//checking the code.Using .ToUpper()ensures the code works even if the type lower case
if(discountCode.Trim().ToUpper() == "CJ CLASSIC 23")
{
    discountAmount = 50;
    Console.WriteLine($"\n success! promo code applied; -${discountAmount} off your order.");
}
else if(discountCode.Trim().ToUpper() != "NONE")
{
    Console.WriteLine("\n Invalid discount code.No discount applied.");

    //calculate the new subtotal after discount
    int totalAfterDiscount = subTotal - discountAmount;
}

    // Calculating the final price including the delivery
    int finalTotal = discountAmount + deliveryFee;

// display the  breakthrough to the client
Console.WriteLine("\n ---ORDER SUMMARRY---");
Console.WriteLine($"Subtotal: ${subTotal}");
Console.WriteLine($"Discount Applied: -${discountAmount}");
Console.WriteLine($"Delivery Fee: #{discountAmount}");
Console.WriteLine($"Total Amountto pay: ${discountAmount} + #{deliveryFee}");
Console.WriteLine("--------");
Console.WriteLine("THANK YOU FOR YOUR PATRONAGE WE HOPE YOU WHERE SATISFIED WITH OUR SERVICES AND HOPE TO SEE YOU SOON AGAIN!");
Console.ReadLine();