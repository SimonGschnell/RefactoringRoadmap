namespace RefactoringRoadMap;

public class ReplaceTempWithQuery
{
   
    private double _quantity;
    private double _itemPrice;
    
    //Before Extract Function refactoring
    public double Before_ReplaceTempWithQuery()
    {
        double basePrice = _quantity * _itemPrice;
        if (basePrice > 1000)
        {
            return basePrice * 0.95;
        }
        else
        {
            return basePrice * 0.98;
        }
    }
    
    //After Extract Function refactoring
    public double After_ReplaceTempWithQuery()
    {
        if (BasePrice() > 1000)
        {
            return BasePrice() * 0.95;
        }
        else
        {
            return BasePrice() * 0.98;
        }
    }

    private double BasePrice()
    {
        return _quantity * _itemPrice;
    }
    
}

