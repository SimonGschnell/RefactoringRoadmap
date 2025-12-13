REFACTORINGS TO REMOVE DUPLICATED CODE

* if you see the same code structure in more than one place, you can be sure that your program will be better if you find a way to unify them.
* use **extract function** if the duplicated code is the same expression in two different methods
* If the code is similar but not identical, see if **slide statement** can arrage the code so that the similar items are together for easy extraction
  
REFACTORINGS TO REMOVE LONG FUNCTIONS:

* shorter functions promote health of programs
* the longer a function is the harder to understand
* * if we feel the need to write a comment, use **extract function** instead with a self-explanatory name for the extracted method
*  In order to shorten a function, **extract function** is the most effective refactoring
* a lot of parameters and temporary variables get in the way of extracting functions. 
* temporary variables can be eliminated using the refactoring **replace temp with query**
* Long parameter lists can be slimmed down using the refactorings **Introduce parameter object** and **preserve whole object**
* If the above refactorings were not enough to refactor the long parameter list than the refactoring **replace function with command** can be used
* conditionals and loops are also a sign to extract code to prevent function to get too long, this can be done with **Decompose Conditional**
* big switch statements should have its legs turned into single function calls with **extract function**
* if there are multiple switch statement switching on the same condition, use **replace conditional with polymorphism**
* if the legs of a switch statement are semantically related to the switch condition, one could use **replace conditional with polymorphism**
* loops and their code can also be extracted to shorten the function, if it is hard to find a name for the extracted loop, that may because the loop is doing 2 different things
* if loops do 2 different things use **Split Loop** to break out the tasks and extract each split loop

REFACTORINGS TO REMOVE LONG PARAMETER LISTS

* if a parameter can be derived from another parameter then we can use **replace parameter with query**. where we remove the derivable parameter and query it in the function from another parameter

REFACTORINGS TO ELIMINATE GLOBAL DATA

* global data is hard to test and makes code tightly coupled, global data comes in various forms like: singletons, global variables or even class variables
* In order to gradually remove global data the refactoring **encapsulate variable** can be used. This refactoring allows us to control the access of the global data from all callers
* through encapsulate variable the callers can all be redirected to a new object simultaneously and slowly replace the global data by injecting the object to the single callers one by one 

REFACTORING FOR LARGE CLASSES
* When a class has too many fields, that is often an indicator that the class is doing to much
* When a class does too much, duplicated code is also more likely to be present
* **extract superclass** can be used to bundle a set of variables together in a component. This is good for variables that likely belong together, like *depositAmount* and *depositCurrency*.
* Similar prefix or suffix of variables in a class suggest to opportunity for a new component, that houses them.
* also if methods of a class depend on some type field of the class, the refactoring **replace type code with subclasses** can be used to split the different type behaviours into different subclasses, instead of having a long method with different behaviour based on a type
* 