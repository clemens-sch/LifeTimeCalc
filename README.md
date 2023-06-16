# LifeTimeCalc
Program Description
The WF_LifeTimeCalculator program is a Windows Forms application that calculates and displays an individual's lifetime in years, days, hours, minutes, and seconds based on their birth date. It provides a user interface with an input field for entering the birth date and a "Calculate" button to trigger the calculation.

Program Structure
The program is written in C# and utilizes the Windows Forms framework. It consists of a single form (Form1) with various controls, including a maskedTextBoxInput for entering the birth date and labels (labelYears, labelDays, labelHours, labelMinutes, labelSeconds) for displaying the calculated lifetime in different units.

Functionality
The CalcLifeTime method is responsible for calculating the lifetime based on the entered birth date. It uses the DateTime.TryParse method to parse the input string into a valid DateTime object representing the birth date. If the parsing is successful, it calculates the difference between the current date and the birth date using the DateTime.Now property and the - operator, resulting in a TimeSpan object (LifeTime) representing the elapsed time.

The method then performs various calculations to determine the lifetime in different units (years, days, hours, minutes, seconds) by accessing the respective properties of the TimeSpan object. The calculated values are rounded to two decimal places using the RoundValue method and displayed in the corresponding labels after formatting them with spaces using the FormatNumberWithSpaces method.

If the birth date input cannot be parsed, an error message is displayed using a message box.

Utility Methods
RoundValue: This method takes a double value as input and returns the rounded value with two decimal places using the Math.Round method.

FormatNumberWithSpaces: This method takes a double number as input and returns a formatted string representation of that number with spaces inserted every three digits. It facilitates better readability of large numbers by visually separating the digits.

Usage
To calculate the lifetime, enter the birth date in the maskedTextBoxInput field and click the "Calculate" button. The program will display the calculated lifetime in years (labelYears), days (labelDays), hours (labelHours), minutes (labelMinutes), and seconds (labelSeconds), respectively.

If the birth date format is invalid, an error message will be shown in a message box.
