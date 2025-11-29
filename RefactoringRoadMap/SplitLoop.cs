namespace RefactoringRoadMap;

public class SplitLoop
{
    // the split loop refactoring is used to split the responsibilities of a loop and to make it easier to extract and name them
    // after the split loop has been extracted, it is easier to move it closer to semantically related classes
    
    //Before SplitLoop refactoring
    double Before_SplitLoop(People people) // primitive obsession
    {
        double averageAge = 0;
        double totalSalary = 0;

        foreach (var p in people.person_list)
        {
            averageAge += p.Age;
            totalSalary += p.Salary;
        }

        averageAge = averageAge / people.person_list.Count;
        return averageAge;
    }
    
    //After SplitLoop refactoring
    double After_SplitLoop(People people)
    {
        double averageAge = 0;
        foreach (var p in people.person_list)
        {
            averageAge += p.Age;
        }
        
        double totalSalary = 0;
        foreach (var p in people.person_list)
        {
            totalSalary += p.Salary;
        }

        return averageAge / people.person_list.Count;
    }
    
    //After Additional Extract function refactoring
    // The extracted functions now can be moved closer to the class people because it is semantically connected
    double After_ExtractFunction(People people)
    {
        var averageAge = GetPeopleAgeSum(people);

        var totalSalary = GetSalarySum(people);

        return averageAge / people.person_list.Count;
    }

    private static double GetSalarySum(People people)
    {
        double totalSalary = 0;
        foreach (var p in people.person_list)
        {
            totalSalary += p.Salary;
        }

        return totalSalary;
    }

    private static double GetPeopleAgeSum(People people)
    {
        double averageAge = 0;
        foreach (var p in people.person_list)
        {
            averageAge += p.Age;
        }

        return averageAge;
    }
}

internal class People
{
    public List<Person> person_list = new List<Person>();
}

internal class Person
{
    public Person(double age)
    {
        Age = age;
    }

    public double Age { get; set; }
    public double Salary { get; set; }
}

