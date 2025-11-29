long functions:
* shorter functions promote health of programs
* the longer a function is the harder to understand
* * if we feel the need to write a comment, use **extract function** instead with a self-explanatory name for the extracted method
*  In order to shorten a function, **extract function** is the most effective refactoring
* a lot of parameters and temporary variables get in the way of extracting functions. 
* temporary variables can be eliminated using the refactoring **replace temp with query**
* Long parameter lists can be slimmed down using the refactorings **Introduce parameter object** and **preserve whole object**
* If the above refactorings were not enough to refactor the long parameter list than the refactoring **replace function with command** can be used
* conditionals and loops are also a sign to extract code to prevent function to get too long, this can be done with **Decompose Conditional**

