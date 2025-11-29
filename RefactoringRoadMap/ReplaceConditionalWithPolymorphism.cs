namespace RefactoringRoadMap;

public class ReplaceConditionalWithPolymorphism
{
    // Replace Conditional with Polymorphism is used when there are multiple switch statements checking the same condition.
    // the goal of the refactoring is to remove the big switch statements with multiple polymorphic classes that have their own logic
    // the logic is then not in the single long function but split out to each own polymorphic class
    
    //Before ReplaceConditionalWithPolymorphism refactoring
    string Speak(Animal a)
    {
        int maxAge = a.Type switch
        {
            AnimalType.Cat => 15,
            AnimalType.Dog => 20,
            AnimalType.Fish => 3,
            _ => 0
        };

        switch (a.Type)
        {
            case AnimalType.Cat: return "meow";
            case AnimalType.Dog: return "woof";
            case AnimalType.Fish: return "blub";
        }

        return "";
    }
    
    //After ReplaceConditionalWithPolymorphism refactoring
    string After_ReplaceConditionalWithPolymorphism(Animal a)
    {
        int maxAge = a.maxAge();
        return a.speak();
    }
}

internal enum AnimalType
{
    Cat,
    Dog,
    Fish
}

internal class Dog:Animal
{
    public override string speak()
    {
        return "woof";
    }
    public override int maxAge()
    {
        return 20;
    }
}

internal class Cat:Animal
{
    public override string speak()
    {
        return "meow";
    }
    public override int maxAge()
    {
        return 15;
    }
}

internal class Fish:Animal
{
    public override string speak()
    {
        return "blub";
    }
    public override int maxAge()
    {
        return 3;
    }
}

internal class Animal
{
    public AnimalType Type { get; set; }

    public virtual string speak()
    {
        return "";
    }
    public virtual int maxAge()
    {
        return 0;
    }
}

