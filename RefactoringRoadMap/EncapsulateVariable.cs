namespace RefactoringRoadMap;

public class EncapsulateVariable
{
    // The encapsulate variable refactoring enables us to centralize the access to global data
    // centralizing access enables us to easily change structure like additional validation or logging
    // When we want to remove singletons then encapsulate variable is the first step 
    // this refactoring the allows us to redirect all the traffic from the callers to a new target 
    // old code can gradually transition to dependency injection because through the encapsulate variable refactoring we can redirect callers of the old code to the new DI object

    //Before EncapsulateVariable refactoring
    
    public class Settings
    {
        private static Settings _instance = new Settings();

        public static Settings Instance => _instance;

        public int MagicNumber = 0;
    }
    
    void Before_ExtractFunction()
    {
        Settings.Instance.MagicNumber = 5;
    }
    
    int Before_ExtractFunction2(int test)
    {
        return Settings.Instance.MagicNumber * 2;
    }
    
    //After EncapsulateVariable refactoring
    public class Settings2
    {
        public DISettings Settings { get; }

        public Settings2(DISettings settings)
        {
            Settings = settings;
        }
        private static Settings2 _instance = new Settings2(new DISettings());

        public static Settings2 Instance => _instance;

        private int _magicNumber = 0;

        // encapsulations allows us to redirect all callers to a new object that can be gradually injected to the single callers to slowly remove the global data singleton
        public int MagicNumber
        {
            get { return Settings._magicNumber; }
            set
            {
                // add logging 
                // add validation
                Settings._magicNumber = value;
            }
        }

    }
    
    void After_ExtractFunction()
    {
        Settings2.Instance.MagicNumber = 5;
    }
    
    int After_ExtractFunction2(int test)
    {
        return Settings2.Instance.MagicNumber * 2;
    }
}

public class DISettings
{
    public int _magicNumber;
}