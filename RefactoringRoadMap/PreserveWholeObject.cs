namespace RefactoringRoadMap;

public class PreserveWholeObject
{
    // This refactoring is similar to the *Introduce Parameter Object* refactoring. (Instaed of Creating a new object, it reuses the existing object)
    // The goal of the refactoring: if the parameters of a function all belong to the same object/class but, they are passed separately
    // then you can directly pass the object instead of the single object properties
    // - This refactoring also helps to eliminate long parameter lists of functions
    
    public PreserveWholeObject()
    {
        Order order = new Order();
        var before_price = Before_PreserveWholeObject(order.BasePrice, order.TaxRate);
        var after_price = After_PreserveWholeObject(order);
    }
    
    //Before Extract Function refactoring
    public double Before_PreserveWholeObject(double basePrice, double taxRate)
    {
        return basePrice * (1 + taxRate);
    }
    
    //After Extract Function refactoring
    public double After_PreserveWholeObject(Order order)
    {
        return order.BasePrice * (1 + order.TaxRate);
    }
}

public class Order
{
    public double BasePrice { get; set; }
    public double TaxRate { get; set; }
}