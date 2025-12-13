
using System.Runtime.CompilerServices;

namespace RefactoringRoadMap;

public class ReplaceTypeCodeWithSubclasses
{
    // The ReplaceTypeCodeWithSubclasses refactoring is useful when you want to reduce the size of a class.
    // if the class has methods that have different behaviour based on a type variable
    // then you can use this refactoring to split the different behaviours into subclasses 
    // and create a factory create method in the base class to create an object based on the type you wish to use
    
    //Before ExtractSuperclass refactoring
    public enum MilitaryRank
    {
        Private,
        Sergeant,
        Lieutenant,
        Captain
    }
    class Soldier
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public MilitaryRank Rank { get; set; }

        public void Salute()
        {
            Console.WriteLine("Salute");
        }
        
        public int CalculateWage()
        {
            switch (Rank)
            {
                case MilitaryRank.Private:
                    return 3000;
                case MilitaryRank.Lieutenant:
                    return 5000;
                default:
                    return 1000;
            }
        }
    }
    
    //After ExtractSuperclass refactoring
    public class Soldier2
    {
        public string Name { get; set; }
        public string Age { get; set; }

        public void Salute()
        {
            Console.WriteLine("Salute");
        }

        public static Soldier2 Create(MilitaryRank rank)
        {
            switch (rank)
            {
                case MilitaryRank.Private:
                    return new Private();
                case MilitaryRank.Lieutenant:
                    return new Lieutenant();
                default:
                    return new Soldier2();
            }
        }
        public virtual int CalculateWage()
        {
            return 1000;
        }
    }

    private class Private : Soldier2
    {
        public override int CalculateWage()
        {
            return 3000;
        }
    }

    private class Lieutenant : Soldier2
    {
        public override int CalculateWage()
        {
            return 5000;
        }
    }
    
}





