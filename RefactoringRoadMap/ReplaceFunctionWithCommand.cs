using System.Runtime.CompilerServices;

namespace RefactoringRoadMap;

public class ReplaceFunctionWithCommand
{
    
    // The replace function with command refactoring replaces a long function that is too long with its own class
    // converting all of its parameters to properties of the class
    // When refactoring functions with long parameter lists, one should try to perform Introduce Object parameter or Preserve Whole Object 
    // If these two refactorings are not enough to slim down the parameter list than replace function with command can be used to convert the function into its own class
    
    // Before refactoring
    public double Score( DateTime dayOfYear, int multiplier, double amplifier)
    {
        double basescore = 10;
        if (dayOfYear.Day > 150)
        {
            basescore += multiplier * amplifier;
        }

        return basescore;
    }
    
    
    //After refactoring

    public class ScoreCalculator
    {
        public ScoreCalculator(DateTime dayOfYear, int multiplier, double amplifier)
        {
            DayOfYear = dayOfYear;
            Multiplier = multiplier;
            Amplifier = amplifier;
        }

        public DateTime DayOfYear { get; private set; }
        public int Multiplier { get; private set; }
        public double Amplifier { get; private set; }

        public double Score2()
        {
            double basescore = 10;
            if (DayOfYear.Day > 150)
            {
                basescore += Multiplier * Amplifier;
            }

            return basescore;
        }
    }
}