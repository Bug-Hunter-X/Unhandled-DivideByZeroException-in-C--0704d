# Unhandled DivideByZeroException in C#

This repository demonstrates a common error in C#: an unhandled `DivideByZeroException`. The example code divides an integer by zero, resulting in an exception.  The solution improves upon this by implementing more robust error handling and preventive measures. 

## Bug

The `bug.cs` file contains the flawed code.  It attempts to handle the exception using a `try-catch` block, but there is room for improvement in terms of preventing the exception altogether.

## Solution

The `bugSolution.cs` file offers a more robust solution by adding a check before the division operation to prevent the exception from occurring in the first place.  If a division by zero is detected, a user-friendly message is displayed. 
