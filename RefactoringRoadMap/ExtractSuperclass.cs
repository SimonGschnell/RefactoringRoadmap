namespace RefactoringRoadMap;

public class ExtractSuperclass
{
    // this refactoring is useful when you want to reduce the size of a class, and when the class has variables that are semantically related
    // if the semantically related variables are used for different classes then the variables can be bundled and be extracted as a superclass
    
    //Before ExtractSuperclass refactoring
    class Soldier
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public int militaryRank { get; set; }

        public int calculateWage()
        {
            return 5000;
        }
    }
    
    class Programmer
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public int yearsOfExperience { get; set; }

        public int calculateWage()
        {
            return 6000;
        }
    }
    
    //After ExtractSuperclass refactoring
    private class Person
    {
        public string Name { get; set; }
        public string Age { get; set; }

        public virtual int calculateWage()
        {
            return 1000;
        }
    }

    class Soldier2: Person
    {
        public int militaryRank { get; set; }
        public override int calculateWage()
        {
            return 5000;
        }
    }
    
    class Programmer2: Person
    {
        public int yearsOfExperience { get; set; }
        public override int calculateWage()
        {
            return 6000;
        }
    }
}

