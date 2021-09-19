# Bienvenue à la Boulangerie Pierre (Welcome to Pierre's Bakery)


#### By Alex Dominguez
## Description:
A bakery program that a user can decide how pieces of loaves/pastry they want.
Program also in Spanish and French soon!
Conditions: 
      Bread: Buy 2, get 1 free (every 3rd loaf of bread is free.). A single loaf costs $5, two loaves costs $10, and three loaves cost $10.
     Pastry: Buy 1 for $2 or 3 for $5. Four pastries costs $7, five pastries costs $9, and six pastries costs $10.


## Technologies Used :
* _NuGet Package Manager_
* _.Net 5_
* _REPL_



## Setup/Installation Requirements :

* _Clone github repo: https://github.com/dominguezsantal/PierresBakery.git_
* _Navigate the directory: (cd top name directory)_
* _Open in Vs code: code ._
* _Navigate to the ProjectName.Tests within the terminal: cd Bakery.Tests_
* _Run: dotnet restore_
* _The line above will create your obj directories._

## Tests:
Test Number | Failed/Passed | Details | 
--- | --- | --- |
1a | Failed on purpose | Test for the cost of 1 loaf of bread. The loaf price was changed to $11, but it's supposed to be  5|
1b | Passed | Test restored to $5|
2a | Failed | Test for the cost of 3 loaf of bread. The loaf price was changed to $25, but it's supposed to be 10|
2b | Passed | Test restored to $10|
3a | Failed | Test for the cost of 5 loaf of bread. The loaf price was changed to $200, but it's supposed to be 20|
3b | Passed | Test restored to 20|
4a | Failed | Test for the cost of 1 pastry. I made the pastry free for 1 pastry, but for the first pastry it's supposed to be $2-only free for the third pastry if they buy 2 pastries!|
4b | Passed| Test restored to $2|
5a| Failed | Test 5a Fail: make 3 pastries for $100 instad of $5.Quite pricy for an error!|
5b| Passed | Test restored to $5|
6a| Failed | pastry logic by adding regQuant in order for succesful fail|
6b|Passed| Pastry test Restored to updatedQuant|
7a|Passed| Return Menu or X works|
## License :
MIT &copy; 2021 _Alex Dominguez_
