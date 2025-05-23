using System;
public class Orders {
    public Orders() {
        //taking orders
        Console.WriteLine("Can I take your order? [Y] or [N]");
        string? customerOrder = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(customerOrder) && customerOrder == "Y") {
            Console.WriteLine("Would you like tomatoes? [Y] or [N]");
            string? tomato = Console.ReadLine();
            Console.WriteLine("Would you like lettuce? [Y] or [N]");
            string? lettuce = Console.ReadLine();
            Console.WriteLine("Would you like cheese? [Y] or [N]");
            string? cheese = Console.ReadLine();
            Console.WriteLine("Would you like sauce? [Y] or [N]");
            string? sauce = Console.ReadLine();
            Console.WriteLine("Would you like BBQ? [Y] or [N]");
            string? bbq = Console.ReadLine();
            Console.WriteLine("Would you like ketchup? [Y] or [N]");
            string? ketchup = Console.ReadLine();
            Console.WriteLine("Please confirm your order.");
            //prints out customer order
            Console.WriteLine(
                "Tomato: " + tomato + " " +
                "Lettuce: " + lettuce + " " + 
                "Cheese: " + cheese + " " +
                "Sauce: " + sauce + " " + 
                "BBQ Sauce: " + bbq + " " + 
                "Ketchup Sauce: " + ketchup);
                //[Y] if the customer order is correct
                //[N] allows customer to reorder
                Console.WriteLine("Is this correct? [Y] or [N]");
                Payments payment = new();
        }

        //end of order if no order is taken
        if (!string.IsNullOrWhiteSpace(customerOrder) && customerOrder == "N") {
            Console.WriteLine("Goodbye.");
        }
    }
}