namespace RefactoringRoadMap.ReplaceParameterWithQuery;

// ReplaceParameterWithQuery is used when a parameter of a method can be derived from another parameter
// the goal is to replace the derived parameter with a query on another parameter
// the goal of this refactoring is to reduce the size of parameter list of a function

public class ReplaceParameterWithQuery
{
    //Before ReplaceParameterWithQuery refactoring
    void Before_ReplaceParameterWithQuery(Employee employee, int grade)
    {
        // calculation
    }
    
    //After ReplaceParameterWithQuery refactoring
    void After_ReplaceParameterWithQuery(Employee employee)
    {
        int grade = employee.Grade;
        // calculation
    }

}

internal class Employee
{
    public int Grade { get; set; }
}