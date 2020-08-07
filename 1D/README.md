Requirements:
Write a program that will take in a 4 digit integer and calculate the sum of its digits without ever converting the integer to a string.


Encountered bugs:
- Yet again, forgot a "!" in while condition, so I was getting exact opposite result of checking for correct input.
- When added second condition to my while loop condition, the condition was always true. The issue was use of && operand rather than ||. Using || fixed the issue
- Encountered bug where sometimes the final result would be what seemed like the amount of digits, f.e. 5555 would return 23 instead of 20. The solution was to add method Math.Floor to my Convert.ToInt16(inputNumber / Math.Pow(10, i))
- To resolve both previous issues I returned both calculated values into console within each Loop cycle to check for errors.


Resources:
Previous projects in this repository.