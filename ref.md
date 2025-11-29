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

