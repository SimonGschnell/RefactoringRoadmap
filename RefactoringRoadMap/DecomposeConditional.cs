namespace RefactoringRoadMap;

public class DecomposeConditional
{
    private readonly Payment _payment = new Payment();
    
    // This refactoring is used to make long and hard to read methods smaller
    // the goal of this refactoring is to extract the conditions and evaluations inside the if else statement so that it reads like english
    // if there is some semantic connection between the extracted parts with the arguments of the function then they can be moved to those types 

    //Before DecomposeConditional refactoring
    int Before_DecomposeConditional(DateTime currentDate, DateTime summerStart, DateTime summerEnd)
    {
        int payment = 0;
        if (currentDate >= summerStart && currentDate <= summerEnd)
        {
            payment = DateTime.DaysInMonth(summerStart.Year, summerStart.Month) * 10;
        }
        else
        {
            int basepayment =10;
            payment = basepayment * 10;
        }

        return payment;

    }
    
    //After DecomposeConditional refactoring
    int After_DecomposeConditional(DateTime currentDate, Summer summer)
    {
        int payment;
        if (summer.IsSummer(currentDate))
        {
            payment = _payment.SummerPayment(summer);
        }
        else
        {
            payment = _payment.NormalPayment();
        }
        
        // var payment = summer.IsSummer(currentDate) 
        //     ? _payment.SummerPayment(summer) 
        //     : _payment.NormalPayment();

        return payment;
    }
}

public class Summer
{
    public Summer(DateTime summerStart, DateTime summerEnd)
    {
        SummerStart = summerStart;
        SummerEnd = summerEnd;
    }

    public DateTime SummerStart { get; private set; }
    public DateTime SummerEnd { get; private set; }

    public bool IsSummer(DateTime currentDate)
    {
        return currentDate >= SummerStart && currentDate <= SummerEnd;
    }
}

public class Payment
{
    public int NormalPayment()
    {
        int payment;
        int basepayment =10;
        payment = basepayment * 10;
        return payment;
    }

    public int SummerPayment(Summer summer)
    {
        var summerStart = summer.SummerStart;
        return DateTime.DaysInMonth(summerStart.Year, summerStart.Month) * 10;
    }
}

