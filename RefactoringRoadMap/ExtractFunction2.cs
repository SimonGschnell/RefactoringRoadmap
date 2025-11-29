namespace RefactoringRoadMap.ExtractFunction2;

// extract function can be used to remove duplicated code that is used in two different methods
// if the duplicated code is not identical, slide statement can be used to bring similar items together for easier extraction

public class ExtractFunction2
{
    //Before Extract Function refactoring
    public void ProcessOnlineOrder(int orderId)
    {
        Console.WriteLine("Validating order " + orderId);
        Console.WriteLine("Checking inventory for order " + orderId);
        Console.WriteLine("Charging payment for order " + orderId);
        Console.WriteLine("Sending confirmation email for order " + orderId);

        Console.WriteLine("Online order processed successfully!");
    }

    public void ProcessInStoreOrder(int orderId)
    {
        Console.WriteLine("Validating order " + orderId);
        Console.WriteLine("Checking inventory for order " + orderId);
        Console.WriteLine("Charging payment for order " + orderId);
        Console.WriteLine("Printing receipt for order " + orderId);

        Console.WriteLine("In-store order processed successfully!");
    }
    
    //After Extract Function refactoring
    public void ProcessOnlineOrder2(int orderId)
    {
        PrintOrderPreparation(orderId);
        Console.WriteLine("Sending confirmation email for order " + orderId);

        Console.WriteLine("Online order processed successfully!");
    }

    public void ProcessInStoreOrder2(int orderId)
    {
        PrintOrderPreparation(orderId);
        Console.WriteLine("Printing receipt for order " + orderId);

        Console.WriteLine("In-store order processed successfully!");
    }
    
    //After Removing primitive obsession with introduce parameter object + move method to another type + make method non static refactoring
    
    public void ProcessOnlineOrder3(Order order)
    {
        order.PrintOrderPreparation();
        Console.WriteLine("Sending confirmation email for order " + order.OrderId);

        Console.WriteLine("Online order processed successfully!");
    }

    public void ProcessInStoreOrder3(Order order)
    {
        order.PrintOrderPreparation();
        Console.WriteLine("Printing receipt for order " + order.OrderId);

        Console.WriteLine("In-store order processed successfully!");
    }
    
    public static void PrintOrderPreparation(int orderId)
    {
        Console.WriteLine("Validating order " + orderId);
        Console.WriteLine("Checking inventory for order " + orderId);
        Console.WriteLine("Charging payment for order " + orderId);
    }
    
    public class Order
    {
        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public int OrderId { get; private set; }

        public void PrintOrderPreparation()
        {
            Console.WriteLine("Validating order " + OrderId);
            Console.WriteLine("Checking inventory for order " + OrderId);
            Console.WriteLine("Charging payment for order " + OrderId);
        }
    }

    //-UNRELATED-IMPLEMENTATION-DETAILS-----------------------------------------------------------------------------------------------------------------------------
    private decimal CalculateOutstanding()
    {
        throw new NotImplementedException();
    }

    private void PrintBanner()
    {
        throw new NotImplementedException();
    }
}