Feature: MathematicalOperations
This feature is to test Mathemtical Operations

@Addition
Scenario Outline: Verify addition of two numbers
This scenario is to test Additon Operation
	Given the first number is <number1> and the second number is <number2>
	When the two numbers are added
	Then the addition result should be <result>
	Examples: 
	| number1 | number2 | result |
	| 10      | 20      | 30     |

@Subtraction
Scenario Outline: Verify subtraction of two numbers
This scenario is to test Subtraction Operation
	Given the first number is <number1> and the second number is <number2>
	When the two numbers are subtracted
	Then the subtraction result should be <result>
	Examples: 
	| number1 | number2 | result |
	| 30      | 20      | 10     |

@Multiplication
Scenario Outline: Verify multiplication of two numbers
This scenario is to test Multiplication Operation
	Given the first number is <number1> and the second number is <number2>
	When the two numbers are multiplied
	Then the multiplication result should be <result>
Examples:
	| number1 | number2 | result |
	| 10      | 20      | 200    |

@Division
Scenario Outline: Verify division of two numbers
This scenario is to test Division Operation
	Given the first number is <number1> and the second number is <number2>
	When the two numbers are divided
	Then the division result should be <result>
	Examples:
	| number1 | number2 | result |
	| 10      | 20      | 0.5    |