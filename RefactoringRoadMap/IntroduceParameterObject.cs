namespace RefactoringRoadMap;

public class IntroduceParameterObject
{
    // The purpose of this refactoring is to collect many parameters that belong semantically together and place them together in a separate class
    // - This refactoring is often used to eliminate very long parameter lists on functions
    
    //Before IntroduceParameterObject refactoring
    public void Before_amountInvoiced(DateTime startDate, DateTime endDate)
    {
        throw new NotImplementedException();
    }
    public void Before_amountReceived(DateTime startDate, DateTime endDate)
    {
        throw new NotImplementedException();
    }
    public void Before_amountOverdue(DateTime startDate, DateTime endDate)
    {
        throw new NotImplementedException();
    }
    
    //After IntroduceParameterObject refactoring
    public void After_amountInvoiced(DateRangeObject date)
    {
        throw new NotImplementedException();
    }
    public void After_amountReceived(DateRangeObject date)
    {
        throw new NotImplementedException();
    }
    public void After_amountOverdue(DateRangeObject date)
    {
        throw new NotImplementedException();
    }
    
    public class DateRangeObject(DateTime startDate, DateTime endDate)
    {
    }
}