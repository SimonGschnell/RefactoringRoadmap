using System.Diagnostics;

namespace RefactoringRoadMap;

public class IntroduceAssertion
{
    // The Introduce Assertion refactoring is useful if there is a state that is required by the system to work properly
    // Instead of implicitly covering the bug by a workaround
    // We introduce an assertion that enforces the state to be correct for the system
    // If the assertion is triggered then we are sure that there is a bug in the code
    // The assertion makes the code also more semantically readable. instead of using a comment we can use an assertion.
    
    private int BasePrice { get; set; } = 50;
    
    //Before IntroduceAssertion refactoring
    int Before_IntroduceAssertion(int amount)
    {
        if (amount < 0)
        {
            return 0;
        }

        return BasePrice + (amount * BasePrice);
    }
    
    //After IntroduceAssertion refactoring
    int After_IntroduceAssertion(int amount)
    {
        // Debug.Assert only asserts in debug mode, perfect for catching bugs before releasing 
        Debug.Assert(amount > 0);
        // Tract.Assert also asserts in release mode. Making sure that the required state for the system is met
        Trace.Assert(amount > 0);
        return BasePrice + (amount * BasePrice);
    }
}

