# Turfsport RAP Team Technical Assesment
Technical Assessment for the Regression and Performance Team at Turfsport


## General Programming test

### Objective

The purpose of this test is to assess your ability to write a small section of code in an Object Oriented language. Your code should demonstrate good coding practises but should also be functional, error free, and readable.

### Requirements

Write a class that implements method(s) to convert a monetary amount into its word equivalent. The input monetary amount will be greater than -R1000.00 and less than R1000.00 and may consist of no more than 2 decimal places (additional decimal places should be ignored).  The conversion must be robust and report errors when they occur. 
Please provide some way of testing your code.

The following are examples of inputs and outputs from your function.

| Input     | Output
|:---------:|:-----------------------------------------:|
| R 0       | zero rand                                 |
| R 0.00    | zero rand and zero cents                  |
| R 12      | twelve rand                               |
| -R 22     | minus twenty two rand                     |
| R 122.01  | one hundred and twelve rand and one cent  |
| 200       | Two hundred rand                          |
| R a       | Error (invalid rand value)                |
| 100.0x    | Error (invalid cents values)              |
|           | Error (empty string)                      |
| 1000      | Error (rand value out of range)           |

You may assume the following:

- The currency symbol will always be ‘R’ but may not be present.
- The minus symbol will always appear in front of the rand value but may not be present
- The cents component may not appear
- Ignore decimal values below 0.01

