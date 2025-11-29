namespace RefactoringRoadMap.ExtractFunction;

public class ExtractFunction
{
    //Before Extract Function refactoring
    void Before_ExtractFunction(Invoice invoice)
    {
        PrintBanner();
        decimal outstanding = CalculateOutstanding();

        // print details
        Console.WriteLine($"name: {invoice.Customer}");
        Console.WriteLine($"amount: {outstanding}");
    }
    
    //After Extract Function refactoring
    void After_ExtractFunction(Invoice invoice)
    {
        PrintBanner();
        decimal outstanding = CalculateOutstanding();
        
        PrintDetails(invoice, outstanding);
    }

    private static void PrintDetails(Invoice invoice, decimal outstanding)
    {
        Console.WriteLine($"name: {invoice.Customer}");
        Console.WriteLine($"amount: {outstanding}");
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

internal class Invoice
{
    public string Customer { get; set; }

    public void Send()
    {
        throw new NotImplementedException();
    }
}